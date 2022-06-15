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
    public partial class Form3 : Form
    {
        //массив случайных пар:
        int[] para;

        //массив самих 16 картинок
        int[] pic;

        //массив открытых элементов
        int[] open;
        int open_elem;

        PictureBox[] picbox;
        public Form3()
        {
            InitializeComponent();
            sp = new SoundPlayer(@"4d2c4b287eb3e47.wav");
            sp.PlayLooping();//зацикливаем музыку
            para = new int[8];
            pic = new int[16];
            open = new int[2];
            open_elem = 0;
            picbox = new PictureBox[16];
            picbox[0] = pictureBox2;
            picbox[1] = pictureBox3;
            picbox[2] = pictureBox4;
            picbox[3] = pictureBox5;
            picbox[4] = pictureBox6;
            picbox[5] = pictureBox7; 
            picbox[6] = pictureBox8;
            picbox[7] = pictureBox9;
            picbox[8] = pictureBox10;
            picbox[9] = pictureBox11;
            picbox[10] = pictureBox12;
            picbox[11] = pictureBox13;
            picbox[12] = pictureBox14;
            picbox[13] = pictureBox15;
            picbox[14] = pictureBox16;
            picbox[15] = pictureBox17;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            hide();
            button19_Click(null, null);/*автоматическая генерация картинок*/
            button1.Enabled = false;/*т.к. выше нажимается кнопка перемещивания, после которой доступной становится кнопка начать(т.е. при загрузке формы кнопка начать сразу доступна)*/
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
        SoundPlayer sp;
        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
            sp.Stop();
            SoundPlayer sp1 = new SoundPlayer(@"48bb90af8e1e401.wav");
            sp1.PlayLooping();//зацикливаем музыку
        }
        int timer = 0;
        //пауза
        private void button20_Click(object sender, EventArgs e)
        {
            
            if (timer == 0)
            {
                timer1.Start();
                timer++;
                button19.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;
                pictureBox13.Enabled = true;
                pictureBox14.Enabled = true;
                pictureBox15.Enabled = true;
                pictureBox16.Enabled = true;
                pictureBox17.Enabled = true;
            }
            else
            {
                timer1.Stop();
                timer--;
                button19.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
                pictureBox10.Enabled = false;
                pictureBox11.Enabled = false;
                pictureBox12.Enabled = false;
                pictureBox13.Enabled = false;
                pictureBox14.Enabled = false;
                pictureBox15.Enabled = false;
                pictureBox16.Enabled = false;
                pictureBox17.Enabled = false;
            }
        }
        int m = 0;
        int s = 30;
        private void timer1_Tick(object sender, EventArgs e)
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
                    hide();
                    button19_Click(null, null);
                    m = 0;
                    s = 30;
                    label1.Text = Convert.ToString(m);
                    label2.Text = Convert.ToString(s);
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    button1.Enabled = false;
                    button19.Enabled = true;
                    button17.Enabled = true;
                    button20.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;
                    pictureBox9.Enabled = false;
                    pictureBox10.Enabled = false;
                    pictureBox11.Enabled = false;
                    pictureBox12.Enabled = false;
                    pictureBox13.Enabled = false;
                    pictureBox14.Enabled = false;
                    pictureBox15.Enabled = false;
                    pictureBox16.Enabled = false;
                    pictureBox17.Enabled = false;

                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = true;
                    pictureBox11.Visible = true;
                    pictureBox12.Visible = true;
                    pictureBox13.Visible = true;
                    pictureBox14.Visible = true;
                    pictureBox15.Visible = true;
                    pictureBox16.Visible = true;
                    pictureBox17.Visible = true;
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
            if ((m == 0 && s > 0) || (m > 0 && s == 0))
            {
                if (pictureBox2.Visible == false && pictureBox3.Visible == false && pictureBox4.Visible == false && pictureBox5.Visible == false &&
                pictureBox6.Visible == false && pictureBox7.Visible == false && pictureBox8.Visible == false && pictureBox9.Visible == false &&
                pictureBox10.Visible == false && pictureBox11.Visible == false && pictureBox12.Visible == false && pictureBox13.Visible == false &&
                pictureBox14.Visible == false && pictureBox15.Visible == false && pictureBox16.Visible == false && pictureBox17.Visible == false)
                {
                    timer1.Stop();
                    if (m ==0 && s>=18)
                    {
                        DialogResult res = MessageBox.Show("Отлично! Вы прошли игру за " + (s+1) + " секунд. Вы занимаете почетное 1 место! Начать заново?", "Поздравление!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        if (res == DialogResult.Yes)
                        {
                            hide();
                            button19_Click(null, null);
                            m = 0;
                            s = 30;
                            label1.Text = Convert.ToString(m);
                            label2.Text = Convert.ToString(s);
                            label1.ForeColor = Color.Black;
                            label2.ForeColor = Color.Black;
                            button1.Enabled = false;
                            button19.Enabled = true;
                            button20.Enabled = false;
                            button17.Enabled = true;
                            pictureBox2.Enabled = false;
                            pictureBox3.Enabled = false;
                            pictureBox4.Enabled = false;
                            pictureBox5.Enabled = false;
                            pictureBox6.Enabled = false;
                            pictureBox7.Enabled = false;
                            pictureBox8.Enabled = false;
                            pictureBox9.Enabled = false;
                            pictureBox10.Enabled = false;
                            pictureBox11.Enabled = false;
                            pictureBox12.Enabled = false;
                            pictureBox13.Enabled = false;
                            pictureBox14.Enabled = false;
                            pictureBox15.Enabled = false;
                            pictureBox16.Enabled = false;
                            pictureBox17.Enabled = false;

                            pictureBox2.Visible = true;
                            pictureBox3.Visible = true;
                            pictureBox4.Visible = true;
                            pictureBox5.Visible = true;
                            pictureBox6.Visible = true;
                            pictureBox7.Visible = true;
                            pictureBox8.Visible = true;
                            pictureBox9.Visible = true;
                            pictureBox10.Visible = true;
                            pictureBox11.Visible = true;
                            pictureBox12.Visible = true;
                            pictureBox13.Visible = true;
                            pictureBox14.Visible = true;
                            pictureBox15.Visible = true;
                            pictureBox16.Visible = true;
                            pictureBox17.Visible = true;

                        }
                        else
                        {
                            this.Close();
                            sp.Stop();
                            SoundPlayer sp1 = new SoundPlayer(@"48bb90af8e1e401.wav");
                            sp1.PlayLooping();//зацикливаем музыку
                        }
                    }
                    if (m == 0 && s >= 10 && s<18)
                    {
                        DialogResult res = MessageBox.Show("Хорошо! Вы прошли игру за " + (s+1) + " секунд. Вы получаете серебро - 2 место! Начать заново?", "Поздравление!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        if (res == DialogResult.Yes)
                        {
                            hide();
                            button19_Click(null, null);
                            m = 0;
                            s = 30;
                            label1.Text = Convert.ToString(m);
                            label2.Text = Convert.ToString(s);
                            label1.ForeColor = Color.Black;
                            label2.ForeColor = Color.Black;
                            button1.Enabled = false;
                            button19.Enabled = true;
                            button20.Enabled = false;
                            button17.Enabled = true;
                            pictureBox2.Enabled = false;
                            pictureBox3.Enabled = false;
                            pictureBox4.Enabled = false;
                            pictureBox5.Enabled = false;
                            pictureBox6.Enabled = false;
                            pictureBox7.Enabled = false;
                            pictureBox8.Enabled = false;
                            pictureBox9.Enabled = false;
                            pictureBox10.Enabled = false;
                            pictureBox11.Enabled = false;
                            pictureBox12.Enabled = false;
                            pictureBox13.Enabled = false;
                            pictureBox14.Enabled = false;
                            pictureBox15.Enabled = false;
                            pictureBox16.Enabled = false;
                            pictureBox17.Enabled = false;

                            pictureBox2.Visible = true;
                            pictureBox3.Visible = true;
                            pictureBox4.Visible = true;
                            pictureBox5.Visible = true;
                            pictureBox6.Visible = true;
                            pictureBox7.Visible = true;
                            pictureBox8.Visible = true;
                            pictureBox9.Visible = true;
                            pictureBox10.Visible = true;
                            pictureBox11.Visible = true;
                            pictureBox12.Visible = true;
                            pictureBox13.Visible = true;
                            pictureBox14.Visible = true;
                            pictureBox15.Visible = true;
                            pictureBox16.Visible = true;
                            pictureBox17.Visible = true;

                        }
                        else
                        {
                            this.Close();
                            sp.Stop();
                            SoundPlayer sp1 = new SoundPlayer(@"48bb90af8e1e401.wav");
                            sp1.PlayLooping();//зацикливаем музыку
                        }

                    }
                    if (m == 0 && s >= 1 && s<10)
                    {
                        DialogResult res = MessageBox.Show("Неплохо! Вы прошли игру за " + (s+1) + " секунд. Вы получаете бронзу - 3 место! Начать заново?", "Поздравление!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        if (res == DialogResult.Yes)
                        {
                            hide();
                            button19_Click(null, null);
                            m = 0;
                            s = 30;
                            label1.Text = Convert.ToString(m);
                            label2.Text = Convert.ToString(s);
                            label1.ForeColor = Color.Black;
                            label2.ForeColor = Color.Black;
                            button1.Enabled = false;
                            button19.Enabled = true;
                            button17.Enabled = true;
                            button20.Enabled = false;
                            pictureBox2.Enabled = false;
                            pictureBox3.Enabled = false;
                            pictureBox4.Enabled = false;
                            pictureBox5.Enabled = false;
                            pictureBox6.Enabled = false;
                            pictureBox7.Enabled = false;
                            pictureBox8.Enabled = false;
                            pictureBox9.Enabled = false;
                            pictureBox10.Enabled = false;
                            pictureBox11.Enabled = false;
                            pictureBox12.Enabled = false;
                            pictureBox13.Enabled = false;
                            pictureBox14.Enabled = false;
                            pictureBox15.Enabled = false;
                            pictureBox16.Enabled = false;
                            pictureBox17.Enabled = false;

                            pictureBox2.Visible = true;
                            pictureBox3.Visible = true;
                            pictureBox4.Visible = true;
                            pictureBox5.Visible = true;
                            pictureBox6.Visible = true;
                            pictureBox7.Visible = true;
                            pictureBox8.Visible = true;
                            pictureBox9.Visible = true;
                            pictureBox10.Visible = true;
                            pictureBox11.Visible = true;
                            pictureBox12.Visible = true;
                            pictureBox13.Visible = true;
                            pictureBox14.Visible = true;
                            pictureBox15.Visible = true;
                            pictureBox16.Visible = true;
                            pictureBox17.Visible = true;

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
        
        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        //перемешать
        Random rnd = new Random();
        private void button19_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            open_elem = 0;
            //создаём случайные пары картинок
            for (int i = 0; i < 8; i++)
            {
                para[i] = rnd.Next(8);
            }
            for (int i = 0; i < 16; i++)
            {
                pic[i] = -1; /*-1 - ячейка свободна*/
            }
            int ispolz = 0;
            while (ispolz != 8)
            {
                int n1 = rnd.Next(16); /*первое место из пары*/
                int n2 = rnd.Next(16); /*второе место из пары*/
                if (n1 == n2) continue; /*continue-оператор, который принудительно запускает цикл заново*/
                if (pic[n1] == -1 && pic[n2] == -1)
                {
                    pic[n1] = pic[n2] = para[ispolz];
                    ispolz++;/*количество использованных пар увеличивается*/
                }
            }
            hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int index = Convert.ToInt32(p.Tag);
            //если мы нажимаем на одну и ту же картинку два раза, то она совпадает со своим же индексом (тэгом), и тогда мы выходим из метода (т.е. картинка не исчезает)
            if (open_elem == 1)
            {
                if (open[0] == index)
                {
                    return;
                }
            }

            if (open_elem == 2)
            {
                hide();
                open_elem = 0;
            }
            open[open_elem] = index;
            open_elem++;
            if (open_elem == 2)
            {
                if (pic[open[0]] == pic[open[1]])
                {
                    //прячем пикбоксы, которые открыл пользователь
                    picbox[open[0]].Visible = false;
                    picbox[open[1]].Visible = false;
                    open_elem = 0;
                    hide();
                }
            }
            p.BackgroundImage = imageList1.Images[pic[index]];
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        public void hide() 
        {
            pictureBox2.BackgroundImage = imageList1.Images[8];
            pictureBox3.BackgroundImage = imageList1.Images[8];
            pictureBox4.BackgroundImage = imageList1.Images[8];
            pictureBox5.BackgroundImage = imageList1.Images[8];
            pictureBox6.BackgroundImage = imageList1.Images[8];
            pictureBox7.BackgroundImage = imageList1.Images[8];
            pictureBox8.BackgroundImage = imageList1.Images[8];
            pictureBox9.BackgroundImage = imageList1.Images[8];
            pictureBox10.BackgroundImage = imageList1.Images[8];
            pictureBox11.BackgroundImage = imageList1.Images[8];
            pictureBox12.BackgroundImage = imageList1.Images[8];
            pictureBox13.BackgroundImage = imageList1.Images[8];
            pictureBox14.BackgroundImage = imageList1.Images[8];
            pictureBox15.BackgroundImage = imageList1.Images[8];
            pictureBox16.BackgroundImage = imageList1.Images[8];
            pictureBox17.BackgroundImage = imageList1.Images[8];
        }
       
        //начать
        private void button1_Click(object sender, EventArgs e)
        {
            button19.Enabled = false;
            button20.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            pictureBox13.Enabled = true;
            pictureBox14.Enabled = true;
            pictureBox15.Enabled = true;
            pictureBox16.Enabled = true;
            pictureBox17.Enabled = true;
            timer1.Start();
            timer++;
        }

        private void Form3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
