namespace Gai
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
            this.ConnectionBT = new System.Windows.Forms.Button();
            this.lbStatusText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelBT = new System.Windows.Forms.Button();
            this.ApllyBT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectionBT
            // 
            this.ConnectionBT.Location = new System.Drawing.Point(681, 406);
            this.ConnectionBT.Name = "ConnectionBT";
            this.ConnectionBT.Size = new System.Drawing.Size(107, 32);
            this.ConnectionBT.TabIndex = 0;
            this.ConnectionBT.Text = "Подключение";
            this.ConnectionBT.UseVisualStyleBackColor = true;
            this.ConnectionBT.Click += new System.EventHandler(this.ConnectionBT_Click);
            // 
            // lbStatusText
            // 
            this.lbStatusText.AutoSize = true;
            this.lbStatusText.Location = new System.Drawing.Point(12, 425);
            this.lbStatusText.Name = "lbStatusText";
            this.lbStatusText.Size = new System.Drawing.Size(81, 16);
            this.lbStatusText.TabIndex = 1;
            this.lbStatusText.Text = "lbStatusText";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelBT);
            this.panel1.Controls.Add(this.ApllyBT);
            this.panel1.Location = new System.Drawing.Point(588, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 388);
            this.panel1.TabIndex = 2;
            // 
            // CancelBT
            // 
            this.CancelBT.Location = new System.Drawing.Point(3, 362);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(75, 23);
            this.CancelBT.TabIndex = 1;
            this.CancelBT.Text = "Отмена";
            this.CancelBT.UseVisualStyleBackColor = true;
            // 
            // ApllyBT
            // 
            this.ApllyBT.Location = new System.Drawing.Point(122, 362);
            this.ApllyBT.Name = "ApllyBT";
            this.ApllyBT.Size = new System.Drawing.Size(75, 23);
            this.ApllyBT.TabIndex = 0;
            this.ApllyBT.Text = "Принять";
            this.ApllyBT.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbStatusText);
            this.Controls.Add(this.ConnectionBT);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectionBT;
        private System.Windows.Forms.Label lbStatusText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Button ApllyBT;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}