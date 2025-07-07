namespace Lab1
{
    public partial class Form1 : Form
    {
        List<FlashCard> flashCards = new List<FlashCard>()
        {
            new FlashCard("class", "A blueprint for creating objects, defining data (fields) and methods (functions)\n that objects of that class will possess."),
            new FlashCard("struct", "A value type that can hold data members and function members, similar to a class but with\n different memory allocation and behavior."),
            new FlashCard("interface", "A contract that defines a set of members (methods, properties, etc.) that a class or struct must implement,\n promoting polymorphism and loose coupling."),
            new FlashCard("namespace", "A container for classes, interfaces, and other namespaces, used to organize and structure code,\n preventing naming conflicts."),
            new FlashCard("delegate", "A type that represents a reference to a method, enabling event handling and callback mechanisms."),
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDefine_Click(object sender, EventArgs e)
        {
            string term = txtTerm.Text;
            bool found = false;
            for (int i = 0; i < flashCards.Count; i++)
            {
                if (term.ToLower() == flashCards[i].GetTerm())
                {
                    found = true;
                    lblResult.Text = flashCards[i].GetDefinition();
                    grpAdd.Visible = false;
                }
                if (!found)
                {
                    lblResult.Text = "";
                    grpAdd.Visible = true;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string term = txtTerm.Text;
            string definition = txtNewDefinition.Text;
            int totalCards = flashCards.Count;

            if (totalCards < 20)
            {
                FlashCard newCard = new FlashCard(term, definition);
                flashCards.Add(newCard);
                txtNewDefinition.Text = "";
                grpAdd.Visible = false;
            }
            else
            {
                lblCardAdded.Text = "You have reached the maximum number of cards";
            }
        }
    }
}
