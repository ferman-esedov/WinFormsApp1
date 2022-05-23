namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(Width, Height);
            graphics = Graphics.FromImage(bitmap);
            BackgroundImage = bitmap;
            Text = "Rectangle";
        }
        Bitmap bitmap;
        Graphics graphics;
        int index;
        int width;
        int height;
        bool paint = false;
        Point point;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            point = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (width < 10 || height < 10)
            {
                MessageBox.Show("Minimal size: 10x10");
            }
            else
            {
                Label label = new Label()
                {
                    Text = index++.ToString(),
                    Width = width,
                    Height = height,
                    AutoSize = false,
                    Location = new Point(point.X, point.Y),
                    BackColor = Color.FromArgb(Random.Shared.Next(255), Random.Shared.Next(255), Random.Shared.Next(255)),
                    ForeColor = Color.FromArgb(Random.Shared.Next(255), Random.Shared.Next(255), Random.Shared.Next(255)),
                };

                label.MouseClick += Label_MouseClick;
                label.MouseDoubleClick += Label_MouseDoubleClick;
                Controls.Add(label);
            }
            paint = false;
        }
        Pen pen = new Pen(Color.Red, 3);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            if (paint)
            {
                graphics.DrawRectangle(pen, point.X, point.Y, width, height);
            }
            else
            {
                graphics.Clear(Color.White);
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                width = e.X - point.X;
                height = e.Y - point.Y;
                this.Refresh();
            }
        }
        private void Label_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label label = sender as Label;
                this.Text = $"Label{label.Text} W:{label.Width.ToString()} H:{label.Height.ToString()}";
            }
        }
        private void Label_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Controls.Remove(sender as Label);
            }
        }
    }
}