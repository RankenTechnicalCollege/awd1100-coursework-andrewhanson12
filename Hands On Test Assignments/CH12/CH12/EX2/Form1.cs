namespace EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Computer> computersList = new List<Computer>()
        {
            new Computer("My-Desktop", "127.0.0.1", "20, 21, 23, 25, 53, 80, 123, 389, 443"),
            new Computer("google-public-dns-a", "8.8.8.8", "53"),
            new Computer("ranken.edu", "47.44.246.80", "25, 80, 443")
        };
        public string ScanIpAddress(string ipAddress)
        {
            for (int i = 0; i < computersList.Count; i++)
            {
                if (computersList[i].getIpAddress() == ipAddress)
                {
                    return $"{computersList[i].getName()}\n" + $"{computersList[i].getIpAddress()}\n"
                        + $"Services\n {computersList[i].getService()}";
                }
            }
            return "Request Timed Out";
        }
        public void ShowComputer(string computer)
        {
            lblResult.Text = computer;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            ShowComputer(ScanIpAddress(txtIpAddress.Text));
        }
    }
}
