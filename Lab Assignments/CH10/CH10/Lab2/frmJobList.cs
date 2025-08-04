using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class frmJobList : Form
    {
        Industry[] _industries;
        public frmJobList(Industry[] industries)
        {
            InitializeComponent();
            _industries = industries;
        }

        private void frmJobList_Load(object sender, EventArgs e)
        {
            int yLocation = 10;
            foreach (Industry industryItem in _industries)
            {
                foreach (Job jobItem in industryItem.Jobs)
                {
                    LinkLabel label = new LinkLabel()
                    {
                        Text = jobItem.JobTitle,
                        Location = new Point(10, yLocation),
                        AutoSize = true
                    };
                    label.Links.Add(jobItem.Link);
                    label.LinkClicked += Label_LinkClicked;
                    yLocation += 20;
                    this.Controls.Add(label);
                }
            }
        }

        private void Label_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
