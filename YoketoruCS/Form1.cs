using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices;

namespace YoketoruCS
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        static int PlayerMax => 1;
        static int EnemyMax => 4;
        static int ItemMax => 4;//�����ς�邽�ߍŌ�ɏ���

        static int PlayerIndex => 0;
        static int EnemyIndex => PlayerIndex + PlayerMax;
        static int ItemIndex => EnemyIndex + EnemyMax;
        static int LabelMax => ItemIndex + ItemMax;

        //���x�����`
        Label[] labels = new Label[LabelMax];

        static Random Random = new Random();

        int[] vx = new int[LabelMax];
        int[] vy = new int[LabelMax];  
        static int SpeadMax =>10;

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

            for (int i = 0; i < LabelMax; i++)
            {
                labels[i] = new Label();
                labels[i].AutoSize = true;
                labels[i].Visible = false;
                Controls.Add(labels[i]);

                tempPlayer.Visible = false;
                tempEnemy.Visible = false;
                tempItem.Visible = false;

                //Text,Font,ForeColor����ނ��Ƃɐݒ肵����!!
                if (i == PlayerIndex)
                {
                    labels[i].Text = tempPlayer.Text;
                    labels[i].Font = tempPlayer.Font;
                    labels[i].ForeColor = tempPlayer.ForeColor;
                }
                else if (i > PlayerIndex && i < ItemIndex)
                {
                    labels[i].Text = tempEnemy.Text;
                    labels[i].Font = tempEnemy.Font;
                    labels[i].Left = labels[i - 1].Width + labels[i - 1].Left;
                    labels[i].ForeColor = tempEnemy.ForeColor;

                }
                else if (i >= ItemIndex && i < LabelMax)
                {
                    labels[i].Text = tempItem.Text;
                    labels[i].Font = tempItem.Font;
                    labels[i].Left = labels[i - 1].Width + labels[i - 1].Left;
                    labels[i].ForeColor = tempItem.ForeColor;

                }
            }

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
                    labelTitle.Visible = true;
                    buttonStart.Visible = true;

                    labelGameover.Visible = false;
                    labelClear.Visible = false;
                    buttonToTitle.Visible = false;
                    break;

                case State.Game:
                    labelTitle.Visible = false;
                    buttonStart.Visible = false;
                    for (int i = 0; i < LabelMax; i++)
                    {
                        labels[i].Visible = true;

                        labels[i].Left = Random.Next(ClientSize.Width - labels[i].Width + 1);
                        labels[i].Top = Random.Next(ClientSize.Height - labels[i].Height + 1);

                        //�����_���ȑ��x�̏�����
                        vx[i] = Random.Next(-SpeadMax, SpeadMax + 1);
                        vy[i] = Random.Next(SpeadMax, SpeadMax + 1);
                    }
                    break;

                case State.Gameover:
                    labelGameover.Visible = true;
                    buttonToTitle.Visible = true;
                    break;

                case State.Clear:
                    labelClear.Visible = true;
                    buttonToTitle.Visible = true;
                    break;
            }
        }

        void UpdateState()
        {
            switch (currentState)
            {
                case State.Game:
                    UpdateGame();
                    break;
            }
        }

        void UpdateGame()
        {
            if (GetAsyncKeyState((int)Keys.O) < 0)
            {
                nextState = State.Gameover;
            }

            if (GetAsyncKeyState((int)Keys.C) < 0)
            {
                nextState = State.Clear;
            }

            //�v���C���[�̈ړ�
            var fpos = PointToClient(MousePosition);

            labels[PlayerIndex].Left = fpos.X - labels[PlayerIndex].Width/2;
            labels[PlayerIndex].Top = fpos.Y - labels[PlayerIndex].Height/2;

            UpdateChrs();
        }

        void UpdateChrs()
        {
            //�A�C�e���ƓG�������_���Œ��˕Ԃ�ړ�
            for (int i = 1; i < LabelMax; i++)
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];

                if (labels[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                else if (labels[i].Top < 0)
                {
                    vy[i]= Math.Abs(vy[i]);
                }
                if (labels[i].Left > ClientSize.Width - labels[i].Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                else if (labels[i].Top > ClientSize.Height - labels[i].Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void buttonToTitle_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }


    }
}