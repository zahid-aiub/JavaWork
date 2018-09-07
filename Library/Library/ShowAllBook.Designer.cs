using System;

namespace Library
{
    partial class ShowAllBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.cseBtn = new System.Windows.Forms.Button();
            this.eeeBtn = new System.Windows.Forms.Button();
            this.bbaBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.scBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.arBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search your book by dephartment";
            // 
            // cseBtn
            // 
            this.cseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cseBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cseBtn.Location = new System.Drawing.Point(88, 125);
            this.cseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cseBtn.Name = "cseBtn";
            this.cseBtn.Size = new System.Drawing.Size(355, 33);
            this.cseBtn.TabIndex = 1;
            this.cseBtn.Text = "Computer Science and Engineering";
            this.cseBtn.UseVisualStyleBackColor = true;
            this.cseBtn.Click += new System.EventHandler(this.cseBtn_Click);
            // 
            // eeeBtn
            // 
            this.eeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eeeBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.eeeBtn.Location = new System.Drawing.Point(88, 186);
            this.eeeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eeeBtn.Name = "eeeBtn";
            this.eeeBtn.Size = new System.Drawing.Size(355, 33);
            this.eeeBtn.TabIndex = 2;
            this.eeeBtn.Text = "Electrical and Electronics Engineering";
            this.eeeBtn.UseVisualStyleBackColor = true;
            this.eeeBtn.Click += new System.EventHandler(this.eeeBtn_Click);
            // 
            // bbaBtn
            // 
            this.bbaBtn.Location = new System.Drawing.Point(88, 243);
            this.bbaBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bbaBtn.Name = "bbaBtn";
            this.bbaBtn.Size = new System.Drawing.Size(355, 34);
            this.bbaBtn.TabIndex = 3;
            this.bbaBtn.Text = "Business Administration";
            this.bbaBtn.UseVisualStyleBackColor = true;
            this.bbaBtn.Click += new System.EventHandler(this.bbaBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(98, 508);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(564, 52);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(98, 611);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(564, 51);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // scBtn
            // 
            this.scBtn.Location = new System.Drawing.Point(88, 353);
            this.scBtn.Name = "scBtn";
            this.scBtn.Size = new System.Drawing.Size(352, 33);
            this.scBtn.TabIndex = 7;
            this.scBtn.Text = "Social Science";
            this.scBtn.UseVisualStyleBackColor = true;
            this.scBtn.Click += new System.EventHandler(this.scBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(599, 35);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 29);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.button8_Click);
            // 
            // arBtn
            // 
            this.arBtn.Location = new System.Drawing.Point(88, 302);
            this.arBtn.Name = "arBtn";
            this.arBtn.Size = new System.Drawing.Size(355, 32);
            this.arBtn.TabIndex = 9;
            this.arBtn.Text = "Architecture";
            this.arBtn.UseVisualStyleBackColor = true;
            this.arBtn.Click += new System.EventHandler(this.arBtn_Click);
            // 
            // ShowAllBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 494);
            this.Controls.Add(this.arBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.scBtn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bbaBtn);
            this.Controls.Add(this.eeeBtn);
            this.Controls.Add(this.cseBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShowAllBook";
            this.Text = "ShowAllBook";
            this.Load += new System.EventHandler(this.ShowAllBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button cseBtn;
        public System.Windows.Forms.Button eeeBtn;
        public System.Windows.Forms.Button bbaBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button scBtn;
        private System.Windows.Forms.Button backBtn;
        public System.Windows.Forms.Button arBtn;
    }
}