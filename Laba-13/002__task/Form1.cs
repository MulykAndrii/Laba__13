using System.Text.RegularExpressions;

namespace _002__task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            var pattern = @"^[A-Z][a-zA-Z]{1,}(?: [A-Z][a-zA-Z]*){0,2}$";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            if (match.Success)
            {
                Result.Text = "Result of validation: Sucessfull!";
                Result.ForeColor = Color.Green;
            }
            else
            {
                Result.Text = "Result of validation: Unsucessfull!";
                Result.ForeColor = Color.Red;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string input = textBox2.Text;
            var pattern = @"^(?:\+38)?[ .-]?[0-9]{3}[ .-]?[0-9]{3}[ .-]?[0-9]{4}$";

            var regex = new Regex(pattern);
            var match = regex.Match(input);

            if (match.Success)
            {
                ResultPhone.Text = "Result of validation: Sucessfull!";
                ResultPhone.ForeColor = Color.Green;
            }
            else
            {
                ResultPhone.Text = "Result of validation: Unsucessfull!";
                ResultPhone.ForeColor = Color.Red;
            }
        }
    }
}