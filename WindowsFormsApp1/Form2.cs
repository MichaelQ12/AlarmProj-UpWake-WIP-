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
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        SqlConnection dataConnect = new SqlConnection("Data Source=LAPTOP-HE44SG9B\\SQLEXPRESS; Initial Catalog=Test1; Integrated Security=TRUE");
        SqlDataAdapter dataPopulate = new SqlDataAdapter();
        
        public Point mousePosition;

        public ArrayList Alarms = new ArrayList();
        public ArrayList Sounds = new ArrayList();

        String filePath;


        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form2()
        {
        
            InitializeComponent();

            label1.Text = DateTime.Now.ToString("h:mm:ss tt");

            
                SqlCommand command = new SqlCommand("SELECT ALARMSOUND, ALARMTIME FROM tbluserAlarms;", dataConnect);
                dataConnect.Open();
                SqlDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                {

                   Sounds.Add(reader.GetValue(0));
                    Alarms.Add(reader.GetValue(1));
                 
                }

                dataConnect.Close();

            
           
          

        }

        private void alarmset1_Click(object sender, EventArgs e)
        {
            Sounds.Add("0");//add 0 to sound array for tracking if user sets custom sound, assumes no custom sound by adding 0 on press
                            //0 is default sound
            groupBox1.Visible = true;
            
           
        }


       

       

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

    
       


        

        

      

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToLongTimeString();


            DateTime current = DateTime.Now;




                for (int i = 0; i <Alarms.Count; i++)
                {

                Console.WriteLine(Sounds[i]);
                    DateTime Alarm = (DateTime)Alarms[i];

                    if (Alarm.Hour == current.Hour && Alarm.Minute == current.Minute && Alarm.Second == current.Second)
                    {

                   
                   
                   if (!Sounds[i].Equals ("0")&& Uri.IsWellFormedUriString((string)Sounds[i], UriKind.Absolute) == false)
                    {
                        player.SoundLocation = (String) Sounds[i];
                        player.Play();
                    }
                   else if (!Sounds[i].Equals("0") && Uri.IsWellFormedUriString((string)Sounds[i], UriKind.Absolute) == true)
                    {
                        System.Diagnostics.Process.Start((string)Sounds[i]);
                    }
                    else
                    {
                        player.SoundLocation = @"C:Madeon - Pop Culture (live mashup).wav";//default sound
                        player.Play();
                    }
                    

                   
                    AlarmRemove(Alarm);
                    button2.Visible = true;
                    }
                

            }
        
        }

        
        
        public void AlarmRemove( DateTime Alarm)
        {
            
            dataPopulate.DeleteCommand = new SqlCommand("DELETE FROM tbluserAlarms WHERE ALARMTIME=@ALARMTIME", dataConnect);

            for (int x = 0; x < Alarms.Count; x++)
            {
                DateTime AlarmCheck = (DateTime)Alarms[x];

                if (Alarm.Hour == AlarmCheck.Hour && Alarm.Minute == AlarmCheck.Minute && Alarm.Second == AlarmCheck.Second)
                {

                    dataPopulate.DeleteCommand.Parameters.Add("@ALARMTIME", SqlDbType.VarChar).Value = AlarmCheck;
                    dataConnect.Open();
                    dataPopulate.DeleteCommand.ExecuteNonQuery();
                    dataConnect.Close();
                    Sounds.RemoveAt(x);
                    Alarms.RemoveAt(x);

                    x--;

                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataPopulate.InsertCommand = new SqlCommand("INSERT INTO tbluserAlarms VALUES (@ALARMSOUND, @ALARMTIME)", dataConnect);
            dataPopulate.InsertCommand.Parameters.Add("@ALARMSOUND", SqlDbType.VarChar).Value = Sounds[Sounds.Count - 1];
            dataPopulate.InsertCommand.Parameters.Add("@ALARMTIME", SqlDbType.DateTime).Value = dateTimePicker1.Value;
          
            Alarms.Add(dateTimePicker1.Value);
            groupBox1.Visible = false;
            dataConnect.Open();
            dataPopulate.InsertCommand.ExecuteNonQuery();
            dataConnect.Close();
            
        }

      
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                
                player.Stop();
                button2.Visible = false;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.LightCoral, ButtonBorderStyle.Solid);
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.groupBox1.ClientRectangle, Color.LightCoral, ButtonBorderStyle.Solid);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Audio Files (.wav)|*.wav";
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                Sounds.RemoveAt(Sounds.Count - 1);//removes added 0 on first button press when custom sound added 
                filePath = openFileDialog1.FileName;
                Sounds.Add(filePath);
                Console.WriteLine(filePath);
            }
            else
            {

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel3.ClientRectangle, Color.LightCoral, ButtonBorderStyle.Solid);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (Uri.IsWellFormedUriString(textBox1.Text, UriKind.Absolute) == true)
            {
                Sounds.RemoveAt(Sounds.Count - 1);//removes added 0 on first button press when custom sound added 
                Sounds.Add(textBox1.Text);
                panel3.Visible = false;
            }
           else if (Uri.IsWellFormedUriString(textBox1.Text, UriKind.Absolute) == false)
            {
                panel3.Visible = false;
            }


        }
    }
}
