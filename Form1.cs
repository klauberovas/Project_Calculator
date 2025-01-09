namespace Project_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool zadavamNoveCislo = true;
        private void numberClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (zadavamNoveCislo)
            {
                inputTextBox.Text = string.Empty;
                zadavamNoveCislo = false;
            }
            inputTextBox.Text += button.Text;
        }
    }
}
