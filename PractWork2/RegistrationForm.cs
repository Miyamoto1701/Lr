namespace PractWork2
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string fileName = "logins.csv";

            foreach (var line in File.ReadLines(fileName))
            {
                var parts = line.Split(';');
                if (parts.Length > 0)
                {
                    if (parts[0] == LoginTextBox.Text)
                        MessageBox.Show("¬ведите другой логин");
                    else
                    {

                    }
                }
                MessageBox.Show("¬ведите другой логин");
            }
        }
    }
}
