namespace Gai
{
    partial class Client
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
            this.lbStatusText = new System.Windows.Forms.Label();
            this.DateCT = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SklonKB = new System.Windows.Forms.ComboBox();
            this.ClearBT = new System.Windows.Forms.Button();
            this.DayscountNUD = new System.Windows.Forms.NumericUpDown();
            this.ApplyBT = new System.Windows.Forms.Button();
            this.equipcount = new System.Windows.Forms.NumericUpDown();
            this.equipCB = new System.Windows.Forms.CheckBox();
            this.AgeTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DayscountNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipcount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStatusText
            // 
            this.lbStatusText.AutoSize = true;
            this.lbStatusText.Location = new System.Drawing.Point(12, 425);
            this.lbStatusText.Name = "lbStatusText";
            this.lbStatusText.Size = new System.Drawing.Size(44, 16);
            this.lbStatusText.TabIndex = 0;
            this.lbStatusText.Text = "label1";
            // 
            // DateCT
            // 
            this.DateCT.Location = new System.Drawing.Point(159, 0);
            this.DateCT.Name = "DateCT";
            this.DateCT.Size = new System.Drawing.Size(200, 22);
            this.DateCT.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SklonKB);
            this.panel1.Controls.Add(this.ClearBT);
            this.panel1.Controls.Add(this.DayscountNUD);
            this.panel1.Controls.Add(this.ApplyBT);
            this.panel1.Controls.Add(this.equipcount);
            this.panel1.Controls.Add(this.equipCB);
            this.panel1.Controls.Add(this.AgeTB);
            this.panel1.Controls.Add(this.nameTB);
            this.panel1.Controls.Add(this.DateCT);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 376);
            this.panel1.TabIndex = 2;
            // 
            // SklonKB
            // 
            this.SklonKB.FormattingEnabled = true;
            this.SklonKB.Items.AddRange(new object[] {
            "Южный",
            "Восточный",
            "Северный",
            "Западный"});
            this.SklonKB.Location = new System.Drawing.Point(238, 113);
            this.SklonKB.Name = "SklonKB";
            this.SklonKB.Size = new System.Drawing.Size(121, 24);
            this.SklonKB.TabIndex = 9;
            // 
            // ClearBT
            // 
            this.ClearBT.Location = new System.Drawing.Point(122, 303);
            this.ClearBT.Name = "ClearBT";
            this.ClearBT.Size = new System.Drawing.Size(103, 32);
            this.ClearBT.TabIndex = 8;
            this.ClearBT.Text = "Очистить";
            this.ClearBT.UseVisualStyleBackColor = true;
            this.ClearBT.Click += new System.EventHandler(this.ClearBT_Click);
            // 
            // DayscountNUD
            // 
            this.DayscountNUD.Location = new System.Drawing.Point(242, 28);
            this.DayscountNUD.Name = "DayscountNUD";
            this.DayscountNUD.Size = new System.Drawing.Size(120, 22);
            this.DayscountNUD.TabIndex = 7;
            // 
            // ApplyBT
            // 
            this.ApplyBT.Location = new System.Drawing.Point(122, 341);
            this.ApplyBT.Name = "ApplyBT";
            this.ApplyBT.Size = new System.Drawing.Size(103, 32);
            this.ApplyBT.TabIndex = 6;
            this.ApplyBT.Text = "Принять";
            this.ApplyBT.UseVisualStyleBackColor = true;
            this.ApplyBT.Click += new System.EventHandler(this.ApplyBT_Click);
            // 
            // equipcount
            // 
            this.equipcount.Location = new System.Drawing.Point(239, 169);
            this.equipcount.Name = "equipcount";
            this.equipcount.Size = new System.Drawing.Size(120, 22);
            this.equipcount.TabIndex = 5;
            this.equipcount.Visible = false;
            // 
            // equipCB
            // 
            this.equipCB.AutoSize = true;
            this.equipCB.Location = new System.Drawing.Point(200, 143);
            this.equipCB.Name = "equipCB";
            this.equipCB.Size = new System.Drawing.Size(159, 20);
            this.equipCB.TabIndex = 4;
            this.equipCB.Text = "Аренда экипировки";
            this.equipCB.UseVisualStyleBackColor = true;
            this.equipCB.CheckedChanged += new System.EventHandler(this.equipCB_CheckedChanged);
            // 
            // AgeTB
            // 
            this.AgeTB.Location = new System.Drawing.Point(159, 87);
            this.AgeTB.Name = "AgeTB";
            this.AgeTB.Size = new System.Drawing.Size(200, 22);
            this.AgeTB.TabIndex = 3;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(159, 59);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(200, 22);
            this.nameTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Выберите дату";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Выберите кол-во дней похода";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Введите имя";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Введите возраст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Выберите склон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Нужна ли экипировка, ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "если да то сколько";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbStatusText);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.Load += new System.EventHandler(this.Client_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DayscountNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipcount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStatusText;
        private System.Windows.Forms.DateTimePicker DateCT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox AgeTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.NumericUpDown equipcount;
        private System.Windows.Forms.CheckBox equipCB;
        private System.Windows.Forms.Button ClearBT;
        private System.Windows.Forms.NumericUpDown DayscountNUD;
        private System.Windows.Forms.Button ApplyBT;
        private System.Windows.Forms.ComboBox SklonKB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}