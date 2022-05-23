using WinFormsApp1.Properties;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Timer();
        image_change(CountryUTC.Baku);

    }
    enum CountryUTC { Baku = 4, London = 1 }
    private void button1_Click(object sender, EventArgs e)
    {
        image_change(CountryUTC.Baku);
    }


    private void Timer()
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        timer.Interval = 1000;
        timer.Tick += Timer_Tick;
        timer.Start();
    }
    private void Timer_Tick(object? sender, EventArgs e)
    {
        lbl_clock.Text = CurrentTime.AddSeconds(1).ToLongTimeString();
    }

    private void btn_london_Click(object sender, EventArgs e)
    {
        image_change(CountryUTC.London);
    }
    public DateTime CurrentTime;
    private void image_change(CountryUTC c)
    {
        CurrentTime = DateTime.UtcNow.AddHours((int)c);
        switch (c)
        {
            case CountryUTC.Baku:
                BackgroundImage = Resource1.Baku_Image;
                break;
            case CountryUTC.London:
                BackgroundImage = Resource1.london_image;
                break;
        }
    }
}
