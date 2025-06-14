namespace EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] firstName = new string[5]
            {
                "Markel",
                "Luiza",
                "Bryony",
                "Giraldo",
                "Lowri",
            };
            string[] lastName = new string[5]
            {
                "Diggory",
                "Gunnar",
                "Hester",
                "Addy",
                "Hari",
            };
            string[] phoneNumber = new string[5]
            {
                "555-8390",
                "555-4618",
                "555-4440",
                "555-1687",
                "555-7763"
            };

            string userSearch = txtName.Text.ToLower();
            bool found = false;

            for (int i = 0; i < firstName.Length; i++)
            {
                if (firstName[i].ToLower().Contains(userSearch) || lastName[i].ToLower().Contains(userSearch))
                {
                    lblFirstName.Text = $"First Name: {firstName[i]}";
                    lblLastName.Text = $"Last Name: {lastName[i]}";
                    lblPhone.Text = $"Phone Number: {phoneNumber[i]}";
                    lblError.Text = "";
                    found = true ;
                }
                if (!found)
                {
                    lblFirstName.Text = "Error";
                    lblLastName.Text = "Error" ;
                    lblPhone.Text = "Error" ;
                    lblError.Text = "User Not Found";
                }
            }
        }
    }
}
