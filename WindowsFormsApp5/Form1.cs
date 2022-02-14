using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string evvelki;
        int kristal = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (button_karandas.Text == "Yadda saxla")
            {
                button_imtina.Visible = false;
                button_karandas.Text = "karandas";
                return;
            }
            if (radioButton1.Checked==true || radioButton2.Checked == true)
            {
                evvelki = textBox2.Text;
                button_karandas.Text = "Yadda saxla";
                textBox2.Enabled = true;
                button_imtina.Visible = true;
            }
         
     

        }

        private void button_imtina_Click(object sender, EventArgs e)
        {

            textBox2.Text = evvelki;
            button_karandas.Text = "karandas";
            button_imtina.Visible = false;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = comboBox2.SelectedItem.ToString();
            comboBox2.Items.Add(comboBox2.Text);
            comboBox2.Items.Remove(comboBox2.SelectedItem);
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        
                button1.BackColor = Color.Red;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;



            button18.BackColor = Color.White;
            button27.BackColor = Color.White;

        }
        private void button18_Click(object sender, EventArgs e)
        {
      
                button18.BackColor = Color.Yellow;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;

     

   
            button27.BackColor = Color.White;
            button1.BackColor = Color.White;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox2.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox2.Enabled = true;
            }

        }

        private void button27_Click(object sender, EventArgs e)
        {
    
                button27.BackColor = Color.Green;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;

                
            
            button18.BackColor = Color.White;
            button1.BackColor = Color.White;



        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (kristal < 5)
            {
                button28.BackColor = Color.Blue;
            }
            kristal++;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (kristal < 5)
            {
                button28.BackColor = Color.Blue;
                button29.BackColor = Color.Blue;
            }
            kristal+=2;

        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (kristal < 5)
            {
                button28.BackColor = Color.Blue;
                button29.BackColor = Color.Blue;
                button30.BackColor = Color.Blue;
            }
            kristal += 3;

        }

        private void button31_Click(object sender, EventArgs e)
        {
            button28.BackColor = Color.White;
            button29.BackColor = Color.White;
            button30.BackColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

 
    }
}
