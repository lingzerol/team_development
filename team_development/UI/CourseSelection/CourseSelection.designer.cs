namespace team_development.UI.CourseSelection
{
    partial class CourseSelection
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
            this.CourseInfo = new System.Windows.Forms.DataGridView();
            this.TimingSelection = new System.Windows.Forms.Button();
            this.Selection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CourseInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseInfo
            // 
            this.CourseInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseInfo.Location = new System.Drawing.Point(33, 0);
            this.CourseInfo.Name = "CourseInfo";
            this.CourseInfo.RowTemplate.Height = 27;
            this.CourseInfo.Size = new System.Drawing.Size(1009, 450);
            this.CourseInfo.TabIndex = 1;
            this.CourseInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseInfo_CellContentClick);
            // 
            // TimingSelection
            // 
            this.TimingSelection.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimingSelection.Location = new System.Drawing.Point(787, 518);
            this.TimingSelection.Name = "TimingSelection";
            this.TimingSelection.Size = new System.Drawing.Size(111, 38);
            this.TimingSelection.TabIndex = 2;
            this.TimingSelection.Text = "定时选课";
            this.TimingSelection.UseVisualStyleBackColor = true;
            this.TimingSelection.Click += new System.EventHandler(this.TimingSelection_Click);
            // 
            // Selection
            // 
            this.Selection.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Selection.Location = new System.Drawing.Point(935, 518);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(107, 38);
            this.Selection.TabIndex = 3;
            this.Selection.Text = "立即选课";
            this.Selection.UseVisualStyleBackColor = true;
            this.Selection.Click += new System.EventHandler(this.Selection_Click);
            // 
            // CourseSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 568);
            this.Controls.Add(this.Selection);
            this.Controls.Add(this.TimingSelection);
            this.Controls.Add(this.CourseInfo);
            this.Name = "CourseSelection";
            this.Text = "course_selection";
            this.Load += new System.EventHandler(this.Course_selection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CourseInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView CourseInfo;
        private System.Windows.Forms.Button TimingSelection;
        private System.Windows.Forms.Button Selection;
    }

}