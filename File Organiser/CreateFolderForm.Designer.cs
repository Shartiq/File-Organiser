namespace FileOrganiser
{
    partial class CreateFolderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbDestination = new TextBox();
            btnBrowse = new Button();
            tbFolderName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lvSelectedFiles = new ListView();
            lblFileCount = new Label();
            btnCreateFolder = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 0;
            label1.Text = "Destination Directory";
            // 
            // tbDestination
            // 
            tbDestination.Location = new Point(12, 32);
            tbDestination.Name = "tbDestination";
            tbDestination.PlaceholderText = "D:Organised Files";
            tbDestination.Size = new Size(232, 23);
            tbDestination.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(250, 31);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // tbFolderName
            // 
            tbFolderName.Location = new Point(331, 31);
            tbFolderName.Name = "tbFolderName";
            tbFolderName.Size = new Size(201, 23);
            tbFolderName.TabIndex = 4;
            tbFolderName.Text = "New Folder";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(331, 9);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 3;
            label2.Text = "New Folder Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 58);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 5;
            label3.Text = "Selected Files";
            // 
            // lvSelectedFiles
            // 
            lvSelectedFiles.FullRowSelect = true;
            lvSelectedFiles.GridLines = true;
            lvSelectedFiles.Location = new Point(12, 81);
            lvSelectedFiles.MultiSelect = false;
            lvSelectedFiles.Name = "lvSelectedFiles";
            lvSelectedFiles.Size = new Size(520, 246);
            lvSelectedFiles.TabIndex = 6;
            lvSelectedFiles.UseCompatibleStateImageBehavior = false;
            lvSelectedFiles.View = View.Details;
            // 
            // lblFileCount
            // 
            lblFileCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFileCount.AutoEllipsis = true;
            lblFileCount.AutoSize = true;
            lblFileCount.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblFileCount.Location = new Point(489, 60);
            lblFileCount.Name = "lblFileCount";
            lblFileCount.Size = new Size(43, 17);
            lblFileCount.TabIndex = 7;
            lblFileCount.Text = "x Files";
            // 
            // btnCreateFolder
            // 
            btnCreateFolder.Location = new Point(421, 333);
            btnCreateFolder.Name = "btnCreateFolder";
            btnCreateFolder.Size = new Size(111, 23);
            btnCreateFolder.TabIndex = 8;
            btnCreateFolder.Text = "Create and Move";
            btnCreateFolder.UseVisualStyleBackColor = true;
            btnCreateFolder.Click += btnCreateFolder_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(304, 333);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateFolderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 363);
            Controls.Add(btnCancel);
            Controls.Add(btnCreateFolder);
            Controls.Add(lblFileCount);
            Controls.Add(lvSelectedFiles);
            Controls.Add(label3);
            Controls.Add(tbFolderName);
            Controls.Add(label2);
            Controls.Add(btnBrowse);
            Controls.Add(tbDestination);
            Controls.Add(label1);
            Name = "CreateFolderForm";
            Text = "Create New Folder";
            FormClosing += CreateFolderForm_FormClosing;
            Load += CreateFolderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbDestination;
        private Button btnBrowse;
        private TextBox tbFolderName;
        private Label label2;
        private Label label3;
        private ListView lvSelectedFiles;
        private Label lblFileCount;
        private Button btnCreateFolder;
        private Button btnCancel;
    }
}