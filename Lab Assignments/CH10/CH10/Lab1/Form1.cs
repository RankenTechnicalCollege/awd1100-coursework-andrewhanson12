using System.Security.Policy;

namespace Lab1
{
    public partial class Form1 : Form
    {
        Superhero[] heros =
        {
            new Superhero(){Name="None",Likes="",Dislikes="",Biography="",Image=null,Superpower="",Url="" },
            new Superhero(){Name="Iron Man",
                Likes="Flying",
                Dislikes="To die",
                Biography="Iron Man is the superhero persona of Anthony Edward \"Tony\" Stark,\n a businessman and engineer who runs the weapons manufacturing company Stark Industries.",
                Image=Properties.Resources.IronMan,
                Superpower="Genius",
                Url="https://en.wikipedia.org/wiki/Iron_Man" },
            new Superhero(){Name="Captain America",
                Likes="Freedom",
                Dislikes="Hydra",
                Biography=" Captain America's civilian identity is Steven \"Steve\" Rogers,\n a frail man enhanced to the peak of human physical perfection by an experimental \"super-soldier serum\"\n after joining the United States Army to aid the country's efforts in World War II. ",
                Image=Properties.Resources.CaptainAmerica,
                Superpower="Super Strength, Speed, Willpower",
                Url="https://en.wikipedia.org/wiki/Captain_America" },
            new Superhero(){Name="Hulk",
                Likes="Smash",
                Dislikes="Banner",
                Biography="In his comic book appearances, the character, who has dissociative identity disorder (DID),\n is primarily represented by the alter ego Hulk, an immense, green-skinned, hulking brute,\n possessing a limitless degree of physical strength, and the alter ego Dr. Robert Bruce Banner.",
                Image=Properties.Resources.Hulk,
                Superpower="Big Green Smashing Machine",
                Url="https://en.wikipedia.org/wiki/Hulk" },
            new Superhero(){Name="Thor",
                Likes="Coffee",
                Dislikes="Thanos",
                Biography="Thor is one of the gods of Asgard and the son of the Asgardian king Odin.",
                Image=Properties.Resources.Thor,
                Superpower="God of Thunder",
                Url="https://en.wikipedia.org/wiki/Thor_(Marvel_Comics)" },
            new Superhero(){Name="Black Panther",
                Likes="Wakanda",
                Dislikes="Bucky Barnes",
                Biography="Black Panther's birth name is T'Challa, and he is the son of the previous Black Panther, T'Chaka.\n He is the king and protector of the fictional African nation of Wakanda, a technologically advanced society drawing from a supply of vibranium",
                Image=Properties.Resources.BlackPanther,
                Superpower="Black Panther Suit",
                Url="https://en.wikipedia.org/wiki/Black_Panther_(character)" },
        };
        public Form1()
        {
            InitializeComponent();
            cboHeros.Items.AddRange(heros);
            cboHeros.SelectedIndex = 0;
        }

        private void cboHeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentIndex = cboHeros.SelectedIndex;
            if (cboHeros.SelectedIndex == 0)
            {
                //Please Select a hero
                lblName.Text = "Please select a hero";
            }
            else
            {
                lblName.Text = heros[currentIndex].Name;
                lblLikes.Text = heros[currentIndex].Likes;
                lblDislikes.Text = heros[currentIndex].Dislikes;
                lblSuperpower.Text = heros[currentIndex].Superpower;
                lblBiography.Text = heros[currentIndex].Biography;
                lblLink.Text = heros[currentIndex].Url;
                pbHero.Image = heros[currentIndex].Image;
            }
        }
    }
}
