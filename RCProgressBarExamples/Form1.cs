using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCProgressBarExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            roundCorneredProgressBar1.Animate();
            roundCorneredProgressBar2.Animate();
            roundCorneredProgressBar3.Animate();
        }
    }
}
