using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Point mousePosition;

        Form2 Home = new Form2();
        Form3 Alarms = new Form3();

        public Form1()
        {
            

            InitializeComponent();
            currentForm = Home;
            openChild(Home);
           

        }

      
        



        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void panel1_MouseDown(object sender, MouseEventArgs e)//executes on mouse press on panel1, not releasse 
        {
            mousePosition = new Point(-e.X, -e.Y);//Stores XY position of cursor upon a left click on panel 1 
            //XY position made negative for offsetting, XY plane of PC starts (0,0) at top left 
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                Point mousePose = Control.MousePosition;//COntinuosly updates+stores current mouse XY on condition that it is 
                                                        //moving in Panel1 and mouse left is pressed 
                //label2.Text = ("(" + mousePosition.X + " " + mousePosition.Y + ") (" + mousePose.X + " " + mousePose.Y + ")");
                mousePose.Offset(mousePosition.X, mousePosition.Y);
                //adds current mouse XY after moving with original mouseXY at first click on panel1
                                                                  
                //label3.Text = ("(" + mousePose.X + " " + mousePose.Y + ")");
                Location = mousePose;
                //Due to negative value of mousePosition that was added, mousePose now represents new position of top left form corner
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
      
      
        

      
        

       private void iconButton1_Click(object sender, EventArgs e)
        {
            
            openChild(Home);


        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
           
            openChild(Alarms);


        }

        private Form currentForm = null;
        private void openChild(Form child)
        {
            if (currentForm != null)
            {
                currentForm.Visible = false;
                currentForm = child;
                child.TopLevel = false;
                
                child.Dock = DockStyle.Fill;
                panel2.Controls.Add(child);
                panel2.Tag = child;
                child.BringToFront();
                child.Show();
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Alarms.ListClear();
            Alarms.ListPopulate(Home.Alarms);
        }
    }
}
