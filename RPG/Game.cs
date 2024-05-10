using Engine;



namespace RPG
{
    public partial class Game : Form
    {
        private Player P1;

        public Game()
        {
            InitializeComponent();
            P1 = new Player();

            P1.MaximumHitPoints = 100;
            P1.CurrentHitPoints = 100;
            P1.Gold = 1000;
            P1.ExperiencePoints = 0;
            P1.Level = 1;
            lblHit.Text= P1.CurrentHitPoints.ToString();
            lblGold.Text= P1.Gold.ToString();
            lblLevel.Text= P1.Level.ToString();
            lblExp.Text= P1.ExperiencePoints.ToString();
        }

        
    }
}
