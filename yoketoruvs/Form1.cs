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

        const int SpeedMax = 15;
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];
        int itemcount = ItemMax;
        int timecount = 100;
        int hiscore = 0;

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
                chrs[i].Font = tempLabel.Font;
                Controls.Add(chrs[i]);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nextState != State.None)
            {
                timecount = 100;
                itemcount = ItemMax;
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
            timecount--;
            TimeLabel.Text = "Time " + timecount;
            leftLabel.Text = "★:" + itemcount;
            Point mp = PointToClient(MousePosition);
            chrs[PlayerIndex].Left = mp.X - chrs[PlayerIndex].Width / 2;
            chrs[PlayerIndex].Top = mp.Y - chrs[PlayerIndex].Height / 2;

            for (int i = EnemyIndex; i < ChrMax; i++)
            {
                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];

                if (chrs[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (chrs[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (chrs[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (chrs[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }

                if (    (mp.X >= chrs[i].Left)
                     && (mp.X < chrs[i].Right)
                     && (mp.Y >= chrs[i].Top)
                     && (mp.Y < chrs[i].Bottom))
                {
                    //timer1.Enabled = false;// aが0かつbが0
                    //nextState = State.Gameover;
                    //chrs[PlayerIndex].Text = "(´･ω･`)";

                    //敵
                    if (chrs[i].Text == EnemyText)
                    {
                        nextState = State.Gameover;
                        chrs[PlayerIndex].Text = "(oAo)";
                    }
                    else
                    {
                        //アイテム
                        chrs[i].Visible = false;
                        vx[i] = 0;
                        itemcount -= 1;
                        
                        if(itemcount<0)
                        {
                            if (timecount > hiscore)
                            {
                                hiscore = timecount;
                            }
                            nextState = State.Clear;

                        }

                    }
                }
                if (timecount == 0)
                {
                    nextState = State.Gameover;
                    chrs[PlayerIndex].Text = "(´･ω･`)";
                }
            }
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
                    HighScoreLabel.Text = "HighScore " + hiscore;
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
                        vx[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        vy[i] = rand.Next(-SpeedMax, SpeedMax + 1);
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
                    HighScoreLabel.Text = "HighScore " + hiscore;
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
            chrs[PlayerIndex].Text = "(｀・ω・´)";
           
        }

        private void titleBotton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}
