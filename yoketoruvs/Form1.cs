using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yoketoruvs
{
    public partial class Form1 : Form
    {
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
    }
}
