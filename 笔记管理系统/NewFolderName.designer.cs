namespace 笔记管理系统
{
    partial class NewFolderName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFolderName));
            this.tvFolderName = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvFolderName
            // 
            this.tvFolderName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tvFolderName.Location = new System.Drawing.Point(12, 12);
            this.tvFolderName.Name = "tvFolderName";
            this.tvFolderName.Size = new System.Drawing.Size(203, 21);
            this.tvFolderName.TabIndex = 0;
            this.tvFolderName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tvFolderName_KeyPress);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(230, 12);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // NewFolderName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 46);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tvFolderName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewFolderName";
            this.Text = "NewFolderName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tvFolderName;
        private System.Windows.Forms.Button btnConfirm;
    }
}