namespace SimpleCalculator
{
    public partial class frmSimpleCalc : Form
    {
        public frmSimpleCalc()
        {
            InitializeComponent();

            txtOpnd1.TextChanged += InputTextChanged;
            txtOpnd2.TextChanged += InputTextChanged;
            txtOprtr.TextChanged += InputTextChanged;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        { 
            // get input operands and operator from user
            // also validate that each input is valid, display error message if not
            decimal operand1;
            decimal operand2;

            isPresent(txtOpnd1.Text, "Operand 1");
            isPresent(txtOpnd2.Text, "Operand 2");
            isPresent(txtOprtr.Text, "Operator");
            


            isDecimal(txtOpnd1.Text, fieldName: "Operand 1", out operand1);
            isDecimal(txtOpnd2.Text, fieldName: "Operand 2", out operand2);
            isValidData(operand1);
            isValidData(operand2);
            string operatorText = txtOprtr.Text.Trim();
            isOperatorValid(operatorText);
            if (operatorText == "/" && operand2 == 0)
            {
                MessageBox.Show("Cannot divide by zero");
                return;
            }

            // do the calculations
            decimal Result = Calculate(operand1, operand2, operatorText);
            txtRslt.Text = Math.Round(Result, 4).ToString();
        }
        // if user presses enter key, use the same logic as clicking the calculate button
        private void frmSimpleCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCalc_Click(sender, e);
            }
        }

        private void isDecimal(string input, string fieldName, out decimal value)
        {
            if (!decimal.TryParse(input, out value))
            {
                MessageBox.Show($"Please enter a valid number for {fieldName}");
                return;
            }
        }
        private void isPresent(string input, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show($"Please enter a value for {fieldName}");
                return;
            }
        }

        private void isValidData(decimal input)
        {
            if (input == 0 || input >= 1000000)
            {
                MessageBox.Show("Please enter a number between 0 and 1000000");
                return;
            }
        }
        private void isOperatorValid(string operatorText)
        {
            if (operatorText != "+" && operatorText != "-" && operatorText != "*" && operatorText != "/")
            {
                MessageBox.Show("Please enter a valid operator (+, -, *, /)");
                return;
            }
        }

        private decimal Calculate(decimal operand1, decimal operand2, string operatorText)
        {
            decimal Result = 0;
            switch (operatorText)
            {
                case "+":
                    Result = operand1 + operand2;
                    break;
                case "-":
                    Result = operand1 - operand2;
                    break;
                case "*":
                    Result = operand1 * operand2;
                    break;
                case "/":
                    Result = operand1 / operand2;
                    break;
            }
            return Result;
        }
        private void InputTextChanged(object sender, EventArgs e)
        {
            txtRslt.Clear();
        }
        private void frmSimpleCalc_Load(object sender, EventArgs e)
        {
            
        }
    }
}
