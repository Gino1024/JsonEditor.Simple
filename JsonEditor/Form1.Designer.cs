
namespace JsonEditor
{
    partial class JsonEditor
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.JsonTxt = new System.Windows.Forms.TextBox();
            this.ConvertToTreeBtn = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // JsonTxt
            // 
            this.JsonTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.JsonTxt.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.JsonTxt.Location = new System.Drawing.Point(12, 50);
            this.JsonTxt.Multiline = true;
            this.JsonTxt.Name = "JsonTxt";
            this.JsonTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.JsonTxt.Size = new System.Drawing.Size(355, 614);
            this.JsonTxt.TabIndex = 0;
            // 
            // ConvertToTreeBtn
            // 
            this.ConvertToTreeBtn.BackColor = System.Drawing.Color.DarkGray;
            this.ConvertToTreeBtn.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ConvertToTreeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConvertToTreeBtn.Location = new System.Drawing.Point(406, 285);
            this.ConvertToTreeBtn.Name = "ConvertToTreeBtn";
            this.ConvertToTreeBtn.Size = new System.Drawing.Size(52, 52);
            this.ConvertToTreeBtn.TabIndex = 2;
            this.ConvertToTreeBtn.Text = ">";
            this.ConvertToTreeBtn.UseVisualStyleBackColor = false;
            this.ConvertToTreeBtn.Click += new System.EventHandler(this.ConvertToTreeBtn_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.treeView1.Location = new System.Drawing.Point(497, 50);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(355, 614);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Document";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(491, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tree";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(774, 680);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author Gino";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // JsonEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(864, 707);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.ConvertToTreeBtn);
            this.Controls.Add(this.JsonTxt);
            this.MaximizeBox = false;
            this.Name = "JsonEditor";
            this.Text = "JsonEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox JsonTxt;
        private System.Windows.Forms.Button ConvertToTreeBtn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

