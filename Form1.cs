namespace Project_Calculator
{
    public partial class CalculatorView : Form
    {
        private Calculator calculator;
        bool isNewNum = true;
        string lastOperator;
        bool isFirstNum = true;

        public CalculatorView()
        {
            calculator = new Calculator(0);
            InitializeComponent();
        }

        private void numberClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (isNewNum)
            {
                inputTextBox.Text = string.Empty;
                isNewNum = false;
            }
            inputTextBox.Text += button.Text;
        }

        private void operandClick(object sender, EventArgs e)
        {
            isNewNum = true;
            Button buttonOperator = (Button)sender;
            lastOperator = buttonOperator.Text;
            double number = double.Parse(inputTextBox.Text);

            if (isFirstNum)
            {
                calculator.SetCurrentResult(number);
                isFirstNum = false;
            }
        }

        private void equalClick(object sender, EventArgs e)
        {
            
            double number = double.Parse(inputTextBox.Text);
            PerformOperation(number);
           
            double result = calculator.GetCurrentResult();
            string[] split;
            if (result < 0)
            {
               split = result.ToString().Split("-");
                inputTextBox.Text = split[1] + "-";
            }
            else
            {
                inputTextBox.Text = result.ToString();

            }
        }

        private void PerformOperation(double number)
        {
            switch (lastOperator)
            {
                case "+":
                    calculator.SumUp(number);
                    break;
                case "-":
                    calculator.Subtract(number);
                    break;
                case "*":
                    calculator.Multiply(number);
                    break;
                case "/":
                    calculator.Divide(number);
                    break;
                case "^":
                    calculator.Power((int)number);
                    break;
                default: break;
            }
        }
    }
}
