using Engine;



namespace RPG
{
    public partial class Game : Form
    {
        private Player P1;

        public Game()
        {
            InitializeComponent();
            DescBox.Text = "Welcome Adventurer!\n" +
                "Ready to go explore the mystery world and kill horde of monsters and save the village.";
            btn2.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Location l = new Location(0, "Home", "Home sweet Home nothing beat going back to your bed");
            P1 = new Player(100, 100, 1000, 0, 1);
            lblHit.Text = P1.CurrentHitPoints.ToString();
            lblGold.Text = P1.Gold.ToString();
            lblLevel.Text = P1.Level.ToString();
            lblExp.Text = P1.ExperiencePoints.ToString();
            DescBox.Text = l.Description;
            btn1.Visible = false;
            btn2.Visible = true;
        }
    }
}
