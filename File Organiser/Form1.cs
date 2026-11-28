using FileOrganiser.FileWork;

namespace FileOrganiser
{
    public partial class Form1 : Form
    {
        private int lastColumn = -1;
        private bool ascending = true;

        public Form1()
        {
            InitializeComponent();
            ListView_Load();
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderDlg = new()
            {
                ShowNewFolderButton = true
            };

            if (folderDlg.ShowDialog() != DialogResult.OK)
                return;

            tbSelectedFolder.Text = folderDlg.SelectedPath;
            lvFiles.Items.Clear();

            try
            {
                foreach (string path in Directory.GetFiles(folderDlg.SelectedPath))
                {
                    FileInfo file = new(path);

                    ListViewItem? item = CreateListViewItem.CreateDetailed(file,
                        lvFiles.Items.Count + 1,
                        cbHidden.Checked,
                        cbSystem.Checked);

                    if (item is not null) lvFiles.Items.Add(item);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied to the selected folder.");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "File system error");
            }
        }

        private void ListView_Load()
        {
            lvFiles.Columns.Add("#", 50);
            lvFiles.Columns.Add("Name", 500);
            lvFiles.Columns.Add("Extension", 100);
            lvFiles.Columns.Add("Size", 100);
            lvFiles.Columns.Add("Created At", 150);
            lvFiles.Columns.Add("Last Acessed at", 150);
            lvFiles.Columns.Add("Attribute", 150);
        }

        private void lvFiles_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (lastColumn == e.Column) ascending = !ascending;
            else ascending = true;

            lastColumn = e.Column;

            lvFiles.ListViewItemSorter = new FileComparer(e.Column, ascending);
            lvFiles.Sort();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            try 
            {
                if (lvFiles.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select at least one file to create a folder.", "Warning");
                    return;
                }

                CreateFolderForm form = new([.. lvFiles.SelectedItems.Cast<ListViewItem>()
                        .Select(item => item.Tag)
                        .OfType<FileInfo>()], 
                    tbSelectedFolder.Text);
                form.ShowDialog();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "File system error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
