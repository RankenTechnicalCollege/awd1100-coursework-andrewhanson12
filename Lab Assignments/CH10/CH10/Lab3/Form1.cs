namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AnyTextBox_Click(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.Yellow;
        }

        private void AnyTextBox_Focus(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.LightBlue;
        }

        private void AnyTextBox_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.LightGray;
        }

        private void AnyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Up:
                    txtOne.Focus();
                    break;
                case Keys.Right:
                    txtThree.Focus();
                    break;
                case Keys.Down:
                    txtFive.Focus();
                    break;
                case Keys.Left:
                    txtSeven.Focus();
                    break;
            }
        }
    }
}
