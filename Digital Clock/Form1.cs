namespace Digital_Clock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSeconds.Text = DateTime.Now.ToString("ss");
            lblMonth.Text = DateTime.Now.ToString("dd MMM yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
        }
    }
}