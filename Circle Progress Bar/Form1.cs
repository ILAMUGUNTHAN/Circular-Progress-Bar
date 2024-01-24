using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle_Progress_Bar
{

    public partial class Form1 : Form
    {
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void OnClickInc(object sender, EventArgs e)
        {

            if (circleProgressBar1.endAngle < 360)
            {
                circleProgressBar1.endAngle += 36;
                circleProgressBar1.Invalidate();
                circleProgressBar1.percentValue += 10;
            }
        }

        private void OnclickDec(object sender, EventArgs e)
        {
            if (circleProgressBar1.endAngle >=36)
            {
                circleProgressBar1.endAngle -= 36;
                circleProgressBar1.Invalidate();
                circleProgressBar1.percentValue -= 10;

            }
        }
    }
}
