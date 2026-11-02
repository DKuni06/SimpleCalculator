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
            double Operand1 = Convert.ToDouble(txtOpnd1.Text);
            double Operand2 = Convert.ToDouble(txtOpnd2.Text);
            string Operator = txtOprtr.Text;

            // do the calculations!

            double Result = 0;
            switch(Operator)
            {
                case "+":
                    Result = Operand1 + Operand2;
                    break;
                case "-":
                    Result = Operand1 - Operand2;
                    break;
                case "*":
                    Result = Operand1 * Operand2;
                    break;
                case "/":
                    Result = Operand1 / Operand2;
                    break;
                default:
                    txtRslt.Text = "Invalid operator!";
                    break;
            }
            txtRslt.Text = Result.ToString();
        }
    }
}
