namespace StudentProfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Student Profile", "GitHub Beginner Lab", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Git-Hub Beginner Lab", "Student Profile");

            lbl1.Text = "Contact Number: 09171234567";

        }
    }
}
