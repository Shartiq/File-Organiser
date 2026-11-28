using FileOrganiser.FileWork;

namespace FileOrganiser
{
    public partial class CreateFolderForm : Form
    {
        private readonly List<FileInfo> fileList;
        private readonly string originalRoot;

        public CreateFolderForm(List<FileInfo> files, string rootPath)
        {
            InitializeComponent();
            ListView_Load();

            fileList = files;
            originalRoot = rootPath;
            tbDestination.Text = rootPath;
        }

        private void ListView_Load()
        {
            lvSelectedFiles.Columns.Add("#", 50);
            lvSelectedFiles.Columns.Add("Name", 375);
            lvSelectedFiles.Columns.Add("Size", 90);
        }

        private void CreateFolderForm_Load(object sender, EventArgs e)
        {
            foreach (FileInfo file in fileList)
            {
                ListViewItem item = CreateListViewItem.CreateCompact(file, lvSelectedFiles.Items.Count + 1);
                lvSelectedFiles.Items.Add(item);

                lblFileCount.Text = $"{lvSelectedFiles.Items.Count} Files";
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderDlg = new()
            {
                ShowNewFolderButton = true
            };

            if (folderDlg.ShowDialog() != DialogResult.OK)
                return;

            tbDestination.Text = folderDlg.SelectedPath;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateFolderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tbDestination.Text != originalRoot || tbFolderName.Text != "New Folder")
            {
                if (MessageBox.Show("Are you sure you want to cancel?", "Confirm Cancellation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string folderName = tbFolderName.Text.Trim();

            if (string.IsNullOrWhiteSpace(folderName))
            {
                MessageBox.Show("Please enter a valid folder name.", "Invalid Folder Name", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(tbDestination.Text))
            {
                MessageBox.Show("The specified destination folder does not exist.", "Invalid Destination", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (folderName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("The folder name contains invalid characters.", "Invalid Folder Name", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string destinationPath = Path.Combine(tbDestination.Text, folderName);

            if (Directory.Exists(destinationPath))
            {
                MessageBox.Show("A folder with the same name already exists in the destination.", "Folder Exists", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (File.Exists(destinationPath))
            {
                MessageBox.Show("A file with the same name already exists in the destination.", "File Exists", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Directory.CreateDirectory(destinationPath);

                foreach (FileInfo file in fileList)
                {
                    string destinationFilePath = Path.Combine(destinationPath, file.Name);
                    file.MoveTo(destinationFilePath);
                }

                MessageBox.Show($"Folder '{folderName}' created successfully at '{destinationPath}'.", "Folder Created",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied while creating the folder or moving files.", "Access Denied", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (IOException ex)
            {
                MessageBox.Show($"An error occurred while creating the folder: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
