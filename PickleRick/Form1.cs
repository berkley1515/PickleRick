using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.IO; 


namespace PickleRick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawPickleRick_Click(object sender, EventArgs e) //i made it so when u click starting label it loads this
        {
            //players
            System.Windows.Media.MediaPlayer evilPlayer;
            System.Windows.Media.MediaPlayer moonmanPlayer;
            System.Windows.Media.MediaPlayer themePlayer;
            //sounds
            evilPlayer = new System.Windows.Media.MediaPlayer(); //evil morty
            evilPlayer.Open(new Uri(Application.StartupPath + "/Resources/Rick_and_Morty_-_Evil_Morty_Theme_Song_Trap_Remix_.wav")); //evil morty
            moonmanPlayer = new System.Windows.Media.MediaPlayer(); //moonman
            moonmanPlayer.Open(new Uri(Application.StartupPath + "/Resources/Goodbye_Moonmen_-_rick_and_morty.wav")); //moonman
            themePlayer = new System.Windows.Media.MediaPlayer(); //theme
            themePlayer.Open(new Uri(Application.StartupPath + "/Resources/Rick_and_Morty.wav")); //theme

            musicPlayer.Visible = false;

            //graphics
            Graphics graphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            Font drawFont = new Font("Impact", 30, FontStyle.Bold);
            SolidBrush drawBrushFont = new SolidBrush(Color.Red);
            Pen PacmanAPen = new Pen(Color.Yellow);
            SolidBrush PacmanABrush = new SolidBrush(Color.Yellow);


            graphics.DrawRectangle





        }

        
    }
}
