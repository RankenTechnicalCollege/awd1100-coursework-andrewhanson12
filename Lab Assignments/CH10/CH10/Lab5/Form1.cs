namespace Lab5
{
    public partial class Form1 : Form
    {
        List<Student> currentStudents = new List<Student>();
        Course awd1100 = new Course();
        public Form1()
        {
            InitializeComponent();
            currentStudents.Add(new Student(12343, "Andrew", "Hanson", "andrew_hanson@insideranken.org"));
            currentStudents.Add(new Student(12433, "Jack", "Johnson", "Jack_Johnson@insideranken.org"));
            currentStudents.Add(new Student(43323, "Jimmy", "Jones", "Jim_Jones@insideranken.org"));
            currentStudents.Add(new Student(34352, "Todd", "Jenkins", "todd_jenkins@insideranken.org"));
            awd1100.CourseName = "Programming Fundamentals with C#";
            awd1100.Students = currentStudents;

            foreach (Student s in awd1100.Students)
            {
                rtbOutput.Text += s.ToString();
                cboRemove.Items.Add(s.StudentId);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentStudents.Add(new Student(int.Parse(txtId.Text), txtFirstName.Text, txtLastName.Text, txtEmail.Text));
            awd1100.Students = currentStudents;
            rtbOutput.Text = "";
            cboRemove.Items.Add(int.Parse(txtId.Text));
            foreach (Student s in awd1100.Students)
            {
                rtbOutput.Text += s.ToString();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int searchId = int.Parse(cboRemove.Text);
            //Student searchStudent = null;
            //foreach (Student student in awd1100.Students)
            //{
            //    if (searchId == student.StudentId)
            //    {
            //        searchStudent = student;
            //        awd1100.Students.Remove(student);
            //    }
            //}
            for (int i = 0; i < awd1100.Students.Count; i++)
            {
                if (searchId == awd1100.Students[i].StudentId)
                {
                    awd1100.Students.Remove(awd1100.Students[i]);
                }
            }
            rtbOutput.Text = "";
            cboRemove.Items.Clear();
            foreach (Student student1 in awd1100.Students)
            {
                rtbOutput.Text += student1.ToString();
                cboRemove.Items.Add(student1.StudentId);
            }
        }
    }
}
