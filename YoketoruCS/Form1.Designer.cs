namespace YoketoruCS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTitle = new Label();
            buttonStart = new Button();
            labelGameover = new Label();
            buttonToTitle = new Button();
            labelClear = new Label();
            labelScore = new Label();
            labelTime = new Label();
            tempPlayer = new Label();
            tempEnemy = new Label();
            tempItem = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("UD デジタル 教科書体 N-B", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelTitle.Location = new Point(340, 123);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(264, 55);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "よけとるCS";
            // 
            // buttonStart
            // 
            buttonStart.BackColor = SystemColors.Menu;
            buttonStart.Font = new Font("Yu Gothic UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.Location = new Point(315, 271);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(314, 103);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start!!";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelGameover
            // 
            labelGameover.AutoSize = true;
            labelGameover.Font = new Font("メイリオ", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelGameover.ForeColor = Color.Maroon;
            labelGameover.Location = new Point(313, 139);
            labelGameover.Name = "labelGameover";
            labelGameover.Size = new Size(318, 72);
            labelGameover.TabIndex = 2;
            labelGameover.Text = "GAMEOVER";
            // 
            // buttonToTitle
            // 
            buttonToTitle.BackColor = SystemColors.Control;
            buttonToTitle.Font = new Font("メイリオ", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonToTitle.Location = new Point(315, 271);
            buttonToTitle.Name = "buttonToTitle";
            buttonToTitle.Size = new Size(314, 103);
            buttonToTitle.TabIndex = 3;
            buttonToTitle.Text = "タイトルへ";
            buttonToTitle.UseVisualStyleBackColor = false;
            buttonToTitle.Click += buttonToTitle_Click;
            // 
            // labelClear
            // 
            labelClear.AutoSize = true;
            labelClear.Font = new Font("メイリオ", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelClear.ForeColor = Color.Turquoise;
            labelClear.Location = new Point(375, 139);
            labelClear.Name = "labelClear";
            labelClear.Size = new Size(195, 72);
            labelClear.TabIndex = 4;
            labelClear.Text = "CLEAR";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("メイリオ", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelScore.Location = new Point(453, 9);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(39, 44);
            labelScore.TabIndex = 5;
            labelScore.Text = "0";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("メイリオ", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTime.Location = new Point(853, 448);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(79, 44);
            labelTime.TabIndex = 6;
            labelTime.Text = "200";
            // 
            // tempPlayer
            // 
            tempPlayer.AutoSize = true;
            tempPlayer.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            tempPlayer.Location = new Point(68, 359);
            tempPlayer.Name = "tempPlayer";
            tempPlayer.Size = new Size(107, 40);
            tempPlayer.TabIndex = 7;
            tempPlayer.Text = "(◠ڼ◠)";
            // 
            // tempEnemy
            // 
            tempEnemy.AutoSize = true;
            tempEnemy.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            tempEnemy.ForeColor = Color.CadetBlue;
            tempEnemy.Location = new Point(415, 422);
            tempEnemy.Name = "tempEnemy";
            tempEnemy.Size = new Size(46, 40);
            tempEnemy.TabIndex = 8;
            tempEnemy.Text = "◆";
            // 
            // tempItem
            // 
            tempItem.AutoSize = true;
            tempItem.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            tempItem.ForeColor = Color.Gold;
            tempItem.Location = new Point(275, 408);
            tempItem.Name = "tempItem";
            tempItem.Size = new Size(46, 40);
            tempItem.TabIndex = 9;
            tempItem.Text = "★";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(tempItem);
            Controls.Add(tempEnemy);
            Controls.Add(tempPlayer);
            Controls.Add(labelTime);
            Controls.Add(labelScore);
            Controls.Add(labelClear);
            Controls.Add(buttonToTitle);
            Controls.Add(labelGameover);
            Controls.Add(buttonStart);
            Controls.Add(labelTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label labelTitle;
        private Button buttonStart;
        private Label labelGameover;
        private Button buttonToTitle;
        private Label labelClear;
        private Label labelScore;
        private Label labelTime;
        private Label tempPlayer;
        private Label tempEnemy;
        private Label tempItem;
    }
}