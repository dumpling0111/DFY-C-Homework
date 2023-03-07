namespace WinCaculator
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
            strNumber1 = new TextBox();
            strNumber2 = new TextBox();
            caculateButton = new Button();
            labelNumber1 = new Label();
            labelNumber2 = new Label();
            labelOperate = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            calculateResult = new Label();
            SuspendLayout();
            // 
            // strNumber1
            // 
            strNumber1.Location = new Point(338, 86);
            strNumber1.Name = "strNumber1";
            strNumber1.Size = new Size(187, 27);
            strNumber1.TabIndex = 0;
            strNumber1.TextChanged += strNumber1_TextChanged;
            // 
            // strNumber2
            // 
            strNumber2.Location = new Point(338, 210);
            strNumber2.Name = "strNumber2";
            strNumber2.Size = new Size(187, 27);
            strNumber2.TabIndex = 1;
            strNumber2.TextChanged += strNumber2_TextChanged;
            // 
            // caculateButton
            // 
            caculateButton.Location = new Point(338, 284);
            caculateButton.Name = "caculateButton";
            caculateButton.Size = new Size(94, 29);
            caculateButton.TabIndex = 3;
            caculateButton.Text = "计算";
            caculateButton.UseVisualStyleBackColor = true;
            caculateButton.Click += caculateButton_Click;
            // 
            // labelNumber1
            // 
            labelNumber1.AutoSize = true;
            labelNumber1.Location = new Point(234, 89);
            labelNumber1.Name = "labelNumber1";
            labelNumber1.Size = new Size(84, 20);
            labelNumber1.TabIndex = 5;
            labelNumber1.Text = "第一个数字";
            labelNumber1.Click += label1_Click;
            // 
            // labelNumber2
            // 
            labelNumber2.AutoSize = true;
            labelNumber2.Location = new Point(234, 213);
            labelNumber2.Name = "labelNumber2";
            labelNumber2.Size = new Size(84, 20);
            labelNumber2.TabIndex = 6;
            labelNumber2.Text = "第二个数字";
            // 
            // labelOperate
            // 
            labelOperate.AutoSize = true;
            labelOperate.Location = new Point(219, 153);
            labelOperate.Name = "labelOperate";
            labelOperate.Size = new Size(99, 20);
            labelOperate.TabIndex = 7;
            labelOperate.Text = "请选择运算符";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(338, 150);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 28);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 358);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 9;
            label1.Text = "计算结果为";
            // 
            // calculateResult
            // 
            calculateResult.AutoSize = true;
            calculateResult.Location = new Point(338, 358);
            calculateResult.Name = "calculateResult";
            calculateResult.Size = new Size(0, 20);
            calculateResult.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calculateResult);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(labelOperate);
            Controls.Add(labelNumber2);
            Controls.Add(labelNumber1);
            Controls.Add(caculateButton);
            Controls.Add(strNumber2);
            Controls.Add(strNumber1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox strNumber1;
        private TextBox strNumber2;
        private Button caculateButton;
        private Label labelNumber1;
        private Label labelNumber2;
        private Label labelOperate;
        private ComboBox comboBox1;
        private Label label1;
        private Label calculateResult;
    }
}