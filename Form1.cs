using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final1
{
    public partial class Form1 : Form
    {
        private Student sBrandon;
        private Student sClare;
        private Student sTommy;
        private Student sJonathan;
        private Student sCurrent;
        public Form1() { 
        
        
            InitializeComponent();
            sBrandon = new Student("Brandon", 51, pictureBox1, "faculty", "MIS");
            sClare = new Student("CLare ", 58, pictureBox2, "Graduate", "IT");
            sTommy = new Student("Tommy", 12, pictureBox3, "7th grade", "NA");
            sJonathan = new Student("JOnathan", 10, pictureBox4, "5th grade", "NA");
        }
        public void HidePhotos()
        {
            
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();


        }
        public void UpdateForm()
        {
            HidePhotos();
            textBox2.Text = sCurrent.Name;
            textBox3.Text = sCurrent.Age.ToString();
            textBox4.Text = sCurrent.Year;
            textBox5.Text = sCurrent.Major;
            sCurrent.photo.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sCurrent = sBrandon;
            UpdateForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sCurrent = sTommy;
            UpdateForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sCurrent = sClare;
            UpdateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sCurrent = sJonathan;
            UpdateForm();
        }
    }

        
    }

