namespace NotePad
{
    partial class Form1
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listUndo = new System.Windows.Forms.ListBox();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(574, 44);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 34);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "開啟檔案";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(680, 44);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "存檔";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(37, 52);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(497, 381);
            this.rtbText.TabIndex = 2;
            this.rtbText.Text = "";
            this.rtbText.TextChanged += new System.EventHandler(this.rtbText_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listUndo
            // 
            this.listUndo.FormattingEnabled = true;
            this.listUndo.ItemHeight = 12;
            this.listUndo.Location = new System.Drawing.Point(567, 124);
            this.listUndo.Name = "listUndo";
            this.listUndo.Size = new System.Drawing.Size(209, 304);
            this.listUndo.TabIndex = 3;
            // 
            // btnRedo
            // 
            this.btnRedo.Location = new System.Drawing.Point(680, 84);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(96, 34);
            this.btnRedo.TabIndex = 4;
            this.btnRedo.Text = "重作下一步";
            this.btnRedo.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(574, 84);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(100, 34);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.Text = "回復上一步";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(286, 20);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(85, 20);
            this.comboBoxSize.TabIndex = 7;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Location = new System.Drawing.Point(413, 20);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(121, 20);
            this.comboBoxStyle.TabIndex = 8;
            this.comboBoxStyle.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Location = new System.Drawing.Point(59, 20);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(121, 20);
            this.comboBoxFont.TabIndex = 9;
            this.comboBoxFont.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxFont);
            this.Controls.Add(this.comboBoxStyle);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.listUndo);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox listUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.ComboBox comboBoxFont;
    }
}

