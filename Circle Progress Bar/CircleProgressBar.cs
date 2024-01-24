using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace Circle_Progress_Bar
{
    class CircleProgressBar: Control
    {
        private int startAngle = 270;
        public int endAngle = 0;
        public int percentValue = 0;
        public CircleProgressBar()
        {
            this.Height = this.Width = 150;
           
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            
            g.FillEllipse(new SolidBrush(Color.Black),0,0, Width ,Height );
            g.FillEllipse(new SolidBrush(Color.White), 15, 15, Width-30, Height-30);

            Pen pen = new Pen(Color.Yellow, 15);
            g.DrawArc(pen,7.5f,7.5f,Width-15,Height-15,startAngle,endAngle);

            g.DrawString(percentValue+"%", new Font("Arial",20), new SolidBrush(Color.Black),Width/3, Height/2.5f);


        }

        
    }
}
