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
        State nextState = State.Title;

        /// <summary>
        /// ���݂̏��
        /// </summary>
        State currentState = State.None;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InitState();
            UpdateState();
        }

        void InitState()
        {
            if (nextState == State.None)
            {
                return; //���s�����ƃ��\�b�h���I�����ČĂяo�����ɏ������߂�
            }
            currentState = nextState;
            nextState = State.None;


            //����������
            switch (currentState)
            {
                case State.Title:
                    labelGameover.Visible = false;
                    buttonToTitle.Visible = false;
                    break;

                case State.Game:
                    labelTitle.Visible = false;
                    buttonStart.Visible = false;
                    break;
            }
        }

        void UpdateState()
        {
            switch(currentState)
            {
                case State.Game:
                    UpdateGame();
                    break;
            }
        }

        void UpdateGame()
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }
    }
}