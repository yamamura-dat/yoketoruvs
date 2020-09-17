using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace yoketoruvs
{
    public partial class Form1 : Form
    {
        const bool isDebug = true;

        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + PlayerMax;
        const int ItemIndex = EnemyIndex + EnemyMax;

        const string PlayerText = "(｀・ω・´)";
        const string EnemyText = "(oAo)";
        const string ItemText = "◆";

        static Random rand = new Random();

        enum State
        {
            None =-1,//無効
            Title,
            Game,
            Gameover,
            Clear
        }
        State currentState = State.None;
        State nextState = State.Title;

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public Form1()
        {

            InitializeComponent();

            for (int i = 0; i < ChrMax; i++) 
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if (i == PlayerIndex)
                {
                    chrs[i].Text = PlayerText;
                }
                else if (i < ItemIndex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;
                }
                Controls.Add(chrs[i]);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nextState != State.None)
            {
                initProc();
            }

            if (isDebug)
            {
                if (GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                else if(GetAsyncKeyState((int)Keys.C) < 0)
                {
                    nextState = State.Clear;
                }
            }

            if(currentState == State.Game)
            {
                UpdataGame();
            }
        }

        void UpdataGame()
        {
            Point mp = PointToClient(MousePosition);
            mp = PointToClient(mp);
        }

        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch (currentState)
            {
                case State.Title:
                    titleLabel.Visible = true;
                    startbotton.Visible = true;
                    copyrightLabel.Visible = true;
                    HighScoreLabel.Visible = true;
                    gameoverLabel.Visible = false;
                    titleBotton.Visible = false;
                    clearLabel.Visible = false;
                    break;

                case State.Game:
                    titleLabel.Visible = false;
                    startbotton.Visible = false;
                    copyrightLabel.Visible = false;
                    HighScoreLabel.Visible = false;

                    for (int i = EnemyIndex;i<ChrMax;i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                    }

                        break;

                case State.Gameover:
                    gameoverLabel.Visible = true;
                    titleBotton.Visible = true;
                    break;

                case State.Clear:
                    clearLabel.Visible = true;
                    titleBotton.Visible = true;
                    HighScoreLabel.Visible = true;
                    break;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startbotton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void titleBotton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}
