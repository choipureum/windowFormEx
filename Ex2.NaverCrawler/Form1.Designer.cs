
namespace NaverGoogle_AutoCrawler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.BackGroundSearch_btn = new System.Windows.Forms.Button();
            this.SearchResult_btn = new System.Windows.Forms.Button();
            this.ListBoxReset_btn = new System.Windows.Forms.Button();
            this.WindowClose_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("G마켓 산스 Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(661, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "v1.크롤러 by 최푸름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("KoPub돋움체_Pro Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "검색 : ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(77, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 24);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("KoPub돋움체_Pro Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "블로그";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("KoPub돋움체_Pro Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(347, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "비디오";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(20, 136);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(295, 276);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 17;
            this.listBox2.Location = new System.Drawing.Point(347, 136);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(269, 276);
            this.listBox2.TabIndex = 6;
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Location = new System.Drawing.Point(411, 21);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(102, 27);
            this.Search_btn.TabIndex = 7;
            this.Search_btn.Text = "검색: 창모드";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // BackGroundSearch_btn
            // 
            this.BackGroundSearch_btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackGroundSearch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackGroundSearch_btn.Location = new System.Drawing.Point(527, 21);
            this.BackGroundSearch_btn.Name = "BackGroundSearch_btn";
            this.BackGroundSearch_btn.Size = new System.Drawing.Size(128, 27);
            this.BackGroundSearch_btn.TabIndex = 8;
            this.BackGroundSearch_btn.Text = "검색: 백그라운드";
            this.BackGroundSearch_btn.UseVisualStyleBackColor = false;
            this.BackGroundSearch_btn.Click += new System.EventHandler(this.BackGroundSearch_btn_Click);
            // 
            // SearchResult_btn
            // 
            this.SearchResult_btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.SearchResult_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchResult_btn.Location = new System.Drawing.Point(641, 145);
            this.SearchResult_btn.Name = "SearchResult_btn";
            this.SearchResult_btn.Size = new System.Drawing.Size(118, 27);
            this.SearchResult_btn.TabIndex = 9;
            this.SearchResult_btn.Text = "검색결과보기";
            this.SearchResult_btn.UseVisualStyleBackColor = false;
            // 
            // ListBoxReset_btn
            // 
            this.ListBoxReset_btn.BackColor = System.Drawing.Color.IndianRed;
            this.ListBoxReset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListBoxReset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListBoxReset_btn.Location = new System.Drawing.Point(641, 197);
            this.ListBoxReset_btn.Name = "ListBoxReset_btn";
            this.ListBoxReset_btn.Size = new System.Drawing.Size(118, 27);
            this.ListBoxReset_btn.TabIndex = 10;
            this.ListBoxReset_btn.Text = "선택 초기화";
            this.ListBoxReset_btn.UseVisualStyleBackColor = false;
            this.ListBoxReset_btn.Click += new System.EventHandler(this.ListBoxReset_btn_Click);
            // 
            // WindowClose_btn
            // 
            this.WindowClose_btn.BackColor = System.Drawing.Color.IndianRed;
            this.WindowClose_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindowClose_btn.Location = new System.Drawing.Point(641, 252);
            this.WindowClose_btn.Name = "WindowClose_btn";
            this.WindowClose_btn.Size = new System.Drawing.Size(117, 157);
            this.WindowClose_btn.TabIndex = 11;
            this.WindowClose_btn.Text = "모든 창 닫기";
            this.WindowClose_btn.UseVisualStyleBackColor = false;
            this.WindowClose_btn.Click += new System.EventHandler(this.WindowClose_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WindowClose_btn);
            this.Controls.Add(this.ListBoxReset_btn);
            this.Controls.Add(this.SearchResult_btn);
            this.Controls.Add(this.BackGroundSearch_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("KoPub돋움체_Pro Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "v1.크롤러 by 최푸름";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button BackGroundSearch_btn;
        private System.Windows.Forms.Button SearchResult_btn;
        private System.Windows.Forms.Button ListBoxReset_btn;
        private System.Windows.Forms.Button WindowClose_btn;
    }
}

