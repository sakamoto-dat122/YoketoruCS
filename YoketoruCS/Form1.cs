namespace YoketoruCS
{
    public partial class Form1 : Form
    {
        enum State
        {
            None = -1,
            Title,
            Game,
            Gameover,
            Clear
        }
        
        /// <summary>
        /// Ÿ‚ÉØ‚è‘Ö‚¦‚½‚¢ó‘Ô
        /// </summary>
        State nextStage = State.Title;

        /// <summary>
        /// Œ»İ‚Ìó‘Ô
        /// </summary>
        State nextState = State.None;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}