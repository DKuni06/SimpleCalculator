namespace SimpleCalculator
{
    public partial class frmSimpleCalc : Form
    {
        public frmSimpleCalc()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // get input operands and operator from user
            // also validate that each input is valid, display error message if not
            double operand1;
            double operand2;

            if (!double.TryParse(txtOpnd1.Text, out operand1))
            {
                MessageBox.Show("Please enter a valid number for Operand 1");
                return;
            }
            else if (!double.TryParse(txtOpnd2.Text, out operand2))
            {
                MessageBox.Show("Please enter a valid number for Operand 2");
                return;
            }

            string operatorText = txtOprtr.Text.Trim();
            if (operatorText != "+" && operatorText != "-" && operatorText != "*" && operatorText != "/")
            {
                MessageBox.Show("Please enter a valid operator (+, -, *, /)");
                return;
            }

            // do the calculations!

            if (operatorText == "/" && operand2 == 0)
            {
                MessageBox.Show("Cannot divide by zero");
                return;
            }

            double Result = 0;
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
            txtRslt.Text = Result.ToString();
        }
    }
}
