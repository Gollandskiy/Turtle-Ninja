using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turtle_Ninja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Brushes.Black, 3);
            g.FillEllipse(Brushes.LimeGreen, 290, 85, 200, 280);
            g.FillEllipse(Brushes.Lime, 290, 100, 200, 250);
            g.FillEllipse(Brushes.Lime, 270, 260, 40, 40);
            g.FillEllipse(Brushes.Lime, 468, 260, 40, 40);
            g.FillEllipse(Brushes.Yellow, 335, 215, 110, 110);
            g.FillRectangle(Brushes.Yellow, 341, 155, 100, 130);
            g.FillRectangle(Brushes.Lime, 341, 334, 30, 50);
            g.FillRectangle(Brushes.Lime, 411, 334, 30, 50);
            g.FillRectangle(Brushes.Purple, 411, 360, 30, 15);
            g.FillRectangle(Brushes.Purple, 341, 360, 30, 15);
            g.FillEllipse(Brushes.Lime, 341, 60, 100, 80);
            g.FillEllipse(Brushes.Lime, 351, 40, 80, 70);
            g.FillRectangle(Brushes.Purple, 352, 50, 80, 20);
            g.FillEllipse(Brushes.Black, 365, 80, 15, 15);
            g.FillEllipse(Brushes.Black, 400, 80, 15, 15);
            g.FillEllipse(Brushes.White, 365, 80, 5, 5);
            g.FillEllipse(Brushes.White, 400, 80, 5, 5);
            g.FillRectangle(Brushes.Gray, 483, 230, 17, 100);
            g.FillRectangle(Brushes.SaddleBrown, 483, 100, 17, 130);
            g.FillRectangle(Brushes.SaddleBrown, 483, 290, 17, 130);



        }
    }
}
