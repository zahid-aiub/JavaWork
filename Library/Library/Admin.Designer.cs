namespace Library
{
    partial class Admin
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
            this.addBookBtn = new System.Windows.Forms.Button();
            this.deleteBookBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.allstudentlistBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addBookBtn
            // 
            this.addBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addBookBtn.Location = new System.Drawing.Point(96, 50);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(150, 36);
            this.addBookBtn.TabIndex = 0;
            this.addBookBtn.Text = "Add Book";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // deleteBookBtn
            // 
            this.deleteBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBookBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deleteBookBtn.Location = new System.Drawing.Point(96, 123);
            this.deleteBookBtn.Name = "deleteBookBtn";
            this.deleteBookBtn.Size = new System.Drawing.Size(150, 40);
            this.deleteBookBtn.TabIndex = 1;
            this.deleteBookBtn.Text = "Delete Book";
            this.deleteBookBtn.UseVisualStyleBackColor = true;
            this.deleteBookBtn.Click += new System.EventHandler(this.deleteBookBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.logOutBtn.Location = new System.Drawing.Point(583, 50);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(75, 36);
            this.logOutBtn.TabIndex = 3;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // allstudentlistBtn
            // 
            this.allstudentlistBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allstudentlistBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.allstudentlistBtn.Location = new System.Drawing.Point(96, 191);
            this.allstudentlistBtn.Name = "allstudentlistBtn";
            this.allstudentlistBtn.Size = new System.Drawing.Size(150, 38);
            this.allstudentlistBtn.TabIndex = 4;
            this.allstudentlistBtn.Text = "All Student List";
            this.allstudentlistBtn.UseVisualStyleBackColor = true;
            this.allstudentlistBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 459);
            this.Controls.Add(this.allstudentlistBtn);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.deleteBookBtn);
            this.Controls.Add(this.addBookBtn);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button deleteBookBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button allstudentlistBtn;
    }
}