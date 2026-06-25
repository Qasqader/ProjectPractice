
namespace ProjectPractice
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string expression = textBoxInfix.Text;
            bool isValid = DataService.DataService.ExpressionConverter.CheckBrackets(expression);

            if (isValid)
            {
                buttonRun.Enabled = true;
                textBoxPostfix.Text = string.Empty;
                textBoxPrefix.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Введено математическое выражение с некорректной скобочной последовательностью","Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            string expression = textBoxInfix.Text;
            string postfix = DataService.DataService.ExpressionConverter.InfixToPostfix(expression);
            string prefix = DataService.DataService.ExpressionConverter.InfixToPrefix(expression);
            textBoxPostfix.Text = postfix;
            textBoxPrefix.Text = prefix;
        }
    }
}
