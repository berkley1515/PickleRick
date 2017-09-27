/// Berkley Fair
/// Sept 27th
/// Program plays a beeep sound when button pressed, wastes time loading, then plays pickle rick sound , then welcome text. END

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
            System.Windows.Media.MediaPlayer beepPlayer;
            System.Windows.Media.MediaPlayer themePlayer;

            //sounds
            beepPlayer = new System.Windows.Media.MediaPlayer(); 
            beepPlayer.Open(new Uri(Application.StartupPath + "/Resources/beep_02.wav")); 
            themePlayer = new System.Windows.Media.MediaPlayer(); //theme
            themePlayer.Open(new Uri(Application.StartupPath + "/Resources/Im_Pickle_Rick.wav")); //theme

            //hide label
            musicPlayer.Visible = false;
            beepPlayer.Play();
            Thread.Sleep(1000);
            beepPlayer.Stop();

            //graphics
            Graphics graphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush labelBrushA = new SolidBrush(Color.Navy);
            Font loadingFont = new Font("Impact", 40, FontStyle.Bold);
            SolidBrush loadingBrush = new SolidBrush(Color.DarkGray);
            Font loadingFontCover = new Font("Impact", 40, FontStyle.Bold);
            SolidBrush loadingBrushCover = new SolidBrush(Color.Blue);
            Font welcomeFont = new Font("Comic Sans", 30, FontStyle.Bold);
            SolidBrush welcomeBrush = new SolidBrush(Color.Red);

            //loadscreen (waste time counting down)
            graphics.DrawString("Loading", loadingFont, loadingBrush, 120, 140);
            Thread.Sleep(1200);
            graphics.DrawString(".", loadingFont, loadingBrush, 305, 140);
            Thread.Sleep(1200);
            graphics.DrawString(".", loadingFont, loadingBrush, 320, 140);
            Thread.Sleep(1200);
            graphics.DrawString(".", loadingFont, loadingBrush, 335, 140);
            Thread.Sleep(1200);
            //blue
            graphics.DrawString(".", loadingFontCover, loadingBrushCover, 305, 140);
            Thread.Sleep(1200);
            graphics.DrawString(".", loadingFontCover, loadingBrushCover, 320, 140);
            Thread.Sleep(1200);
            graphics.DrawString(".", loadingFontCover, loadingBrushCover, 335, 140);
            Thread.Sleep(1200);
            //gray
            graphics.DrawString(".", loadingFont, loadingBrush, 305, 140);
            Thread.Sleep(1200);
            graphics.DrawString(".", loadingFont, loadingBrush, 320, 140);
            Thread.Sleep(1200);
            graphics.DrawString(".", loadingFont, loadingBrush, 335, 140);
            Thread.Sleep(1200);

            Thread.Sleep(1000); //make longer after testing
            graphics.FillRectangle(labelBrushA, 110, 140, 270, 70);
            graphics.DrawString("Welcome!", welcomeFont, welcomeBrush, 140, 150);
            themePlayer.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //need to not throw errors
        }
    }
}
