namespace Calculator;

public partial class Form1 : Form
{
    private decimal firstNumber = 0;
    private string operation = "";
    private bool startNewNumber = true;

    public Form1()
    {
        InitializeComponent();
        foreach (Button b in new[] { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 })
        {
            b.Click += Digit_Click;
        }
        btnDecimal.Click += btnDecimal_Click;
        btnAdd.Click += (s, e) => SetOperation("+");
        btnSub.Click += (s, e) => SetOperation("-");
        btnMultiply.Click += (s, e) => SetOperation("*");
        btnDivide.Click += (s, e) => SetOperation("/");
        btnAnswer.Click += btnAnswer_Click;
        btnClear.Click += btnClear_Click;
        txtDisplay.ReadOnly = true;
        txtDisplay.Text = "0";
    }
    private void Digit_Click(object? sender, EventArgs e)
    {
        if (sender is not Button btn) return;

        if (startNewNumber || txtDisplay.Text == "0")
        {
            txtDisplay.Text = btn.Text;
            startNewNumber = false;
        }
        else
        {
            txtDisplay.Text += btn.Text;
        }
    }

    private void btnDecimal_Click(object? sender, EventArgs e)
    {
        if (startNewNumber)
        {
            txtDisplay.Text = "0.";
            startNewNumber = false;
        }
        else if (!txtDisplay.Text.Contains('.'))
        {
            txtDisplay.Text += ".";
        }
    }

    private void SetOperation(string op)
    {
        if (!decimal.TryParse(txtDisplay.Text, out decimal current)) return;

        if (operation != "" && !startNewNumber)
        {
            decimal? result = Calculate(firstNumber, current, operation);
            if (result == null)
            {
                ShowDivideByZero();
                return;
            }
            current = result.Value;
            txtDisplay.Text = current.ToString();
        }
        firstNumber = current;
        operation = op;
        startNewNumber = true;
    }
     private void btnAnswer_Click(object? sender, EventArgs e)
    {
        if (operation == "") return;
        if (!decimal.TryParse(txtDisplay.Text, out decimal secondNumber)) return;

        decimal? result = Calculate(firstNumber, secondNumber, operation);
        if (result == null)
        {
            ShowDivideByZero();
            return;
        }

        txtDisplay.Text = result.Value.ToString();
        operation = "";
        startNewNumber = true;
    }
    private void btnClear_Click(object? sender, EventArgs e)
    {
        txtDisplay.Text = "0";
        firstNumber = 0;
        operation = "";
        startNewNumber = true;
    }
    private decimal? Calculate(decimal a, decimal b, string op)
    {
        switch (op)
        {
            case "+": return a + b;
            case "-": return a - b;
            case "*": return a * b;
            case "/": return b == 0 ? null : a / b;
            default: return b;
        }
    }
    private void ShowDivideByZero()
    {
        txtDisplay.Text = "Cannot divide by zero";
        firstNumber = 0;
        operation = "";
        startNewNumber = true;
    }
}