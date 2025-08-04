using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public class Job
    {
        public Job(string jobTitle, LinkLabel.Link link)
        {
            JobTitle = jobTitle;
            Link = link;
        } 
        public string JobTitle { get; set; }
        public LinkLabel.Link Link { get; set; }
        public override string ToString()
        {
            return JobTitle;
        }
    }
}
