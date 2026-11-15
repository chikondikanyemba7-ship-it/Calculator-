namespace Calculator;

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
        btn1 = new Button();
        btn4 = new Button();
        btnDecimal = new Button();
        btn7 = new Button();
        btn8 = new Button();
        btn0 = new Button();
        btn5 = new Button();
        btn2 = new Button();
        btn9 = new Button();
        btnAnswer = new Button();
        btn6 = new Button();
        btn3 = new Button();
        btnClear = new Button();
        btnAdd = new Button();
        btnSub = new Button();
        btnMultiply = new Button();
        btnDivide = new Button();
        txtDisplay = new TextBox();
        SuspendLayout();
        // 
        // btn1
        // 
        btn1.Location = new Point(63, 105);
        btn1.Name = "btn1";
        btn1.Size = new Size(115, 62);
        btn1.TabIndex = 0;
        btn1.Text = "1";
        btn1.UseVisualStyleBackColor = true;
        // 
        // btn4
        // 
        btn4.Location = new Point(63, 173);
        btn4.Name = "btn4";
        btn4.Size = new Size(115, 62);
        btn4.TabIndex = 1;
        btn4.Text = "4";
        btn4.UseVisualStyleBackColor = true;
        // 
        // btnDecimal
        // 
        btnDecimal.Font = new Font("Segoe UI", 18F);
        btnDecimal.Location = new Point(63, 309);
        btnDecimal.Name = "btnDecimal";
        btnDecimal.Size = new Size(115, 62);
        btnDecimal.TabIndex = 2;
        btnDecimal.Text = ".";
        btnDecimal.UseVisualStyleBackColor = true;
        // 
        // btn7
        // 
        btn7.Location = new Point(63, 241);
        btn7.Name = "btn7";
        btn7.Size = new Size(115, 62);
        btn7.TabIndex = 3;
        btn7.Text = "7";
        btn7.UseVisualStyleBackColor = true;
        // 
        // btn8
        // 
        btn8.Location = new Point(193, 241);
        btn8.Name = "btn8";
        btn8.Size = new Size(115, 62);
        btn8.TabIndex = 7;
        btn8.Text = "8";
        btn8.UseVisualStyleBackColor = true;
        // 
        // btn0
        // 
        btn0.Location = new Point(193, 309);
        btn0.Name = "btn0";
        btn0.Size = new Size(115, 62);
        btn0.TabIndex = 6;
        btn0.Text = "0";
        btn0.UseVisualStyleBackColor = true;
        // 
        // btn5
        // 
        btn5.Location = new Point(193, 173);
        btn5.Name = "btn5";
        btn5.Size = new Size(115, 62);
        btn5.TabIndex = 5;
        btn5.Text = "5";
        btn5.UseVisualStyleBackColor = true;
        // 
        // btn2
        // 
        btn2.Location = new Point(193, 105);
        btn2.Name = "btn2";
        btn2.Size = new Size(115, 62);
        btn2.TabIndex = 4;
        btn2.Text = "2";
        btn2.UseVisualStyleBackColor = true;
        // 
        // btn9
        // 
        btn9.Location = new Point(314, 241);
        btn9.Name = "btn9";
        btn9.Size = new Size(115, 62);
        btn9.TabIndex = 11;
        btn9.Text = "9";
        btn9.UseVisualStyleBackColor = true;
        // 
        // btnAnswer
        // 
        btnAnswer.Location = new Point(314, 309);
        btnAnswer.Name = "btnAnswer";
        btnAnswer.Size = new Size(115, 62);
        btnAnswer.TabIndex = 10;
        btnAnswer.Text = "=";
        btnAnswer.UseVisualStyleBackColor = true;
        // 
        // btn6
        // 
        btn6.Location = new Point(314, 173);
        btn6.Name = "btn6";
        btn6.Size = new Size(115, 62);
        btn6.TabIndex = 9;
        btn6.Text = "6";
        btn6.UseVisualStyleBackColor = true;
        // 
        // btn3
        // 
        btn3.Location = new Point(314, 105);
        btn3.Name = "btn3";
        btn3.Size = new Size(115, 62);
        btn3.TabIndex = 8;
        btn3.Text = "3";
        btn3.UseVisualStyleBackColor = true;
        // 
        // btnClear
        // 
        btnClear.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnClear.Location = new Point(435, 105);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(91, 48);
        btnClear.TabIndex = 12;
        btnClear.Text = "CLEAR";
        btnClear.UseVisualStyleBackColor = true;
        // 
        // btnAdd
        // 
        btnAdd.Font = new Font("Segoe UI", 18F);
        btnAdd.Location = new Point(435, 159);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(91, 48);
        btnAdd.TabIndex = 13;
        btnAdd.Text = "+";
        btnAdd.UseVisualStyleBackColor = true;
        // 
        // btnSub
        // 
        btnSub.Font = new Font("Segoe UI", 18F);
        btnSub.Location = new Point(435, 213);
        btnSub.Name = "btnSub";
        btnSub.Size = new Size(91, 48);
        btnSub.TabIndex = 14;
        btnSub.Text = "-";
        btnSub.UseVisualStyleBackColor = true;
        // 
        // btnMultiply
        // 
        btnMultiply.Font = new Font("Segoe UI", 18F);
        btnMultiply.Location = new Point(435, 267);
        btnMultiply.Name = "btnMultiply";
        btnMultiply.Size = new Size(91, 48);
        btnMultiply.TabIndex = 15;
        btnMultiply.Text = "×";
        btnMultiply.UseVisualStyleBackColor = true;
        // 
        // btnDivide
        // 
        btnDivide.Font = new Font("Segoe UI", 18F);
        btnDivide.Location = new Point(435, 323);
        btnDivide.Name = "btnDivide";
        btnDivide.Size = new Size(91, 48);
        btnDivide.TabIndex = 16;
        btnDivide.Text = "÷";
        btnDivide.UseVisualStyleBackColor = true;
        btnDivide.Click += button17_Click;
        // 
        // txtDisplay
        // 
        txtDisplay.BackColor = SystemColors.InactiveCaption;
        txtDisplay.Font = new Font("Segoe UI", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtDisplay.Location = new Point(63, 21);
        txtDisplay.Name = "txtDisplay";
        txtDisplay.Size = new Size(463, 78);
        txtDisplay.TabIndex = 17;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(546, 382);
        Controls.Add(txtDisplay);
        Controls.Add(btnDivide);
        Controls.Add(btnMultiply);
        Controls.Add(btnSub);
        Controls.Add(btnAdd);
        Controls.Add(btnClear);
        Controls.Add(btn9);
        Controls.Add(btnAnswer);
        Controls.Add(btn6);
        Controls.Add(btn3);
        Controls.Add(btn8);
        Controls.Add(btn0);
        Controls.Add(btn5);
        Controls.Add(btn2);
        Controls.Add(btn7);
        Controls.Add(btnDecimal);
        Controls.Add(btn4);
        Controls.Add(btn1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btn1;
    private Button btn4;
    private Button btnDecimal;
    private Button btn7;
    private Button btn8;
    private Button btn0;
    private Button btn5;
    private Button btn2;
    private Button btn9;
    private Button btnAnswer;
    private Button btn6;
    private Button btn3;
    private Button btnClear;
    private Button btnAdd;
    private Button btnSub;
    private Button btnMultiply;
    private Button btnDivide;
    private TextBox txtDisplay;
}
