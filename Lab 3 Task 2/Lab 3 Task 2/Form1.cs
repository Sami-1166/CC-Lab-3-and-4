using System.Text.RegularExpressions;

namespace Lab_3_Task_2
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

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string pattern = @"^-?\d+(\.\d+)?[eE][-+]?\d+$";

            if (Regex.IsMatch(input, pattern))
            {
                MessageBox.Show("Success! The input is in correct scientific notation format.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a number in scientific notation format like 8e4 or 5e-2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
