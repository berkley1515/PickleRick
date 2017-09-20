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

namespace PickleRick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawPickleRick_Click(object sender, EventArgs e)
        {
            //sounds



            //graphics
            Graphics pickleRick = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            Font drawFont = new Font("Impact", 30, FontStyle.Bold);
            SolidBrush drawBrushFont = new SolidBrush(Color.Red);
            Pen PacmanAPen = new Pen(Color.Yellow);
            SolidBrush PacmanABrush = new SolidBrush(Color.Yellow);








        }
    }
}
