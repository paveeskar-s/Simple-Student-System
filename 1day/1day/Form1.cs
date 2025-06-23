using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1day
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Firstname:"+textBox1.Text+"\n"+"Lastname:"+textBox2.Text+"\n"+"Age:"+num.Value.ToString()+"\n"+"Address:"+textBox4.Text);
            MessageBox.Show($"Firstname:{textBox1.Text}\n Lastname:{ textBox2.Text}\n Age:{num.Value}\n Address:{textBox4.Text}");
        }
        private void btnexit_Click(object sender, EventArgs e)
        {

            DialogResult result = DialogResult = MessageBox.Show("Do you want to Close", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) 
            { 
                 this.Close();  
            
            }
        
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

       
          
    }
    
}
