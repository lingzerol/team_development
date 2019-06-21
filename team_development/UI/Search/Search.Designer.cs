namespace team_development.UI.Search
{
    partial class Search
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.choosetype = new System.Windows.Forms.ComboBox();
            this.showitem = new System.Windows.Forms.ListView();
            this.refresh = new System.Windows.Forms.Button();
            this.checkBox_pack = new System.Windows.Forms.CheckBox();
            this.checkBox_ele = new System.Windows.Forms.CheckBox();
            this.checkBox_it = new System.Windows.Forms.CheckBox();
            this.checkBox_nb = new System.Windows.Forms.CheckBox();
            this.checkBox_translate = new System.Windows.Forms.CheckBox();
            this.checkBox_cahs = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 25.8F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "学校新闻和通知";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(485, 22);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(133, 25);
            this.searchBox.TabIndex = 2;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(696, 39);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 25);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "搜索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // choosetype
            // 
            this.choosetype.FormattingEnabled = true;
            this.choosetype.Items.AddRange(new object[] {
            "校内新闻和通知",
            "新浪新闻"});
            this.choosetype.Location = new System.Drawing.Point(324, 24);
            this.choosetype.Name = "choosetype";
            this.choosetype.Size = new System.Drawing.Size(121, 23);
            this.choosetype.TabIndex = 5;
            this.choosetype.Text = "校内新闻";
            this.choosetype.SelectedIndexChanged += new System.EventHandler(this.choosetype_SelectedIndexChanged);
            // 
            // showitem
            // 
            this.showitem.Location = new System.Drawing.Point(20, 70);
            this.showitem.Name = "showitem";
            this.showitem.Size = new System.Drawing.Size(751, 327);
            this.showitem.TabIndex = 6;
            this.showitem.UseCompatibleStateImageBehavior = false;
            this.showitem.SelectedIndexChanged += new System.EventHandler(this.showitem_SelectedIndexChanged);
            this.showitem.Click += new System.EventHandler(this.showitem_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(696, 12);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 7;
            this.refresh.Text = "刷新";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // checkBox_pack
            // 
            this.checkBox_pack.AutoSize = true;
            this.checkBox_pack.Location = new System.Drawing.Point(642, 410);
            this.checkBox_pack.Name = "checkBox_pack";
            this.checkBox_pack.Size = new System.Drawing.Size(59, 19);
            this.checkBox_pack.TabIndex = 9;
            this.checkBox_pack.Text = "包装";
            this.checkBox_pack.UseVisualStyleBackColor = true;
            this.checkBox_pack.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox_ele
            // 
            this.checkBox_ele.AutoSize = true;
            this.checkBox_ele.Location = new System.Drawing.Point(517, 410);
            this.checkBox_ele.Name = "checkBox_ele";
            this.checkBox_ele.Size = new System.Drawing.Size(59, 19);
            this.checkBox_ele.TabIndex = 10;
            this.checkBox_ele.Text = "电气";
            this.checkBox_ele.UseVisualStyleBackColor = true;
            this.checkBox_ele.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // checkBox_it
            // 
            this.checkBox_it.AutoSize = true;
            this.checkBox_it.Location = new System.Drawing.Point(386, 410);
            this.checkBox_it.Name = "checkBox_it";
            this.checkBox_it.Size = new System.Drawing.Size(59, 19);
            this.checkBox_it.TabIndex = 11;
            this.checkBox_it.Text = "智科";
            this.checkBox_it.UseVisualStyleBackColor = true;
            this.checkBox_it.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
            // 
            // checkBox_nb
            // 
            this.checkBox_nb.AutoSize = true;
            this.checkBox_nb.Location = new System.Drawing.Point(265, 410);
            this.checkBox_nb.Name = "checkBox_nb";
            this.checkBox_nb.Size = new System.Drawing.Size(59, 19);
            this.checkBox_nb.TabIndex = 12;
            this.checkBox_nb.Text = "国商";
            this.checkBox_nb.UseVisualStyleBackColor = true;
            this.checkBox_nb.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged_1);
            // 
            // checkBox_translate
            // 
            this.checkBox_translate.AutoSize = true;
            this.checkBox_translate.Location = new System.Drawing.Point(158, 410);
            this.checkBox_translate.Name = "checkBox_translate";
            this.checkBox_translate.Size = new System.Drawing.Size(59, 19);
            this.checkBox_translate.TabIndex = 13;
            this.checkBox_translate.Text = "翻译";
            this.checkBox_translate.UseVisualStyleBackColor = true;
            this.checkBox_translate.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged_1);
            // 
            // checkBox_cahs
            // 
            this.checkBox_cahs.AutoSize = true;
            this.checkBox_cahs.Location = new System.Drawing.Point(42, 410);
            this.checkBox_cahs.Name = "checkBox_cahs";
            this.checkBox_cahs.Size = new System.Drawing.Size(59, 19);
            this.checkBox_cahs.TabIndex = 14;
            this.checkBox_cahs.Text = "人文";
            this.checkBox_cahs.UseVisualStyleBackColor = true;
            this.checkBox_cahs.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged_1);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 568);
            this.Controls.Add(this.checkBox_cahs);
            this.Controls.Add(this.checkBox_translate);
            this.Controls.Add(this.checkBox_nb);
            this.Controls.Add(this.checkBox_it);
            this.Controls.Add(this.checkBox_ele);
            this.Controls.Add(this.checkBox_pack);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.showitem);
            this.Controls.Add(this.choosetype);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox choosetype;
        private System.Windows.Forms.ListView showitem;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.CheckBox checkBox_pack;
        private System.Windows.Forms.CheckBox checkBox_ele;
        private System.Windows.Forms.CheckBox checkBox_it;
        private System.Windows.Forms.CheckBox checkBox_nb;
        private System.Windows.Forms.CheckBox checkBox_translate;
        private System.Windows.Forms.CheckBox checkBox_cahs;
    }
}