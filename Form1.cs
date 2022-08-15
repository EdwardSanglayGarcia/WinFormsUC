namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 userControl1 = new UserControl1();
            AddUserControl(userControl1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl2 userControl2 = new UserControl2(); 
            AddUserControl(userControl2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserControl3 userControl3 = new UserControl3();
            AddUserControl(userControl3);
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

    }
}