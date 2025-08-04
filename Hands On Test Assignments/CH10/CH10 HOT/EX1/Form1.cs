using System.Diagnostics;

namespace EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Occasion> occasionList;
        private void Form1_Load(object sender, EventArgs e)
        {
            occasionList = new List<Occasion>()
            {
                new Occasion ("Thank You")
                {
                    Styles =
                    {
                        new Style("Tree", 1.25, Properties.Resources.Tree),
                        new Style("Blurry Lights", 1.5, Properties.Resources.BlurryLights)
                    }
                },
                new Occasion ("Happy Wedding")
                {
                    Styles =
                    {
                        new Style("Gold", 1, Properties.Resources.Gold),
                        new Style("Flower", 2, Properties.Resources.Flower)
                    }
                },
                new Occasion ("Happy Birthday")
                {
                    Styles =
                    {
                        new Style("Red Square", 1.25, Properties.Resources.RedSquare),
                        new Style("SidewaysPyramid", 1.75, Properties.Resources.SidewaysPyramid)
                    }
                }
            };
            cboOccasion.DataSource = occasionList;
            cboOccasion.DisplayMember = "Name";
        }

        private void cboStyle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboOccasion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentIndex = (Occasion)cboOccasion.SelectedItem;
            cboStyle.DataSource = currentIndex.Styles;
        }

        private void chkCustomMessage_CheckedChanged(object sender, EventArgs e)
        {
            rtbMessage.Enabled = chkCustomMessage.Checked;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order()
            {
                Occasion = (Occasion)cboOccasion.SelectedItem,
                Style = (Style)cboStyle.SelectedItem,
                Envelope = chkEnvelope.Checked,
                Stamp = chkStamp.Checked,
                AddMessage = chkCustomMessage.Checked,
                Message = rtbMessage.Text,
            };
            lblCost.Text = $"Cost: {order.CalculateTotal():C}";
            lblMessage.Text = order.Message;
            pbCard.Image = order.Style.Image;
            lblOccasion.Text = $"{cboOccasion.SelectedItem}";
        }
    }
}
