namespace Lab2
{
    public partial class Form1 : Form
    {
        Industry[] selectedIndustries;

        Job[] itJobs =
        {
            new Job("Junior Software Engineer", new LinkLabel.Link(){LinkData="https://careers.eyecare-partners.com/job/EyeCarePartners/Junior-Developer-18658"}),
            new Job("Junior Web Developer", new LinkLabel.Link(){LinkData="https://www.ziprecruiter.com/c/Genoa-Employment-Solutions,-Inc./Job/Web-Application-Developer/-in-O%27fallon,MO?jid=ee3bebc024f0ad08"}),
            new Job ("Quality Assurance Specialist", new LinkLabel.Link(){LinkData="https://www.jobserve.com/us/en/extjob/QUALITY-ASSURANCE-SPECIALIST-503B-in-Chesterfield-Missouri-USA-9C2052CF262BD37A14/"})
        };
        Job[] autoJobs =
        {
            new Job("Automotive Mechanic", new LinkLabel.Link(){LinkData="https://www.ziprecruiter.com/Jobs/Automobile-Mechanic/--in-Missouri"}),
            new Job("Automotive Technician", new LinkLabel.Link(){LinkData="https://www.linkedin.com/jobs/entry-level-auto-technician-jobs-greater-st.-louis/?currentJobId=4249955956"})
        };
        Job[] hvacJobs =
        {
            new Job("HVAC Installer", new LinkLabel.Link(){LinkData="https://www.ziprecruiter.com/Jobs/Hvac/-in-O-Fallon,MO"})
        };
        public Form1()
        {
            InitializeComponent();
            lstIndustries.Items.AddRange(new Industry[]
            {
                new Industry ("Information Technology", itJobs),
                new Industry ("Automotive", autoJobs),
                new Industry ("HVAC", hvacJobs)
            }
            );
        }

        private void lstIndustries_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndustries = new Industry[lstIndustries.SelectedItems.Count];

            for (int i = 0; i < lstIndustries.SelectedItems.Count; i++)
            {
                selectedIndustries[i] = (Industry)lstIndustries.SelectedItems[i];
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmJobList jobList = new frmJobList(selectedIndustries);
            jobList.ShowDialog();
        }
    }
}
