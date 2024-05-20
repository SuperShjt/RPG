using Engine;



namespace RPG
{
    public partial class Game : Form
    {
        private Player P1;

        public Game()
        {
            InitializeComponent();
            /*  DescBox.Text = "Welcome Adventurer!\n" +
                  "Ready to go explore the mystery world and kill horde of monsters and save the village.";*/
            P1=new Player(100,100,1000,0,1);
            P1.InvItems.Add(new Inventory(World.ItemByID(World.ITEM_ID_RUSTY_SWORD), 1));
            lblHit.Text=P1.CurrentHitPoints.ToString();
            lblExp.Text=P1.ExperiencePoints.ToString();
            lblGold.Text=P1.Gold.ToString();
            lblLevel.Text=P1.Level.ToString();
            MoveTo(World.LocationByID(World.LOCATION_ID_HOME));


        }

        private void btnNorth_Click(object sender, EventArgs e)
        {

        }

        private void btnWest_Click(object sender, EventArgs e)
        {

        }

        private void btnSouth_Click(object sender, EventArgs e)
        {

        }

        private void btnEast_Click(object sender, EventArgs e)
        {

        }
        private void MoveTo(Location newlocation)
        {

            if (newlocation.ItemRequiredToEnter != null)
            {
                bool RequiredItem = false;
                foreach (Inventory i in P1.InvItems) { 
                    
                
                }

            }
                



































        }
    }
}
