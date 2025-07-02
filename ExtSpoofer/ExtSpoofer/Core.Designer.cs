namespace ExtSpoofer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cbFakeExt;
        private System.Windows.Forms.Button btnSpoof;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblExt;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cbFakeExt = new System.Windows.Forms.ComboBox();
            this.btnSpoof = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblExt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(100, 25);
            this.txtFilePath.Size = new System.Drawing.Size(280, 22);
            this.txtFilePath.ReadOnly = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(390, 24);
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.Text = "Look For File";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cbFakeExt
            // 
            this.cbFakeExt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFakeExt.FormattingEnabled = true;
            this.cbFakeExt.Items.AddRange(new object[] {
            ".txt",
            ".jpg",
            ".png",
            ".mp4",
            ".mp3",
            ".pdf",
            ".docx",
            ".xlsx",
            ".zip",
            ".rar"});
            this.cbFakeExt.Location = new System.Drawing.Point(100, 65);
            this.cbFakeExt.Size = new System.Drawing.Size(121, 24);
            // 
            // btnSpoof
            // 
            this.btnSpoof.Location = new System.Drawing.Point(100, 110);
            this.btnSpoof.Size = new System.Drawing.Size(100, 30);
            this.btnSpoof.Text = "Spoof";
            this.btnSpoof.Click += new System.EventHandler(this.btnSpoof_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(20, 28);
            this.lblFile.Text = "File:";
            // 
            // lblExt
            // 
            this.lblExt.AutoSize = true;
            this.lblExt.Location = new System.Drawing.Point(20, 68);
            this.lblExt.Text = "Fake Extension:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 170);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cbFakeExt);
            this.Controls.Add(this.btnSpoof);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblExt);
            this.Name = "Form1";
            this.Text = "ExtSpoofer - keegan31";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
