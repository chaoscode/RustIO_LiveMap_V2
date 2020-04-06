namespace WindowsFormsApplication6
{
    partial class Settings
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
            this.ServerPortBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerNameBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SIDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ServerPortBox
            // 
            this.ServerPortBox.Location = new System.Drawing.Point(148, 34);
            this.ServerPortBox.Name = "ServerPortBox";
            this.ServerPortBox.Size = new System.Drawing.Size(59, 20);
            this.ServerPortBox.TabIndex = 11;
            this.ServerPortBox.Text = "28016";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Server:";
            // 
            // ServerNameBox
            // 
            this.ServerNameBox.Location = new System.Drawing.Point(12, 34);
            this.ServerNameBox.Name = "ServerNameBox";
            this.ServerNameBox.Size = new System.Drawing.Size(130, 20);
            this.ServerNameBox.TabIndex = 9;
            this.ServerNameBox.Text = "108.61.120.168";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(102, 254);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(117, 54);
            this.OkButton.TabIndex = 12;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.Ok_Click);
            // 
            // SIDBox
            // 
            this.SIDBox.Location = new System.Drawing.Point(13, 88);
            this.SIDBox.Name = "SIDBox";
            this.SIDBox.Size = new System.Drawing.Size(194, 20);
            this.SIDBox.TabIndex = 13;
            this.SIDBox.Text = "j2rzfQ6sYGbICBkEJzpH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "SID";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SIDBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ServerPortBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServerNameBox);
            this.Name = "Settings";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox ServerPortBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox ServerNameBox;
        private System.Windows.Forms.Button OkButton;
        public System.Windows.Forms.TextBox SIDBox;
        private System.Windows.Forms.Label label1;
    }
}