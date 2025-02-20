namespace BirthDateStringMK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowDateButton_Click(object sender, EventArgs e)
        {
            //Declare string variable
            string output;

            //Concatenate input and built output string
            output = dayOfWeekTextBox.Text + ", " +
                monthTextBox.Text + " " +
                dayOfMonthTextBox.Text + ", " +
                yearTextBox.Text;

            //display output string in the dateOutputLabel
            dateOutputLabel.Text = output;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clear out strings
            dayOfWeekTextBox.Text = "";
            monthTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            yearTextBox.Text = "";
            dateOutputLabel.Text = "";

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //exit program
            this.Close();
        }

        private void dateOutputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
