using Folder_Sorter.FileWork;

namespace Folder_Sorter
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
            FolderBrowserDialog folderDlg = new()
            {
                ShowNewFolderButton = true
            };

            DialogResult result = folderDlg.ShowDialog();

            if (result != DialogResult.OK) { return;}

            tbSelectedFolder.Text = folderDlg.SelectedPath;
            lvFiles.Items.Clear();

            foreach (string path in Directory.GetFiles(folderDlg.SelectedPath))
            {
                FileInfo file = new(path);
                bool hidden = file.Attributes.HasFlag(FileAttributes.Hidden);
                bool system = file.Attributes.HasFlag(FileAttributes.System);

                if ((hidden && !cbHidden.Checked) ||
                    (system && !cbSystem.Checked))
                {
                    continue;
                }

                string attribute = "None";

                if (hidden && system) attribute = "Hidden, System";
                else if (hidden) attribute = "Hidden";
                else if (system) attribute = "System";

                lvFiles.Items.Add(
                    new ListViewItem([
                        file.Name,
                        file.Extension,
                        file.Length.ToString(),
                        file.CreationTime.ToString(),
                        file.LastAccessTime.ToString(),
                        attribute
                    ])
                    { Tag = file }
                );
            }
        }

        private void ListView_Load()
        {
            lvFiles.View = View.Details;
            lvFiles.FullRowSelect = true;
            lvFiles.GridLines = true;

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
    }
}
