namespace Gai
{
    partial class avtorization
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
            this.ApllyBT = new System.Windows.Forms.Button();
            this.RoleCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ApllyBT
            // 
            this.ApllyBT.Location = new System.Drawing.Point(145, 202);
            this.ApllyBT.Name = "ApllyBT";
            this.ApllyBT.Size = new System.Drawing.Size(147, 41);
            this.ApllyBT.TabIndex = 0;
            this.ApllyBT.Text = "Принять";
            this.ApllyBT.UseVisualStyleBackColor = true;
            this.ApllyBT.Click += new System.EventHandler(this.ApllyBT_Click);
            // 
            // RoleCB
            // 
            this.RoleCB.FormattingEnabled = true;
            this.RoleCB.Items.AddRange(new object[] {
            "Администратор",
            "Клиент"});
            this.RoleCB.Location = new System.Drawing.Point(161, 123);
            this.RoleCB.Name = "RoleCB";
            this.RoleCB.Size = new System.Drawing.Size(121, 24);
            this.RoleCB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите роль";
            // 
            // avtorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoleCB);
            this.Controls.Add(this.ApllyBT);
            this.Name = "avtorization";
            this.Text = "avtorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApllyBT;
        private System.Windows.Forms.ComboBox RoleCB;
        private System.Windows.Forms.Label label1;
    }
}