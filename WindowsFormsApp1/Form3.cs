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
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
       public Panel DeleteEditP = new Panel();
        Button delete = new Button();
        Button edit = new Button();
       
        ArrayList Alarms = new ArrayList();
        ArrayList Sounds = new ArrayList();
        int AlarmIndex = 0;

        SqlConnection dataConnectForm3;
        public Form3(ref ArrayList refAlarms, ref ArrayList refSounds, SqlConnection dataConnect)


        {
            delete.MouseClick += new System.Windows.Forms.MouseEventHandler(delete_Click);
            edit.MouseClick += new System.Windows.Forms.MouseEventHandler(edit_Click);
            dataConnectForm3 = dataConnect;
            Alarms = refAlarms;
            Sounds = refSounds;
            PanelMake();
           
            InitializeComponent();
           
            
            for (int i = 0; i < 10; i++)

            {
                int newRow = dataGridView1.Rows.Add();
            }
            dataGridView1.ClearSelection();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            }
        public void ListRefresh(ArrayList NewAlarms, ArrayList NewSounds)
        {
            ListClear();
            ListPopulate(NewAlarms, NewSounds);

        }
        public void ListClear()
        {
            for (int i = 0; i <dataGridView1.Rows.Count ; i++)

            {

                dataGridView1.Rows[i].Cells[0].Value = null;
                dataGridView1.Rows[i].Cells[1].Value = null;
                dataGridView1.Rows[i].Cells[2].Value = null;
                dataGridView1.Rows[i].Cells[3].Value = null;

            }
        }

        public void ListPopulate(ArrayList Alarms, ArrayList Sounds)

        {
            for (int i = 0; i <Alarms.Count; i++)


            {
                if (dataGridView1.Rows.Count < Alarms.Count) { 
            

                    int newRow = dataGridView1.Rows.Add();
                }


                DateTime Alarm = (DateTime)Alarms[i];
                string Sound = (string)Sounds[i];

                dataGridView1.Rows[i].Cells[0].Value=Alarm.ToString("h:mm:ss tt"); // brackets of .tostring specifies format for type DateTime
                                                                         //no argument=Returns a string that represents the current object
                                        //for datetime, yyyy-MM-dd hh:mm tt (2014-08-28 12:28 PM) is base format when brackets have no argument
                dataGridView1.Rows[i].Cells[1].Value = Alarm.ToString("ddd, dd MMM yyyy");
                dataGridView1.Rows[i].Cells[2].Value =0;
                dataGridView1.Rows[i].Cells[3].Value =SoundFileName(Sound);

            }
        }

      
       private string SoundFileName(String soundfile)
        {
            if (soundfile.Equals("0")){
                soundfile = "Default Sound";
            }
            return soundfile;
        }

    

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.dataGridView1.ClientRectangle, Color.LightCoral, ButtonBorderStyle.Solid);
        }

        private void PanelMake()
        {
            DeleteEditP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(32)))));
            DeleteEditP.ForeColor = System.Drawing.Color.LightCoral;// text colour on control
           //this.DeleteEditP.Paint += new System.Windows.Forms.PaintEventHandler(this.DeleteEditP_Paint);//border colour 
          
            DeleteEditP.Size = new System.Drawing.Size(140, 65);
            DeleteEditP.Controls.Add(delete);
            DeleteEditP.Controls.Add(edit);

            delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            delete.FlatAppearance.BorderSize = 0;
            delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            delete.Location = new System.Drawing.Point(0, 5);
            delete.Name = "delete";
            delete.Size = new System.Drawing.Size(140, 25);
            delete.TabIndex = 10;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;

            edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            edit.FlatAppearance.BorderSize = 0;
            edit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            edit.Location = new System.Drawing.Point(0, 35);
            edit.Name = "edit";
            edit.Size = new System.Drawing.Size(140, 25);
            edit.TabIndex = 10;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = true;


        }
        private void DeleteEditP_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.DeleteEditP.ClientRectangle, Color.LightCoral, ButtonBorderStyle.Solid);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.ClearSelection();
            DeleteEditP.Visible = false;
      
           
               // ContextMenu DeleteEdit = new ContextMenu();
                //DeleteEdit.MenuItems.Add(new MenuItem("Delete Alarm"));
                //DeleteEdit.MenuItems.Add(new MenuItem("Edit Alarm"));
               
                

                if (dataGridView1.HitTest(e.X, e.Y).RowIndex >= 0 && dataGridView1.HitTest(e.X, e.Y).RowIndex< Alarms.Count )
                {
                dataGridView1.Rows[dataGridView1.HitTest(e.X, e.Y).RowIndex].Selected = true;
                //DeleteEdit.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", dataGridView1.HitTest(e.X, e.Y).RowIndex.ToString())));
                // DeleteEdit.Show(dataGridView1, new Point(e.X, e.Y));
                //MessageBox.Show(e.X+"  "+e.Y);

                 AlarmIndex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
               // MessageBox.Show(AlarmIndex.ToString());
                //MessageBox.Show(Alarms[AlarmIndex].ToString());

                if (e.Button == MouseButtons.Right)
                {
                    DeleteEditP.Location = new Point(e.X+dataGridView1.Location.X, e.Y+ dataGridView1.Location.Y);
                    this.Controls.Add(DeleteEditP);
                    DeleteEditP.BringToFront();
                    DeleteEditP.Show();
                }

               

            }

        }
        private void delete_Click(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(AlarmIndex.ToString());
           // MessageBox.Show(Alarms[AlarmIndex].ToString());
            Alarms.RemoveAt(AlarmIndex);
           Sounds.RemoveAt(AlarmIndex);
            DataBaseDelete();
            ListRefresh(Alarms, Sounds );
            DeleteEditP.Visible = false;

        }
        private void DataBaseDelete()
        {
         
            SqlCommand DeleteCommand = new SqlCommand("WITH CTE as(Select Row_Number() Over(Order By ALARMTIME) As RowNum, *From tbluserAlarms) Delete from CTE where RowNum =@RowSelected", dataConnectForm3);
            DeleteCommand.Parameters.Add("@RowSelected", SqlDbType.Int).Value = AlarmIndex+1;
            dataConnectForm3.Open();
            DeleteCommand.ExecuteNonQuery();
            dataConnectForm3.Close();

        }

        private void edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("didnt make yet lmao");
        }


        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.HitTest(e.X, e.Y).RowIndex >= 0)
            {
                dataGridView1.Rows[dataGridView1.HitTest(e.X, e.Y).RowIndex].Selected = true;
                
            }

        }

        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.ClearSelection();
            DeleteEditP.Visible = false;
        }
    }
}
