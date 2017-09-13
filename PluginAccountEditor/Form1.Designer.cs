namespace PluginAccountEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.btnSearchResourceFile = new System.Windows.Forms.Button();
            this.txtPathResource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathToNewFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchNewFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер акаунта:";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(113, 14);
            this.txtAccount.MaxLength = 10;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(122, 20);
            this.txtAccount.TabIndex = 1;
            // 
            // btnSearchResourceFile
            // 
            this.btnSearchResourceFile.Location = new System.Drawing.Point(426, 38);
            this.btnSearchResourceFile.Name = "btnSearchResourceFile";
            this.btnSearchResourceFile.Size = new System.Drawing.Size(75, 23);
            this.btnSearchResourceFile.TabIndex = 2;
            this.btnSearchResourceFile.Text = "Обзор";
            this.btnSearchResourceFile.UseVisualStyleBackColor = true;
            this.btnSearchResourceFile.Click += new System.EventHandler(this.btnSearchResourceFile_Click);
            // 
            // txtPathResource
            // 
            this.txtPathResource.Location = new System.Drawing.Point(113, 40);
            this.txtPathResource.Name = "txtPathResource";
            this.txtPathResource.Size = new System.Drawing.Size(307, 20);
            this.txtPathResource.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Исходный файл:";
            // 
            // txtPathToNewFile
            // 
            this.txtPathToNewFile.Location = new System.Drawing.Point(113, 66);
            this.txtPathToNewFile.Name = "txtPathToNewFile";
            this.txtPathToNewFile.Size = new System.Drawing.Size(307, 20);
            this.txtPathToNewFile.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Новый файл:";
            // 
            // btnSearchNewFile
            // 
            this.btnSearchNewFile.Location = new System.Drawing.Point(426, 64);
            this.btnSearchNewFile.Name = "btnSearchNewFile";
            this.btnSearchNewFile.Size = new System.Drawing.Size(75, 23);
            this.btnSearchNewFile.TabIndex = 7;
            this.btnSearchNewFile.Text = "Обзор";
            this.btnSearchNewFile.UseVisualStyleBackColor = true;
            this.btnSearchNewFile.Click += new System.EventHandler(this.btnSearchNewFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(23, 103);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(426, 105);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Выход";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 129);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearchNewFile);
            this.Controls.Add(this.txtPathToNewFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPathResource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchResourceFile);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Внесение акаунта в плагин";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Button btnSearchResourceFile;
        private System.Windows.Forms.TextBox txtPathResource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathToNewFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchNewFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}

