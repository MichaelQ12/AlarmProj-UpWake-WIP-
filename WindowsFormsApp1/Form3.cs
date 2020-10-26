using System;
using System.Collections;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
           
            
            for (int i = 0; i < 10; i++)

            {
                int newRow = dataGridView1.Rows.Add();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            }

        public void ListClear()
        {
            for (int i = 0; i <dataGridView1.Rows.Count ; i++)

            {

                dataGridView1.Rows[i].Cells[0].Value = null;
                dataGridView1.Rows[i].Cells[1].Value = null;
              
            }
        }

        public void ListPopulate(ArrayList Alarms)

        {
            for (int i = 0; i <Alarms.Count; i++)


            {
                if (dataGridView1.Rows.Count < Alarms.Count) { 
            

                    int newRow = dataGridView1.Rows.Add();
                }


                DateTime Alarm = (DateTime)Alarms[i];
               
              
               dataGridView1.Rows[i].Cells[0].Value=( Alarm.Hour + ":" + Alarm.Minute + ":" + Alarm.Second);
                dataGridView1.Rows[i].Cells[1].Value = ( Alarm.Day + ":" + Alarm.Month + ":" + Alarm.Year);

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.dataGridView1.ClientRectangle, Color.LightCoral, ButtonBorderStyle.Solid);
        }
    }
}
