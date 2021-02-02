using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4PopUp : Form
    {
        int plusminus = 1;
        
        public Form4PopUp()
        {
            
            InitializeComponent();
            this.Opacity = 0;
        }

      
      
        public void PopStart(String message)
        {
       
            label1.Text = message;
            plusminus = 1;
            timer1.Enabled = true;
            

        }

        private void Form4PopUp_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.LightCoral, ButtonBorderStyle.Solid);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + plusminus * 0.05;

            if (this.Opacity ==1) {
                plusminus = -1;
               
            }
            else if (this.Opacity == 0)
            {
                timer1.Enabled = false;
                plusminus = 1;
            }


        }
    }
}
