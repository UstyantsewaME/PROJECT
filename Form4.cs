using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace проект_по_проге
{
    public partial class Form4 : Form
    {
        Button[] B;
        SoundPlayer sp;
        public Form4()
        {
            InitializeComponent();
            //создаём фоновую музыку с помощью волнового файла формата wav
            sp = new SoundPlayer(@"4d2c4b287eb3e47.wav");
            sp.PlayLooping();//зацикливаем музыку
            B = new Button[36];
            B[0] = button1;
            B[1] = button2;
            B[2] = button3;
            B[3] = button4;
            B[4] = button5;
            B[5] = button6;
            B[6] = button7;
            B[7] = button8;
            B[8] = button9;
            B[9] = button10;
            B[10] = button11;
            B[11] = button12;
            B[12] = button13;
            B[13] = button14;
            B[14] = button15;
            B[15] = button16;
            B[16] = button17;
            B[17] = button18;
            B[18] = button19;
            B[19] = button20;
            B[20] = button21;
            B[21] = button22;
            B[22] = button23;
            B[23] = button24;
            B[24] = button25;
            B[25] = button26;
            B[26] = button27;
            B[27] = button28;
            B[28] = button29;
            B[29] = button30;
            B[30] = button31;
            B[31] = button32;
            B[32] = button33;
            B[33] = button34;
            B[34] = button35;
            B[35] = button36;

           
            for (int i = 0; i < 36; i++)
            {
                B[i].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                B[i].BackColor = Color.FromArgb(128, 255, 255);
                B[i].Enabled = false;
            }
        }

        private void Судоку_Load(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("С сутью и правилами Вы можете ознакомиться, предварительно наведя курсор в главном меню на интересующую Вас игру (нажмите ОК, если Вы знакомы с правилами игры).", "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.OK)
            {

            }
            else
            {
                sp.Stop();
                SoundPlayer sp1 = new SoundPlayer(@"48bb90af8e1e401.wav");
                sp1.PlayLooping();//зацикливаем музыку
                this.Close();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        { 

        }
        
        private void button37_Click(object sender, EventArgs e)
        {
            
        }
        private void button38_Click(object sender, EventArgs e)
        {
            this.Close();
            sp.Stop();
            SoundPlayer sp1 = new SoundPlayer(@"48bb90af8e1e401.wav");
            sp1.PlayLooping();//зацикливаем музыку
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int m = 2;
        int s = 30;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(m);
            label2.Text = Convert.ToString(s);
            s = s - 1;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
            if (m == 0 && s == 0)
            {
                timer1.Stop();
                DialogResult res = MessageBox.Show("Вы проиграли. Начать заново?", "Время вышло!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (res == DialogResult.Yes)
                {
                    m = 2;
                    s = 30;
                    label1.Text = Convert.ToString(m);
                    label2.Text = Convert.ToString(s);
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    index = 0;
                    for (int i = 0; i < 36; i++)
                    {
                        B[i].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                        B[i].BackColor = Color.FromArgb(128, 255, 255);
                        B[i].Enabled = false;
                    }
                    button40.Enabled = true;
                    button37.Enabled = false;
                    button39.Enabled = false;
                }
                else
                {
                    this.Close();
                    sp.Stop();
                    SoundPlayer sp1 = new SoundPlayer(@"48bb90af8e1e401.wav");
                    sp1.PlayLooping();//зацикливаем музыку
                }

            }
            if (m == 0 && s == 9)
            {
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
            }
            if ((m >= 0 && s > 0) || (m > 0 && s == 0))
            {
                if (finish==36)
                {
                    timer1.Stop();
                    if(m>=1 && s>=30)
                    {
                        DialogResult res = MessageBox.Show("Отлично! Вы прошли игру за " + m + " минут и " + (s + 1) + " секунд. Вы занимаете почетное 1 место! Начать заново?", "Поздравление!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        if (res == DialogResult.Yes)
                        {
                            m = 2;
                            s = 30;
                            label1.Text = Convert.ToString(m);
                            label2.Text = Convert.ToString(s);
                            label1.ForeColor = Color.Black;
                            label2.ForeColor = Color.Black;
                            index = 0;
                            for (int i = 0; i < 36; i++)
                            {
                                B[i].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                                B[i].BackColor = Color.FromArgb(128, 255, 255);
                                B[i].Enabled = false;
                            }
                            button40.Enabled = true;
                            button37.Enabled = false;
                            button39.Enabled = false;
                        }
                        else
                        {
                            this.Close();
                            sp.Stop();
                            SoundPlayer sp1 = new SoundPlayer(@"48bb90af8e1e401.wav");
                            sp1.PlayLooping();//зацикливаем музыку
                        }
                    }
                    if (m ==1 && s<30)
                    {
                        DialogResult res = MessageBox.Show("Хорошо! Вы прошли игру за " + m + " минут и " + (s + 1) + " секунд. Вы получаете серебро - 2 место! Начать заново?", "Поздравление!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        if (res == DialogResult.Yes)
                        {
                            m = 2;
                            s = 30;
                            label1.Text = Convert.ToString(m);
                            label2.Text = Convert.ToString(s);
                            label1.ForeColor = Color.Black;
                            label2.ForeColor = Color.Black;
                            index = 0;
                            for (int i = 0; i < 36; i++)
                            {
                                B[i].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                                B[i].BackColor = Color.FromArgb(128, 255, 255);
                                B[i].Enabled =false;
                            }
                            button40.Enabled = true;
                            button37.Enabled = false;
                            button39.Enabled = false;
                        }
                        else
                        {
                            this.Close();
                            sp.Stop();
                            SoundPlayer sp1 = new SoundPlayer(@"48bb90af8e1e401.wav");
                            sp1.PlayLooping();//зацикливаем музыку
                        }
                    }
                    if (m==0&&s<=59)
                    {
                        DialogResult res = MessageBox.Show("Неплохо! Вы прошли игру за " + m + " минут и " + (s + 1) + " секунд. Вы получаете бронзу - 3 место! Начать заново?", "Поздравление!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        if (res == DialogResult.Yes)
                        {
                            m = 2;
                            s = 30;
                            label1.Text = Convert.ToString(m);
                            label2.Text = Convert.ToString(s);
                            label1.ForeColor = Color.Black;
                            label2.ForeColor = Color.Black;
                            index = 0;
                            for (int i = 0; i < 36; i++)
                            {
                                B[i].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                                B[i].BackColor = Color.FromArgb(128, 255, 255);
                                B[i].Enabled = false;
                            }
                            button40.Enabled = true;
                            button37.Enabled = false;
                            button39.Enabled = false;
                        }
                        else
                        {
                            this.Close();
                            sp.Stop();
                            SoundPlayer sp1 = new SoundPlayer(@"48bb90af8e1e401.wav");
                            sp1.PlayLooping();//зацикливаем музыку
                        }
                    }
                }
            }
        }
        int finish;
        //начать
        private void button39_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 36; i++)
            {
                B[i].Enabled = true;
            }
            timer1.Start();
            timer++;
            button40.Enabled = false;
            button37.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Text = "O";
            finish = 0;
        }
        //перемешать
        Random rnd = new Random();
        private void button40_Click(object sender, EventArgs e)
        {
            button39.Enabled = true;
            this.BackColor = Color.FromArgb(rnd.Next(100, 255), rnd.Next(100, 255), rnd.Next(100, 255));
            textBox1.BackColor = Color.FromArgb(rnd.Next(100, 255), rnd.Next(100, 255), rnd.Next(100, 255));
            List<string> listofletter = new List<string>
            {
            "O","n","H","F","J","l.","x",
            "I","i","z","P","y","M","v",
            "G","j","q","Q","E","t","s",
            "u","w","C","k","A","L","K","m",
            "N","r","D","o","R","B","p"
            };
            for (int i=0;i<36;i++)
            {
                B[i].BackColor = Color.FromArgb(rnd.Next(100, 255), rnd.Next(100, 255), rnd.Next(100, 255));
                if (listofletter.Count > 0) /*свойство Count отвечает за кол-во элементов внутри нашего листа*/
                {
                    int fIndex = rnd.Next(0, listofletter.Count);
                    B[i].Text = listofletter[fIndex];
                    listofletter.RemoveAt(fIndex);
                }
            }
        }
        List<string> listofletter2 = new List<string> /*создаём лист для условия совпадения текста на подсказке и кнопке*/
        {
            "O","n","H","F","J","l.","x",
            "I","i","z","P","y","M","v",
            "G","j","q","Q","E","t","s",
            "u","w","C","k","A","L","K","m",
            "N","r","D","o","R","B","p", " "
        };
        int index=0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (button26.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (button27.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (button28.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (button29.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (button30.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (button31.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (button32.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (button33.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (button34.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (button35.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (button36.Text == textBox1.Text)
            {
                index++;
                textBox1.Text = listofletter2[index];
                finish++;
            }
        }
        int timer = 0;
        //пауза
        private void button37_Click_1(object sender, EventArgs e)
        {
            button40.Enabled = false;
            if (timer == 0)
            {
                timer1.Start();
                timer++;
                button40.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;
                button24.Enabled = true;
                button25.Enabled = true;
                button26.Enabled = true;
                button27.Enabled = true;
                button28.Enabled = true;
                button29.Enabled = true;
                button30.Enabled = true;
                button31.Enabled = true;
                button32.Enabled = true;
                button33.Enabled = true;
                button34.Enabled = true;
                button35.Enabled = true;
                button36.Enabled = true;
            }
            else
            {
                timer1.Stop();
                timer--;
                button40.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;
                button25.Enabled = false;
                button26.Enabled = false;
                button27.Enabled = false;
                button28.Enabled = false;
                button29.Enabled = false;
                button30.Enabled = false;
                button31.Enabled = false;
                button32.Enabled = false;
                button33.Enabled = false;
                button34.Enabled = false;
                button35.Enabled = false;
                button36.Enabled = false;
            }
        }
    }
}
