using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "123" && txtPassword.Text == "123")
            {
                MessageBox.Show("Hello, " + txtUsername + "!");
                new Form2().Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Incorrect License Key");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int mouseX = 400;
            int mouseY = 20;
            Point newLocation = PointToScreen(new Point(mouseX, mouseY));
            this.Location = newLocation;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}