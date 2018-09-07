namespace Library
{
    partial class AdminWork
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
            this.cseBtn = new System.Windows.Forms.Button();
            this.eeeBtn = new System.Windows.Forms.Button();
            this.bbaBtn = new System.Windows.Forms.Button();
            this.arcBtn = new System.Windows.Forms.Button();
            this.socBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cseBtn
            // 
            this.cseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cseBtn.Location = new System.Drawing.Point(83, 75);
            this.cseBtn.Name = "cseBtn";
            this.cseBtn.Size = new System.Drawing.Size(302, 31);
            this.cseBtn.TabIndex = 0;
            this.cseBtn.Text = "Computer Science and Engineering";
            this.cseBtn.UseVisualStyleBackColor = true;
            this.cseBtn.Click += new System.EventHandler(this.cseBtn_Click);
            // 
            // eeeBtn
            // 
            this.eeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eeeBtn.Location = new System.Drawing.Point(85, 135);
            this.eeeBtn.Name = "eeeBtn";
            this.eeeBtn.Size = new System.Drawing.Size(302, 31);
            this.eeeBtn.TabIndex = 1;
            this.eeeBtn.Text = "Electrical and Electronics Engineering";
            this.eeeBtn.UseVisualStyleBackColor = true;
            this.eeeBtn.Click += new System.EventHandler(this.eeeBtn_Click);
            // 
            // bbaBtn
            // 
            this.bbaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbaBtn.Location = new System.Drawing.Point(85, 195);
            this.bbaBtn.Name = "bbaBtn";
            this.bbaBtn.Size = new System.Drawing.Size(302, 31);
            this.bbaBtn.TabIndex = 1;
            this.bbaBtn.Text = "Biuness  Administration";
            this.bbaBtn.UseVisualStyleBackColor = true;
            this.bbaBtn.Click += new System.EventHandler(this.bbaBtn_Click);
            // 
            // arcBtn
            // 
            this.arcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arcBtn.Location = new System.Drawing.Point(86, 255);
            this.arcBtn.Name = "arcBtn";
            this.arcBtn.Size = new System.Drawing.Size(302, 31);
            this.arcBtn.TabIndex = 1;
            this.arcBtn.Text = "Architecture ";
            this.arcBtn.UseVisualStyleBackColor = true;
            this.arcBtn.Click += new System.EventHandler(this.arcBtn_Click);
            // 
            // socBtn
            // 
            this.socBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.socBtn.Location = new System.Drawing.Point(85, 315);
            this.socBtn.Name = "socBtn";
            this.socBtn.Size = new System.Drawing.Size(302, 31);
            this.socBtn.TabIndex = 1;
            this.socBtn.Text = "Social Science";
            this.socBtn.UseVisualStyleBackColor = true;
            this.socBtn.Click += new System.EventHandler(this.socBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(616, 27);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(71, 32);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // AdminWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 476);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.socBtn);
            this.Controls.Add(this.arcBtn);
            this.Controls.Add(this.bbaBtn);
            this.Controls.Add(this.eeeBtn);
            this.Controls.Add(this.cseBtn);
            this.Name = "AdminWork";
            this.Text = "AdminWork";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cseBtn;
        private System.Windows.Forms.Button eeeBtn;
        private System.Windows.Forms.Button bbaBtn;
        private System.Windows.Forms.Button arcBtn;
        private System.Windows.Forms.Button socBtn;
        private System.Windows.Forms.Button backBtn;
    }
}