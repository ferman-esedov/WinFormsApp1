namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            int lblWidth = 87*2;
            int lblHeight = 43*2;

            int x = Random.Shared.Next(0, Width - lblWidth);
            int y = Random.Shared.Next(0, Height - lblHeight);
            label1.Location = new Point(x, y);
        }
    }
}