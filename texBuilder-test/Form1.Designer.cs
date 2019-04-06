namespace texBuilder_test
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InputFile_Box = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.Label();
            this.Convert_Button = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OpenFile_Button = new System.Windows.Forms.Button();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.Save_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(474, 486);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(473, 486);
            this.textBox1.TabIndex = 1;
            // 
            // InputFile_Box
            // 
            this.InputFile_Box.AllowDrop = true;
            this.InputFile_Box.Location = new System.Drawing.Point(12, 24);
            this.InputFile_Box.Name = "InputFile_Box";
            this.InputFile_Box.Size = new System.Drawing.Size(75, 19);
            this.InputFile_Box.TabIndex = 2;
            this.InputFile_Box.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox3_DragDrop);
            this.InputFile_Box.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox3_DragEnter);
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.Location = new System.Drawing.Point(12, 9);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(24, 12);
            this.input.TabIndex = 3;
            this.input.Text = "File";
            // 
            // Convert_Button
            // 
            this.Convert_Button.Location = new System.Drawing.Point(12, 77);
            this.Convert_Button.Name = "Convert_Button";
            this.Convert_Button.Size = new System.Drawing.Size(75, 23);
            this.Convert_Button.TabIndex = 4;
            this.Convert_Button.Text = "Convert";
            this.Convert_Button.UseVisualStyleBackColor = true;
            this.Convert_Button.Click += new System.EventHandler(this.Convert_Button_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(93, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Size = new System.Drawing.Size(963, 492);
            this.splitContainer1.SplitterDistance = 479;
            this.splitContainer1.TabIndex = 5;
            // 
            // OpenFile_Button
            // 
            this.OpenFile_Button.Location = new System.Drawing.Point(63, 48);
            this.OpenFile_Button.Name = "OpenFile_Button";
            this.OpenFile_Button.Size = new System.Drawing.Size(24, 23);
            this.OpenFile_Button.TabIndex = 6;
            this.OpenFile_Button.Text = "...";
            this.OpenFile_Button.UseVisualStyleBackColor = true;
            this.OpenFile_Button.Click += new System.EventHandler(this.OpenFile_Button_Click);
            // 
            // OpenDialog
            // 
            this.OpenDialog.Filter = "bTeXファイル|*.btex|テキストファイル|*.txt";
            // 
            // SaveDialog
            // 
            this.SaveDialog.Filter = "TeXファイル|*.tex";
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(12, 106);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 7;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 516);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.OpenFile_Button);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Convert_Button);
            this.Controls.Add(this.input);
            this.Controls.Add(this.InputFile_Box);
            this.MinimumSize = new System.Drawing.Size(300, 180);
            this.Name = "Form1";
            this.Text = "BetterTeX Converter";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox InputFile_Box;
        private System.Windows.Forms.Label input;
        private System.Windows.Forms.Button Convert_Button;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button OpenFile_Button;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.Button Save_Button;
    }
}

