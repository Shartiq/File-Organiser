namespace FileOrganiser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fbdFolder = new FolderBrowserDialog();
            btnBrowseFolder = new Button();
            tbSelectedFolder = new TextBox();
            label1 = new Label();
            lvFiles = new ListView();
            cbHidden = new CheckBox();
            cbSystem = new CheckBox();
            btnCreateFolder = new Button();
            SuspendLayout();
            // 
            // btnBrowseFolder
            // 
            btnBrowseFolder.Location = new Point(1222, 86);
            btnBrowseFolder.Name = "btnBrowseFolder";
            btnBrowseFolder.Size = new Size(241, 23);
            btnBrowseFolder.TabIndex = 0;
            btnBrowseFolder.Text = "Select Folder";
            btnBrowseFolder.UseVisualStyleBackColor = true;
            btnBrowseFolder.Click += btnBrowseFolder_Click;
            // 
            // tbSelectedFolder
            // 
            tbSelectedFolder.Location = new Point(1223, 32);
            tbSelectedFolder.Name = "tbSelectedFolder";
            tbSelectedFolder.PlaceholderText = "None";
            tbSelectedFolder.ReadOnly = true;
            tbSelectedFolder.Size = new Size(241, 23);
            tbSelectedFolder.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(1223, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 3;
            label1.Text = "Selected Folder:";
            // 
            // lvFiles
            // 
            lvFiles.FullRowSelect = true;
            lvFiles.GridLines = true;
            lvFiles.Location = new Point(12, 9);
            lvFiles.Name = "lvFiles";
            lvFiles.Size = new Size(1205, 486);
            lvFiles.TabIndex = 4;
            lvFiles.UseCompatibleStateImageBehavior = false;
            lvFiles.View = View.Details;
            lvFiles.ColumnClick += lvFiles_ColumnClick;
            // 
            // cbHidden
            // 
            cbHidden.AutoSize = true;
            cbHidden.Location = new Point(1223, 61);
            cbHidden.Name = "cbHidden";
            cbHidden.Size = new Size(112, 19);
            cbHidden.TabIndex = 5;
            cbHidden.Text = "Get Hidden Files";
            cbHidden.UseVisualStyleBackColor = true;
            // 
            // cbSystem
            // 
            cbSystem.AutoSize = true;
            cbSystem.Location = new Point(1341, 61);
            cbSystem.Name = "cbSystem";
            cbSystem.Size = new Size(111, 19);
            cbSystem.TabIndex = 6;
            cbSystem.Text = "Get System Files";
            cbSystem.UseVisualStyleBackColor = true;
            // 
            // btnCreateFolder
            // 
            btnCreateFolder.Location = new Point(1223, 115);
            btnCreateFolder.Name = "btnCreateFolder";
            btnCreateFolder.Size = new Size(240, 23);
            btnCreateFolder.TabIndex = 7;
            btnCreateFolder.Text = "Create New Folder";
            btnCreateFolder.UseVisualStyleBackColor = true;
            btnCreateFolder.Click += btnCreateFolder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 507);
            Controls.Add(btnCreateFolder);
            Controls.Add(cbSystem);
            Controls.Add(cbHidden);
            Controls.Add(lvFiles);
            Controls.Add(label1);
            Controls.Add(tbSelectedFolder);
            Controls.Add(btnBrowseFolder);
            Name = "Form1";
            Text = "File Organiser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog fbdFolder;
        private Button btnBrowseFolder;
        private TextBox tbSelectedFolder;
        private ListBox lbFiles;
        private Label label1;
        private ListView lvFiles;
        private CheckBox cbHidden;
        private CheckBox cbSystem;
        private Button btnCreateFolder;
    }
}
