namespace HorseRacingGame
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            InitializeRace();
            timer1.Tick += new EventHandler(timer1_Tick);
        }
        private void InitializeRace()
        {
            // this sets the initial positions of the horse 
            pictureBoxHorse1.Left = 0;
            pictureBoxHorse2.Left = 0;
            pictureBoxHorse3.Left = 0;

            // this is the set labels to set the different labels for it 
            labelLeader.Text = "Press Start to begin!";
            labelFinishLine.Text = "Finish Line";
            labelFinishLine.Left = panel1.Width - labelFinishLine.Width - 10; 
            // it positions the finish line at the end of the track 

            // this timer sets the timer interval to 100ms
            timer1.Interval = 100;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            pictureBoxHorse1.Left = 0;
            pictureBoxHorse2.Left = 0;
            pictureBoxHorse3.Left = 0;

            // this label shows the Race Started when the start button is pressed and the timer starts at that moment
            labelLeader.Text = "Race started";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // when timer starts, the horses start to move
            MoveHorse(pictureBoxHorse1);
            MoveHorse(pictureBoxHorse2);
            MoveHorse(pictureBoxHorse3);

            
            UpdateLeadingHorse();
            CheckForWinner();
        }
        private void MoveHorse(PictureBox horse)
        {
            horse.Left += random.Next(5, 15);
        }
        private void UpdateLeadingHorse()
        {
            // this method updates the leading horse in the race from the three horses by comparing the positions of each horse
            int farthestRight = Math.Max(pictureBoxHorse1.Left, Math.Max(pictureBoxHorse2.Left, pictureBoxHorse3.Left));
            if (pictureBoxHorse1.Left == pictureBoxHorse2.Left && pictureBoxHorse2.Left == pictureBoxHorse3.Left)
            {
                labelLeader.Text = "It's a tie!";
            }
            else if (farthestRight == pictureBoxHorse1.Left)
            {
                labelLeader.Text = "Horse 1 is leading";
            }
            else if (farthestRight == pictureBoxHorse2.Left)
            {
                labelLeader.Text = "Horse 2 is leading";
            }
            else
            {
                labelLeader.Text = "Horse 3 is leading!";
            }
        }
        private void CheckForWinner()
        {
            // it checks the winner horse of the rice by seeing which horse reached the finish line first by comparing the positions
            if (pictureBoxHorse1.Right >= labelFinishLine.Left)
            {
                RaceFinished("Horse 1");
            }
            else if (pictureBoxHorse2.Right >= labelFinishLine.Left)
            {
                RaceFinished("Horse 2");
            }
            else if (pictureBoxHorse3.Right >= labelFinishLine.Left)
            {
                RaceFinished("Horse 3");
            }
        }
       
        private void RaceFinished(string winningHorse)
        {
            timer1.Stop();
            MessageBox.Show($"{winningHorse} wins the race!");
            labelLeader.Text = $"{winningHorse} is the winner of the race!";
            buttonStart.Enabled = true;
        }
        private void ResetRace()
        {
            // this method is used to reset the race and the horses are set to their original position after pressing this 
            pictureBoxHorse1.Left = 0;
            pictureBoxHorse2.Left = 0;
            pictureBoxHorse3.Left = 0;
            labelLeader.Text = "Press the start button to begin the race";
            buttonStart.Enabled = true;
        }
        private void labelFinishLine_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxHorse1_Click(object sender, EventArgs e)
        {

        }
    }
}
