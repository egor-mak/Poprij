namespace Poprij.Views.PartialView
{
    partial class AgentCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentCard));
            this.PercentLbl = new System.Windows.Forms.Label();
            this.PriorityLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.SaleYearLbl = new System.Windows.Forms.Label();
            this.NameTypeAgentLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PercentLbl
            // 
            this.PercentLbl.AutoSize = true;
            this.PercentLbl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PercentLbl.Location = new System.Drawing.Point(829, 12);
            this.PercentLbl.Name = "PercentLbl";
            this.PercentLbl.Size = new System.Drawing.Size(56, 30);
            this.PercentLbl.TabIndex = 11;
            this.PercentLbl.Text = "10%";
            // 
            // PriorityLbl
            // 
            this.PriorityLbl.AutoSize = true;
            this.PriorityLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityLbl.Location = new System.Drawing.Point(200, 130);
            this.PriorityLbl.Name = "PriorityLbl";
            this.PriorityLbl.Size = new System.Drawing.Size(195, 26);
            this.PriorityLbl.TabIndex = 10;
            this.PriorityLbl.Text = "Приоритетность: 10";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLbl.Location = new System.Drawing.Point(200, 90);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(147, 26);
            this.PhoneLbl.TabIndex = 9;
            this.PhoneLbl.Text = "+7 111 111 11 11";
            // 
            // SaleYearLbl
            // 
            this.SaleYearLbl.AutoSize = true;
            this.SaleYearLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaleYearLbl.Location = new System.Drawing.Point(200, 50);
            this.SaleYearLbl.Name = "SaleYearLbl";
            this.SaleYearLbl.Size = new System.Drawing.Size(167, 26);
            this.SaleYearLbl.TabIndex = 8;
            this.SaleYearLbl.Text = "10 продаж за год";
            // 
            // NameTypeAgentLbl
            // 
            this.NameTypeAgentLbl.AutoSize = true;
            this.NameTypeAgentLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTypeAgentLbl.Location = new System.Drawing.Point(200, 12);
            this.NameTypeAgentLbl.Name = "NameTypeAgentLbl";
            this.NameTypeAgentLbl.Size = new System.Drawing.Size(283, 27);
            this.NameTypeAgentLbl.TabIndex = 7;
            this.NameTypeAgentLbl.Text = "Тип | Наименование агента";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AgentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PercentLbl);
            this.Controls.Add(this.PriorityLbl);
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.SaleYearLbl);
            this.Controls.Add(this.NameTypeAgentLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AgentCard";
            this.Size = new System.Drawing.Size(893, 183);
            this.Load += new System.EventHandler(this.AgentCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PercentLbl;
        private System.Windows.Forms.Label PriorityLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label SaleYearLbl;
        private System.Windows.Forms.Label NameTypeAgentLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
