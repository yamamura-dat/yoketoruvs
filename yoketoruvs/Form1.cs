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
