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
                button_karandas.BackgroundImage = Image.FromFile(@"C:\Users\Rzay_ri48\source\repos\WindowsFormsApp5\WindowsFormsApp5\Resources\185045_pen_icon.png");
                button_karandas.Text = null;
                return;
            }
            if (radioButton1.Checked==true || radioButton2.Checked == true)
            {
                button_karandas.BackgroundImage = null;
                evvelki = textBox2.Text;
                
                button_karandas.Text = "Yadda saxla";
                textBox2.Enabled = true;
                button_imtina.Visible = true;
            }
         
     

        }

        private void button_imtina_Click(object sender, EventArgs e)
        {

            textBox2.Text = evvelki;
            button_karandas.Text = null;
            button_karandas.BackgroundImage = Image.FromFile(@"C:\Users\Rzay_ri48\source\repos\WindowsFormsApp5\WindowsFormsApp5\Resources\185045_pen_icon.png");
            button_imtina.Visible = false;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
    
            
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
            button28.Enabled = false;
            
            button29.Enabled = false;
            button30.Enabled = false;
            button31.Enabled = false;
            button28.BackColor = Color.White;
            button29.BackColor = Color.White;
            button30.BackColor = Color.White;
    

            button18.BackColor = Color.White;
            button_yasil1.BackColor = Color.White;

        }
        private void button18_Click(object sender, EventArgs e)
        {
            

                button18.BackColor = Color.Yellow;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                button28.Enabled = true;
                button29.Enabled = true;
                button30.Enabled = true;
                button31.Enabled = true;

            




            button_yasil1.BackColor = Color.White;
            button1.BackColor = Color.White;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
     

        }

        private void button27_Click(object sender, EventArgs e)
        {
           
                button_yasil1.BackColor = Color.Green;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                button28.Enabled = true;
                button29.Enabled = true;
                button30.Enabled = true;
                button31.Enabled = true;
            






            button18.BackColor = Color.White;
            button1.BackColor = Color.White;



        }

      

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
           
                button_yasil2.BackColor = Color.Green;
                comboBox5.Enabled = true;
                comboBox4.Enabled = true;
                button33.Enabled = true;
                button34.Enabled = true;
                button35.Enabled = true;
                button32.Enabled = true;
            
           
      


            button12.BackColor = Color.White;
            button7.BackColor = Color.White;
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
                button12.BackColor = Color.Yellow;
                comboBox5.Enabled = true;
                comboBox4.Enabled = true;
                button33.Enabled = true;
                button34.Enabled = true;
                button35.Enabled = true;
                button32.Enabled = true;
            
          
 



            button_yasil2.BackColor = Color.White;
            button7.BackColor = Color.White;
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            
                button7.BackColor = Color.Red;
            
 
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            button33.Enabled = false;
            button34.Enabled = false;
            button35.Enabled = false;
            button32.Enabled = false;
            button33.BackColor = Color.White;
            button34.BackColor = Color.White;
            button35.BackColor = Color.White;
            button32.BackColor = Color.White;


            button12.BackColor = Color.White;
            button_yasil2.BackColor = Color.White;
        }

        

        private void button29_Click(object sender, EventArgs e)
        {
            if (button28.BackColor == Color.Blue && kristal + 1 <= 5)
            {
                button29.BackColor = Color.Blue;
                kristal += 1;
            }
            else if (kristal + 2 <= 5)
            {
             
                button28.BackColor = Color.Blue;
                button29.BackColor = Color.Blue;
                kristal += 2;
            }


        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (kristal + 1 <= 5 && button29.BackColor == Color.Blue)
            {
                button30.BackColor = Color.Blue;
                kristal += 1;
            }
            else if (kristal + 2 <= 5 && button28.BackColor == Color.Blue)
            {
                button29.BackColor = Color.Blue;
                button30.BackColor = Color.Blue;
                kristal += 2;

            }
            else if (kristal + 3 <= 5 )
            {
                button28.BackColor = Color.Blue;
                button29.BackColor = Color.Blue;
                button30.BackColor = Color.Blue;
                kristal += 3;
            }
      

        }

        private void button31_Click(object sender, EventArgs e)
        {

            if (button28.BackColor == Color.Blue )
            {
                button28.BackColor = Color.White;
                kristal -= 1;
            }
            if ( button29.BackColor == Color.Blue )
            {
                button29.BackColor = Color.White;
                kristal -= 1;
            }
            if ( button30.BackColor == Color.Blue)
            {
                button30.BackColor = Color.White;
                kristal -= 1;
            }

        }
        private void button33_Click(object sender, EventArgs e)
        {
            if (kristal + 1 <= 5)
            {
                button33.BackColor = Color.Blue;
                kristal++;
            }
        
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (button33.BackColor == Color.Blue && kristal + 1 <= 5)
            {
                button34.BackColor = Color.Blue;
                kristal += 1;
            }
            else if (kristal + 2 <= 5)
            {
                button33.BackColor = Color.Blue;
                button34.BackColor = Color.Blue;
                kristal += 2;
            }
         
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (kristal + 1 <= 5 && button34.BackColor == Color.Blue)
            {
                button35.BackColor = Color.Blue;
                kristal += 1;
            }
            else if (kristal + 2 <= 5 && button33.BackColor == Color.Blue)
            {
                button34.BackColor = Color.Blue;
                button35.BackColor = Color.Blue;
                kristal += 2;

            }
            else if (kristal + 3 <= 5 )
            {
                button33.BackColor = Color.Blue;
                button34.BackColor = Color.Blue;
                button35.BackColor = Color.Blue;
                kristal += 3;
            }

        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (button33.BackColor == Color.Blue)
            {
                button33.BackColor = Color.White;
                kristal -= 1;
            }
            if (button34.BackColor == Color.Blue)
            {
                button34.BackColor = Color.White;
                kristal -= 1;
            }
            if (button35.BackColor == Color.Blue)
            {
                button35.BackColor = Color.White;
                kristal -= 1;
            }
           
            


        }

        private void button22_Click(object sender, EventArgs e)
        {
            
                button_yasil3.BackColor = Color.Green;
                comboBox7.Enabled = true;
                comboBox6.Enabled = true;
                button37.Enabled = true;
                button38.Enabled = true;
                button39.Enabled = true;
                button36.Enabled = true;

            



            button13.BackColor = Color.White;
            button6.BackColor = Color.White;
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
                button13.BackColor = Color.Yellow;
                comboBox7.Enabled = true;
                comboBox6.Enabled = true;
                button37.Enabled = true;
                button38.Enabled = true;
                button39.Enabled = true;
                button36.Enabled = true;
            

            



            button_yasil3.BackColor = Color.White;
            button6.BackColor = Color.White;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
                button6.BackColor = Color.Red;
            

            comboBox7.Enabled = false;
            comboBox6.Enabled = false;
            button37.BackColor = Color.White;
            button38.BackColor = Color.White;
            button39.BackColor = Color.White;
            button36.BackColor = Color.White;
            button37.Enabled = false;
            button38.Enabled = false;
            button39.Enabled = false;
            button36.Enabled = false;

            button13.BackColor = Color.White;
            button_yasil3.BackColor = Color.White;
        }
        private void button28_Click(object sender, EventArgs e)
        {
            if (kristal + 1 <= 5)
            {
                button28.BackColor = Color.Blue;
                kristal++;
            }

        }
        private void button_yasil4_Click(object sender, EventArgs e)
        {

            
                button_yasil4.BackColor = Color.Green;
                comboBox9.Enabled = true;
                comboBox8.Enabled = true;
                button40.Enabled = true;
                button41.Enabled = true;
                button42.Enabled = true;
                button43.Enabled = true;
            

           


            button14.BackColor = Color.White;
            button5.BackColor = Color.White;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
                button14.BackColor = Color.Yellow;
                comboBox9.Enabled = true;
                comboBox8.Enabled = true;
                button40.Enabled = true;
                button41.Enabled = true;
                button42.Enabled = true;
                button43.Enabled = true;

            




            button_yasil4.BackColor = Color.White;
            button5.BackColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
                button5.BackColor = Color.Red;
            

            comboBox9.Enabled = false;
            comboBox8.Enabled = false;
            button40.BackColor = Color.White;
            button41.BackColor = Color.White;
            button42.BackColor = Color.White;
            button43.BackColor = Color.White;
            button40.Enabled = false;
            button41.Enabled = false;
            button42.Enabled = false;
            button43.Enabled = false;

            button14.BackColor = Color.White;
            button_yasil4.BackColor = Color.White;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (kristal + 1 <= 5)
            {
                button37.BackColor = Color.Blue;
                kristal++;
            }

        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (button37.BackColor == Color.Blue && kristal + 1 <= 5)
            {
                button38.BackColor = Color.Blue;
                kristal += 1;
            }
            else if (kristal + 2 <= 5)
            {
                button37.BackColor = Color.Blue;
                button38.BackColor = Color.Blue;
                kristal += 2;

            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (kristal + 1 <= 5 && button38.BackColor == Color.Blue)
            {
                button39.BackColor = Color.Blue;
                kristal += 1;
            }
            else if (kristal + 2 <= 5 && button37.BackColor == Color.Blue)
            {
                button38.BackColor = Color.Blue;
                button39.BackColor = Color.Blue;
                kristal += 2;

            }
            else if (kristal + 3 <= 5)
            {
                button37.BackColor = Color.Blue;
                button38.BackColor = Color.Blue;
                button39.BackColor = Color.Blue;
                kristal += 3;
            }

        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (button37.BackColor == Color.Blue)
            {
                button37.BackColor = Color.White;
                kristal -= 1;
            }
            if (button38.BackColor == Color.Blue)
            {
                button38.BackColor = Color.White;
                kristal -= 1;
            }
            if (button39.BackColor == Color.Blue)
            {
                button39.BackColor = Color.White;
                kristal -= 1;
            }


        }
        private void button41_Click(object sender, EventArgs e)
        {
            if (kristal + 1 <= 5)
            {
                button41.BackColor = Color.Blue;
                kristal++;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (button41.BackColor == Color.Blue && kristal + 1 <= 5)
            {
                button42.BackColor = Color.Blue;
                kristal += 1;
            }
            else if (kristal + 2 <= 5)
            {
                button41.BackColor = Color.Blue;
                button42.BackColor = Color.Blue;
                kristal += 2;

            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (kristal + 1 <= 5 && button42.BackColor == Color.Blue)
            {
                button43.BackColor = Color.Blue;
                kristal += 1;
            }
            else if (kristal + 2 <= 5 && button41.BackColor == Color.Blue)
            {
                button42.BackColor = Color.Blue;
                button43.BackColor = Color.Blue;
                kristal += 2;

            }
            else if (kristal + 3 <= 5)
            {
                button41.BackColor = Color.Blue;
                button43.BackColor = Color.Blue;
                button42.BackColor = Color.Blue;
                kristal += 3;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (button41.BackColor == Color.Blue)
            {
                button41.BackColor = Color.White;
                kristal -= 1;
            }
            if (button42.BackColor == Color.Blue)
            {
                button42.BackColor = Color.White;
                kristal -= 1;
            }
            if (button43.BackColor == Color.Blue)
            {
                button43.BackColor = Color.White;
                kristal -= 1;
            }
        }

        private void button_yasil5_Click(object sender, EventArgs e)
        {
            
                button_yasil5.BackColor = Color.Green;
                comboBox11.Enabled = true;
                comboBox10.Enabled = true;
                button44.Enabled = true;
                button45.Enabled = true;
                button46.Enabled = true;
                button47.Enabled = true;
            

            


            button15.BackColor = Color.White;
            button4.BackColor = Color.White;
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
                button15.BackColor = Color.Yellow;
                comboBox10.Enabled = true;
                comboBox11.Enabled = true;
                button44.Enabled = true;
                button45.Enabled = true;
                button46.Enabled = true;
                button47.Enabled = true;

            




            button_yasil5.BackColor = Color.White;
            button4.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                button4.BackColor = Color.Red;
            

            comboBox10.Enabled = false;
            comboBox11.Enabled = false;
            button44.BackColor = Color.White;
            button45.BackColor = Color.White;
            button46.BackColor = Color.White;
            button47.BackColor = Color.White;
            button44.Enabled = false;
            button45.Enabled = false;
            button46.Enabled = false;
            button47.Enabled = false;

            button15.BackColor = Color.White;
            button_yasil5.BackColor = Color.White;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (kristal + 1 <= 5)
            {
                button45.BackColor = Color.Blue;
                kristal++;
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (button45.BackColor == Color.Blue && kristal + 1 <= 5)
            {
                button46.BackColor = Color.Blue;
                kristal += 1;
            }
            else if (kristal + 2 <= 5)
            {
                button45.BackColor = Color.Blue;
                button46.BackColor = Color.Blue;
                kristal += 2;
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (kristal + 1 <= 5 && button46.BackColor == Color.Blue)
            {
                button47.BackColor = Color.Blue;
                kristal += 1;
            }
            else if (kristal + 2 <= 5 && button45.BackColor == Color.Blue)
            {
                button46.BackColor = Color.Blue;
                button47.BackColor = Color.Blue;
                kristal += 2;

            }
            else if (kristal + 3 <= 5)
            {
                button45.BackColor = Color.Blue;
                button46.BackColor = Color.Blue;
                button47.BackColor = Color.Blue;
                kristal += 3;
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (button45.BackColor == Color.Blue)
            {
                button45.BackColor = Color.White;
                kristal -= 1;
            }
            if (button46.BackColor == Color.Blue)
            {
                button46.BackColor = Color.White;
                kristal -= 1;
            }
            if (button47.BackColor == Color.Blue)
            {
                button47.BackColor = Color.White;
                kristal -= 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.BackColor != Color.White)
            {
                button_yasil4_Click(sender, e);
                button_yasil5_Click(sender, e);
                button27_Click(sender, e);
                button21_Click(sender, e);
                button22_Click(sender, e);
                button2.BackColor = Color.White;
            }
            else
            {

            }


        }
    }
}
