namespace RPG
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            lblGold.Text = "1000 Gold";
            lblLevel.Text = "1";
            
        }
    }
}
