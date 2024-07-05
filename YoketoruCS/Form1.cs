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
        static int ItemMax => 4;//数が変わるため最後に書く

        static int PlayerIndex => 0;
        static int EnemyIndex => PlayerIndex + PlayerMax;
        static int ItemIndex => EnemyIndex + EnemyMax;
        static int LabelMax => ItemIndex + ItemMax;

        //ラベルを定義
        Label[] labels = new Label[LabelMax];

        static Random random = new Random();

        int[] vx = new int[LabelMax];
        int[] vy = new int[LabelMax];
        static int SpeadMax => 10;

        int score = 0;
        int timer = 200;
        int ItemUp;

        enum State
        {
            None = -1,
            Title,
            Game,
            Gameover,
            Clear
        }

        /// <summary>
        /// 次に切り替えたい状態
        /// </summary>
        State nextState = State.Title;

        /// <summary>
        /// 現在の状態
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

                //Text,Font,ForeColorを種類ごとに設定したい!!
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
                return; //実行されるとメソッドを終了して呼び出し元に処理が戻る
            }
            currentState = nextState;
            nextState = State.None;


            //初期化処理
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

                    score = 0;
                    timer = 200;
                    ItemUp = ItemMax;

                    for (int i = 0; i < LabelMax; i++)
                    {
                        labels[i].Visible = true;

                        labels[i].Left = random.Next(ClientSize.Width - labels[i].Width);
                        labels[i].Top = random.Next(ClientSize.Height - labels[i].Height);

                        //ランダムな速度の初期化
                        vx[i] = random.Next(-SpeadMax, SpeadMax + 1);
                        vy[i] = random.Next(-SpeadMax, SpeadMax + 1);
                    }
                    break;

                case State.Gameover:
                    labelGameover.Visible = true;
                    buttonToTitle.Visible = true;

                    score = 0;
                    timer = 200;
                    break;

                case State.Clear:
                    labelClear.Visible = true;
                    buttonToTitle.Visible = true;

                    score = 0;
                    timer = 200;
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

            //プレイヤーの移動
            var fpos = PointToClient(MousePosition);

            labels[PlayerIndex].Left = fpos.X - labels[PlayerIndex].Width / 2;
            labels[PlayerIndex].Top = fpos.Y - labels[PlayerIndex].Height / 2;

            UpdateChrs();

            //カウントダウン、0になったらGameover
            timer--;
            labelTime.Text = $"{timer}";
            if(timer <= 0)
            {
                nextState = State.Gameover;
            }

            
            //fposがラベルと重なっているか判定
            for (int i = EnemyIndex; i < LabelMax; i++)
            {
                if (fpos.X > labels[i].Left
                    && fpos.X < labels[i].Right
                    && fpos.Y > labels[i].Top
                    && fpos.Y < labels[i].Bottom)
                {
                    //敵のとき、ゲームオーバー
                    if (i < ItemIndex)
                    {
                        nextState = State.Gameover;
                    }
                    else
                    {
                        //スコアの加算
                        labelScore.Text = $"{score}";
                        score += timer * 100;

                        //アイテムをとったら消える
                        labels[i].Visible = false;
                        ItemUp--;
                        //アイテムを全てとったら、クリア
                        if(ItemUp <= 0)
                        {
                            nextState = State.Clear;
                        }
                    }

                }
            }
        }

        void UpdateChrs()
        {
            //アイテムと敵をランダムで跳ね返り移動
            for (int i = EnemyIndex; i < LabelMax; i++)
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];

                if (labels[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                else if (labels[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
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