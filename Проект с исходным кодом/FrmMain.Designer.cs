namespace IT_Lab2
{
    partial class FrmMain
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
            panel1 = new Panel();
            panel2 = new Panel();
            LabelPolynomText = new Label();
            LabelPolynom = new Label();
            LabelCount = new Label();
            LabelPrimKey = new Label();
            TxtBoxPrimKey = new TextBox();
            RBtnEncr = new RadioButton();
            RBtnDecr = new RadioButton();
            LabelOperType = new Label();
            BtnStart = new Button();
            BtnSaveFile = new Button();
            BtnOpenFile = new Button();
            RichTxtBoxInitText = new RichTextBox();
            RichTxtBoxKey = new RichTextBox();
            RichTxtBoxResultText = new RichTextBox();
            LabelInitText = new Label();
            LabelKey = new Label();
            LabelResultText = new Label();
            LabelDigitsCount = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SpringGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(BtnStart);
            panel1.Controls.Add(BtnSaveFile);
            panel1.Controls.Add(BtnOpenFile);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 728);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(LabelPolynomText);
            panel2.Controls.Add(LabelPolynom);
            panel2.Controls.Add(LabelCount);
            panel2.Controls.Add(LabelPrimKey);
            panel2.Controls.Add(TxtBoxPrimKey);
            panel2.Controls.Add(RBtnEncr);
            panel2.Controls.Add(RBtnDecr);
            panel2.Controls.Add(LabelOperType);
            panel2.Location = new Point(-1, 215);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 410);
            panel2.TabIndex = 9;
            // 
            // LabelPolynomText
            // 
            LabelPolynomText.AutoSize = true;
            LabelPolynomText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPolynomText.Location = new Point(23, 366);
            LabelPolynomText.Name = "LabelPolynomText";
            LabelPolynomText.Size = new Size(124, 25);
            LabelPolynomText.TabIndex = 9;
            LabelPolynomText.Text = "x^25+x^3+1";
            // 
            // LabelPolynom
            // 
            LabelPolynom.AutoSize = true;
            LabelPolynom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPolynom.Location = new Point(15, 331);
            LabelPolynom.Name = "LabelPolynom";
            LabelPolynom.Size = new Size(246, 25);
            LabelPolynom.TabIndex = 8;
            LabelPolynom.Text = "Примитивный многочлен:";
            // 
            // LabelCount
            // 
            LabelCount.AutoSize = true;
            LabelCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelCount.Location = new Point(15, 275);
            LabelCount.Name = "LabelCount";
            LabelCount.Size = new Size(240, 25);
            LabelCount.TabIndex = 7;
            LabelCount.Text = "Введено двоичных цифр:";
            // 
            // LabelPrimKey
            // 
            LabelPrimKey.AutoSize = true;
            LabelPrimKey.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPrimKey.Location = new Point(15, 162);
            LabelPrimKey.Name = "LabelPrimKey";
            LabelPrimKey.Size = new Size(287, 25);
            LabelPrimKey.TabIndex = 5;
            LabelPrimKey.Text = "Начальное состояние регистра";
            // 
            // TxtBoxPrimKey
            // 
            TxtBoxPrimKey.Location = new Point(15, 214);
            TxtBoxPrimKey.Name = "TxtBoxPrimKey";
            TxtBoxPrimKey.Size = new Size(300, 31);
            TxtBoxPrimKey.TabIndex = 3;
            TxtBoxPrimKey.TextChanged += TxtBoxPrimKey_TextChanged;
            // 
            // RBtnEncr
            // 
            RBtnEncr.AutoSize = true;
            RBtnEncr.Checked = true;
            RBtnEncr.Location = new Point(15, 68);
            RBtnEncr.Name = "RBtnEncr";
            RBtnEncr.Size = new Size(146, 29);
            RBtnEncr.TabIndex = 0;
            RBtnEncr.TabStop = true;
            RBtnEncr.Text = "Шифрование";
            RBtnEncr.UseVisualStyleBackColor = true;
            // 
            // RBtnDecr
            // 
            RBtnDecr.AutoSize = true;
            RBtnDecr.Location = new Point(15, 115);
            RBtnDecr.Name = "RBtnDecr";
            RBtnDecr.Size = new Size(164, 29);
            RBtnDecr.TabIndex = 1;
            RBtnDecr.Text = "Дешифрование";
            RBtnDecr.UseVisualStyleBackColor = true;
            // 
            // LabelOperType
            // 
            LabelOperType.AutoSize = true;
            LabelOperType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelOperType.Location = new Point(15, 19);
            LabelOperType.Name = "LabelOperType";
            LabelOperType.Size = new Size(136, 25);
            LabelOperType.TabIndex = 6;
            LabelOperType.Text = "Тип операции";
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(15, 641);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(303, 66);
            BtnStart.TabIndex = 4;
            BtnStart.Text = "Выполнить";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // BtnSaveFile
            // 
            BtnSaveFile.Location = new Point(15, 125);
            BtnSaveFile.Name = "BtnSaveFile";
            BtnSaveFile.Size = new Size(303, 66);
            BtnSaveFile.TabIndex = 1;
            BtnSaveFile.Text = "Сохранить в файл";
            BtnSaveFile.UseVisualStyleBackColor = true;
            BtnSaveFile.Click += BtnSaveFile_Click;
            // 
            // BtnOpenFile
            // 
            BtnOpenFile.Location = new Point(15, 29);
            BtnOpenFile.Name = "BtnOpenFile";
            BtnOpenFile.Size = new Size(303, 66);
            BtnOpenFile.TabIndex = 0;
            BtnOpenFile.Text = "Открыть файл";
            BtnOpenFile.UseVisualStyleBackColor = true;
            BtnOpenFile.Click += BtnOpenFile_Click;
            // 
            // RichTxtBoxInitText
            // 
            RichTxtBoxInitText.Location = new Point(391, 60);
            RichTxtBoxInitText.Name = "RichTxtBoxInitText";
            RichTxtBoxInitText.Size = new Size(497, 291);
            RichTxtBoxInitText.TabIndex = 1;
            RichTxtBoxInitText.Text = "";
            // 
            // RichTxtBoxKey
            // 
            RichTxtBoxKey.Location = new Point(928, 60);
            RichTxtBoxKey.Name = "RichTxtBoxKey";
            RichTxtBoxKey.ReadOnly = true;
            RichTxtBoxKey.Size = new Size(481, 291);
            RichTxtBoxKey.TabIndex = 2;
            RichTxtBoxKey.Text = "";
            // 
            // RichTxtBoxResultText
            // 
            RichTxtBoxResultText.Location = new Point(391, 417);
            RichTxtBoxResultText.Name = "RichTxtBoxResultText";
            RichTxtBoxResultText.ReadOnly = true;
            RichTxtBoxResultText.Size = new Size(1018, 303);
            RichTxtBoxResultText.TabIndex = 3;
            RichTxtBoxResultText.Text = "";
            // 
            // LabelInitText
            // 
            LabelInitText.AutoSize = true;
            LabelInitText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelInitText.Location = new Point(391, 23);
            LabelInitText.Name = "LabelInitText";
            LabelInitText.Size = new Size(154, 25);
            LabelInitText.TabIndex = 6;
            LabelInitText.Text = "Исходный текст";
            // 
            // LabelKey
            // 
            LabelKey.AutoSize = true;
            LabelKey.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelKey.Location = new Point(928, 23);
            LabelKey.Name = "LabelKey";
            LabelKey.Size = new Size(63, 25);
            LabelKey.TabIndex = 7;
            LabelKey.Text = "Ключ";
            // 
            // LabelResultText
            // 
            LabelResultText.AutoSize = true;
            LabelResultText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelResultText.Location = new Point(391, 378);
            LabelResultText.Name = "LabelResultText";
            LabelResultText.Size = new Size(96, 25);
            LabelResultText.TabIndex = 8;
            LabelResultText.Text = "Результат";
            // 
            // LabelDigitsCount
            // 
            LabelDigitsCount.AutoSize = true;
            LabelDigitsCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelDigitsCount.Location = new Point(274, 504);
            LabelDigitsCount.Name = "LabelDigitsCount";
            LabelDigitsCount.Size = new Size(0, 25);
            LabelDigitsCount.TabIndex = 8;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 744);
            Controls.Add(RichTxtBoxResultText);
            Controls.Add(RichTxtBoxInitText);
            Controls.Add(LabelResultText);
            Controls.Add(LabelInitText);
            Controls.Add(LabelKey);
            Controls.Add(RichTxtBoxKey);
            Controls.Add(LabelDigitsCount);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StreamEncryption";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private RadioButton RBtnEncr;
        private Button BtnSaveFile;
        private Button BtnOpenFile;
        private Label LabelPrimKey;
        private Button BtnStart;
        private TextBox TxtBoxPrimKey;
        private RadioButton RBtnDecr;
        private RichTextBox RichTxtBoxInitText;
        private RichTextBox RichTxtBoxKey;
        private RichTextBox RichTxtBoxResultText;
        private Label LabelInitText;
        private Label LabelKey;
        private Label LabelResultText;
        private Panel panel2;
        private Label LabelOperType;
        private Label LabelCount;
        private Label LabelDigitsCount;
        private Label LabelPolynom;
        private Label LabelPolynomText;
    }
}