namespace team_development.UI.QueryMealCard
{
    partial class QueryMealcard
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
            this.rice_card = new System.Windows.Forms.Label();
            this.college_name = new System.Windows.Forms.TextBox();
            this.balance_status = new System.Windows.Forms.TextBox();
            this.report_loss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rice_card
            // 
            this.rice_card.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rice_card.Location = new System.Drawing.Point(86, 56);
            this.rice_card.Name = "rice_card";
            this.rice_card.Size = new System.Drawing.Size(153, 40);
            this.rice_card.TabIndex = 0;
            this.rice_card.Text = "饭卡信息";
            // 
            // college_name
            // 
            this.college_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.college_name.Location = new System.Drawing.Point(302, 160);
            this.college_name.Multiline = true;
            this.college_name.Name = "college_name";
            this.college_name.Size = new System.Drawing.Size(250, 50);
            this.college_name.TabIndex = 1;
            this.college_name.Text = "学院信息\r\n学生姓名";
            // 
            // balance_status
            // 
            this.balance_status.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.balance_status.Location = new System.Drawing.Point(302, 210);
            this.balance_status.Multiline = true;
            this.balance_status.Name = "balance_status";
            this.balance_status.Size = new System.Drawing.Size(250, 50);
            this.balance_status.TabIndex = 2;
            this.balance_status.Text = "     饭卡余额:3.33\r\n     饭卡状态:正常";
            // 
            // report_loss
            // 
            this.report_loss.Location = new System.Drawing.Point(552, 160);
            this.report_loss.Name = "report_loss";
            this.report_loss.Size = new System.Drawing.Size(77, 100);
            this.report_loss.TabIndex = 3;
            this.report_loss.Text = "挂失";
            this.report_loss.UseVisualStyleBackColor = true;
            // 
            // QueryMealcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 615);
            this.Controls.Add(this.report_loss);
            this.Controls.Add(this.balance_status);
            this.Controls.Add(this.college_name);
            this.Controls.Add(this.rice_card);
            this.Name = "QueryMealcard";
            this.Text = "s";
            this.Load += new System.EventHandler(this.MealcardInquiry_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rice_card;
        private System.Windows.Forms.TextBox college_name;
        private System.Windows.Forms.TextBox balance_status;
        private System.Windows.Forms.Button report_loss;
    }
}