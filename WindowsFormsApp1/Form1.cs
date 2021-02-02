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
        static Form4PopUp Message = new Form4PopUp();
        
        static Form2 Home = new Form2(ref Message);
        static Form3 FAlarms = new Form3(ref Home.Alarms, ref Home.Sounds, Home.dataConnect);
        
        public Point mousePosition;

        private Form currentForm = null;

        public Form1()
        {
            

            InitializeComponent();
            currentForm = Home;
            openChild(Home);
            SetMessageLocation(Location);
        }

        public void SetMessageLocation(Point xy)
        {
            int x = panel2.Location.X + Home.panel3.Location.X+ xy.X+75;
            int y = panel2.Location.Y + Home.panel3.Location.Y+ xy.Y;
            Message.Location = new Point(x, y);
        }




        private void Form1_Load(object sender, EventArgs e)
        {
          
             SetMessageLocation(Location);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            SetMessageLocation(Location);
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
           
            openChild(FAlarms);


        }

        
        private void openChild(Form child)
        {
            if (currentForm != null)
            {
                currentForm.Visible = false;
                currentForm = child;
                child.TopLevel = false;
                
               
                panel2.Controls.Add(child);
               
                child.BringToFront();
                child.Show();
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FAlarms.ListClear();
            FAlarms.ListPopulate(Home.Alarms, Home.Sounds);
        }

      
        public void Control_ClicksHome(object sender, EventArgs e)
        {
            Control control = (Control)sender;   // Sender gives you which control is clicked.
            if (control != Home.groupBox1|| control != Home.panel3) { 
            //MessageBox.Show(control.Name.ToString());
                Home.groupBox1.Visible = false;
                Home.panel3.Visible = false;
            }
            if (control != FAlarms.dataGridView1)
            {
                //MessageBox.Show(control.Name.ToString());
                FAlarms.dataGridView1.ClearSelection();
                FAlarms.DeleteEditP.Visible = false;
            }
        }

     
    }
}
