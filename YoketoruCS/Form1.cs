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
        /// ���ɐ؂�ւ��������
        /// </summary>
        State nextStage = State.Title;

        /// <summary>
        /// ���݂̏��
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