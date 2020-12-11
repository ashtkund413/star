using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace star
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int i = 1000;

            while (i <= 1000)
            {

                Random randGen = new Random();
                int S;
                int E;
                int T;

                S = randGen.Next(1, 2000);

                E = randGen.Next(1, 100);
               T = randGen.Next(1, 1000);


                Font drawFont = new Font("Comic Sans", E, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Turquoise);
                




                g.DrawString("*", drawFont, drawBrush, T, S);
                
                    }
        }
    }
}
