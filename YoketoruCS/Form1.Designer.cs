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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
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
    }
}