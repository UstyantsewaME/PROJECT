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
using System.Diagnostics;

namespace проект_по_проге
{

    public partial class Form2 : Form
    {
        Button[] B;
        SoundPlayer sp;
        public Form2()
        {
            InitializeComponent();
            //создаём фоновую музыку с помощью волнового файла формата wav
            sp = new SoundPlayer(@"4d2c4b287eb3e47.wav");
            sp.PlayLooping();//зацикливаем музыку
            B = new Button[16];
            B[0] = button2;
            B[1] = button5;
            B[2] = button6;
            B[3] = button7;
            B[4] = button8;
            B[5] = button9;
            B[6] = button10;
            B[7] = button11;
            B[8] = button12;
            B[9] = button13;
            B[10] = button14;
            B[11] = button15;
            B[12] = button16;
            B[13] = button17;
            B[14] = button18;
            B[15] = button19;
            panel1_Resize(null, null);
        }
        

        private void Form2_Load(object sender, EventArgs e)
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
        
        public void button6_Click(object sender, EventArgs e)
        {
            //создаём событие click, с помощью которого мы узнаем, какую кнопку нажал пользователь
            //преобразуем sender в button для той же самой цели. Затем преобразуем в int, чтобы получить номер кнопки.
            Button position = (Button)sender;
            int n = (int)Convert.ToInt32(position.Tag.ToString());
            //уменьшаем позицию на 1, т.к. изначально Tag был задан с 1
            n--;
            int y = n / 4;
            int x = n - y * 4;
            //создаём кнопки, окружающие нажатую пользователем кнопку
            int verh = y - 1;
            int niz = y + 1;
            int pravo = x + 1;
            int levo = x - 1;
            //получим номер правой кнопки при условии, что она существует только тогда, когда она меньше 4
            if (pravo < 4)
            {
                int nom1 = y * 4 + pravo;
                if (!B[nom1].Visible)
                {
                    B[nom1].Visible = true;
                    B[n].Visible = false;
                    B[nom1].Text = B[n].Text;
                }
            }
            if (levo >= 0)
            {
                int nom2 = y * 4 + levo;
                if (!B[nom2].Visible)
                {
                    B[nom2].Visible = true;
                    B[n].Visible = false;
                    B[nom2].Text = B[n].Text;
                }
            }
            if (verh >= 0)
            {
                int nom3 = verh * 4 + x;
                if (!B[nom3].Visible)
                {
                    B[nom3].Visible = true;
                    B[n].Visible = false;
                    B[nom3].Text = B[n].Text;
                }
            }
            if (niz < 4)
            {
                int nom4 = niz * 4 + x;
                if (!B[nom4].Visible)
                {
                    B[nom4].Visible = true;
                    B[n].Visible = false;
                    B[nom4].Text = B[n].Text;
                }
            }
            
        }


        public void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            sp.Stop();
            SoundPlayer sp1 = new SoundPlayer(@"48bb90af8e1e401.wav");
            sp1.PlayLooping();//зацикливаем музыку
        }
        //начать
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = true;
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
            timer++;
        }

        private void razmesch(object sender, EventArgs e)
        {

        }
        int m = 5;
        int s = 0;
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
                DialogResult res= MessageBox.Show("Вы проиграли. Начать заново?", "Время вышло!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (res == DialogResult.Yes)
                {
                    m = 5;
                    s = 0;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label1.Text = Convert.ToString(m);
                    label2.Text = Convert.ToString(s);
                    button1.Enabled = true;
                    button4.Enabled = false;
                    button2.Enabled = false;
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
                    for (int i = 0; i < 15; i++)
                    {
                        b = rnd.Next(1, 16);
                        if (i == 0) /*проверка на первый элемент, который не будет повторяться*/
                        {
                            number[i] = b;/*присваивание рандомного числа к элементу массива*/
                        }
                        else
                        {
                            for (int j = 0; j < i; j++)/*если число не первое, то запускается 2-ой цикл, в котором проверяются уже сгенерированные числа на повторение*/
                            {
                                if (number[j] != b)
                                {
                                    a = 0;/*если так, то повторений нет*/
                                }
                                else { a = 1; break; }/*если так, то повторения есть*/
                            }
                        }
                        if (a == 0)
                        {
                            number[i] = b;
                        }
                        else { i--; } /*если повторения есть, то генерация числа начинается сначала*/

                    }
                    //присваиваем тексту кнопок значения массива
                    button2.Text = Convert.ToString(number[0]);
                    button5.Text = Convert.ToString(number[1]);
                    button6.Text = Convert.ToString(number[2]);
                    button7.Text = Convert.ToString(number[3]);
                    button8.Text = Convert.ToString(number[4]);
                    button9.Text = Convert.ToString(number[5]);
                    button10.Text = Convert.ToString(number[6]);
                    button11.Text = Convert.ToString(number[7]);
                    button12.Text = Convert.ToString(number[8]);
                    button13.Text = Convert.ToString(number[9]);
                    button14.Text = Convert.ToString(number[10]);
                    button15.Text = Convert.ToString(number[11]);
                    button16.Text = Convert.ToString(number[12]);
                    button17.Text = Convert.ToString(number[13]);
                    button18.Text = Convert.ToString(number[14]);
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
            if((m>=0 && s>0) || (m > 0 && s == 0))
            {
                if (button2.Text == "1" && button5.Text == "2" && button6.Text == "3" && 
                    button7.Text == "4" && button8.Text == "5" && button9.Text == "6" && 
                    button10.Text == "7" && button11.Text == "8" && button12.Text == "9" && 
                    button13.Text == "10" && button14.Text == "11" && button15.Text == "12" && 
                    button16.Text == "13" && button17.Text == "14" && button18.Text == "15")
                {
                    timer1.Stop();
                    if (m >= 3 && s >= 0)
                    {
                        DialogResult res = MessageBox.Show("Отлично! Вы прошли игру за " + m + " минут и " + (s+1) + " секунд. Вы занимаете почетное 1 место! Начать заново?", "Поздравление!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        if (res == DialogResult.Yes)
                        {
                            m = 5;
                            s = 0;
                            label1.ForeColor = Color.Black;
                            label2.ForeColor = Color.Black;
                            label1.Text = Convert.ToString(m);
                            label2.Text = Convert.ToString(s);
                            button1.Enabled = true;
                            button4.Enabled = false;
                            button2.Enabled = false;
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
                            for (int i = 0; i < 15; i++)
                            {
                                b = rnd.Next(1, 16);
                                if (i == 0) /*проверка на первый элемент, который не будет повторяться*/
                                {
                                    number[i] = b;/*присваивание рандомного числа к элементу массива*/
                                }
                                else
                                {
                                    for (int j = 0; j < i; j++)/*если число не первое, то запускается 2-ой цикл, в котором проверяются уже сгенерированные числа на повторение*/
                                    {
                                        if (number[j] != b)
                                        {
                                            a = 0;/*если так, то повторений нет*/
                                        }
                                        else { a = 1; break; }/*если так, то повторения есть*/
                                    }
                                }
                                if (a == 0)
                                {
                                    number[i] = b;
                                }
                                else { i--; } /*если повторения есть, то генерация числа начинается сначала*/

                            }
                            //присваиваем тексту кнопок значения массива
                            button2.Text = Convert.ToString(number[0]);
                            button5.Text = Convert.ToString(number[1]);
                            button6.Text = Convert.ToString(number[2]);
                            button7.Text = Convert.ToString(number[3]);
                            button8.Text = Convert.ToString(number[4]);
                            button9.Text = Convert.ToString(number[5]);
                            button10.Text = Convert.ToString(number[6]);
                            button11.Text = Convert.ToString(number[7]);
                            button12.Text = Convert.ToString(number[8]);
                            button13.Text = Convert.ToString(number[9]);
                            button14.Text = Convert.ToString(number[10]);
                            button15.Text = Convert.ToString(number[11]);
                            button16.Text = Convert.ToString(number[12]);
                            button17.Text = Convert.ToString(number[13]);
                            button18.Text = Convert.ToString(number[14]);
                        }
                        else
                        {
                            this.Close();
                            sp.Stop();
                            SoundPlayer sp1 = new SoundPlayer(@"48bb90af8e1e401.wav");
                            sp1.PlayLooping();//зацикливаем музыку
                        }
                    }
                    if (m >= 2 && m<3 && s >= 0)
                    {
                        DialogResult res = MessageBox.Show("Хорошо! Вы прошли игру за " + m + " минут и " + (s+1) + " секунд. Вы получаете серебро - 2 место! Начать заново?", "Поздравление!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        if (res == DialogResult.Yes)
                        {
                            m = 5;
                            s = 0;
                            label1.ForeColor = Color.Black;
                            label2.ForeColor = Color.Black;
                            label1.Text = Convert.ToString(m);
                            label2.Text = Convert.ToString(s);
                            button1.Enabled = true;
                            button4.Enabled = false;
                            button2.Enabled = false;
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
                            for (int i = 0; i < 15; i++)
                            {
                                b = rnd.Next(1, 16);
                                if (i == 0) /*проверка на первый элемент, который не будет повторяться*/
                                {
                                    number[i] = b;/*присваивание рандомного числа к элементу массива*/
                                }
                                else
                                {
                                    for (int j = 0; j < i; j++)/*если число не первое, то запускается 2-ой цикл, в котором проверяются уже сгенерированные числа на повторение*/
                                    {
                                        if (number[j] != b)
                                        {
                                            a = 0;/*если так, то повторений нет*/
                                        }
                                        else { a = 1; break; }/*если так, то повторения есть*/
                                    }
                                }
                                if (a == 0)
                                {
                                    number[i] = b;
                                }
                                else { i--; } /*если повторения есть, то генерация числа начинается сначала*/

                            }
                            //присваиваем тексту кнопок значения массива
                            button2.Text = Convert.ToString(number[0]);
                            button5.Text = Convert.ToString(number[1]);
                            button6.Text = Convert.ToString(number[2]);
                            button7.Text = Convert.ToString(number[3]);
                            button8.Text = Convert.ToString(number[4]);
                            button9.Text = Convert.ToString(number[5]);
                            button10.Text = Convert.ToString(number[6]);
                            button11.Text = Convert.ToString(number[7]);
                            button12.Text = Convert.ToString(number[8]);
                            button13.Text = Convert.ToString(number[9]);
                            button14.Text = Convert.ToString(number[10]);
                            button15.Text = Convert.ToString(number[11]);
                            button16.Text = Convert.ToString(number[12]);
                            button17.Text = Convert.ToString(number[13]);
                            button18.Text = Convert.ToString(number[14]);
                        }
                        else
                        {
                            this.Close();
                            sp.Stop();
                            SoundPlayer sp1 = new SoundPlayer(@"48bb90af8e1e401.wav");
                            sp1.PlayLooping();//зацикливаем музыку
                        }
                    }
                    if (m < 2)
                    {
                        DialogResult res = MessageBox.Show("Неплохо! Вы прошли игру за " + m + " минут и " + (s+1) + " секунд. Вы получаете бронзу - 3 место! Начать заново?", "Поздравление!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        if (res == DialogResult.Yes)
                        {
                            m = 5;
                            s = 0;
                            label1.ForeColor = Color.Black;
                            label2.ForeColor = Color.Black;
                            label1.Text = Convert.ToString(m);
                            label2.Text = Convert.ToString(s);
                            button1.Enabled = true;
                            button4.Enabled = false;
                            button2.Enabled = false;
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
                            for (int i = 0; i < 15; i++)
                            {
                                b = rnd.Next(1, 16);
                                if (i == 0) /*проверка на первый элемент, который не будет повторяться*/
                                {
                                    number[i] = b;/*присваивание рандомного числа к элементу массива*/
                                }
                                else
                                {
                                    for (int j = 0; j < i; j++)/*если число не первое, то запускается 2-ой цикл, в котором проверяются уже сгенерированные числа на повторение*/
                                    {
                                        if (number[j] != b)
                                        {
                                            a = 0;/*если так, то повторений нет*/
                                        }
                                        else { a = 1; break; }/*если так, то повторения есть*/
                                    }
                                }
                                if (a == 0)
                                {
                                    number[i] = b;
                                }
                                else { i--; } /*если повторения есть, то генерация числа начинается сначала*/

                            }
                            //присваиваем тексту кнопок значения массива
                            button2.Text = Convert.ToString(number[0]);
                            button5.Text = Convert.ToString(number[1]);
                            button6.Text = Convert.ToString(number[2]);
                            button7.Text = Convert.ToString(number[3]);
                            button8.Text = Convert.ToString(number[4]);
                            button9.Text = Convert.ToString(number[5]);
                            button10.Text = Convert.ToString(number[6]);
                            button11.Text = Convert.ToString(number[7]);
                            button12.Text = Convert.ToString(number[8]);
                            button13.Text = Convert.ToString(number[9]);
                            button14.Text = Convert.ToString(number[10]);
                            button15.Text = Convert.ToString(number[11]);
                            button16.Text = Convert.ToString(number[12]);
                            button17.Text = Convert.ToString(number[13]);
                            button18.Text = Convert.ToString(number[14]);
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
        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void Form2_Resize(object sender, EventArgs e)
        {

        }
        private void panel1_Resize(object sender, EventArgs e)
        {
            //размещаем кнопки с помощью цикла
            int x;
            int y = 1;
            for (int i = 0; i < 16; i++)
            {
                x = i - y * 4;
                y = i / 4;
            }
        }
        int[] number = new int[15];
        int b = 0;
        Random rnd = new Random();
        int a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            //создание перемешки для кнопок и проверка на отсутствие повторов
            for (int i = 0; i < 15; i++)
            {
                b = rnd.Next(1, 16);
                if (i == 0)
                {
                    number[i] = b;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (number[j] != b)
                        {
                            a = 0;
                        }
                        else { a = 1; break; }

                    }
                }
                if (a == 0)
                {
                    number[i] = b;
                }
                else { i--; }

            }
            //присваиваем тексту кнопок значения массива
            button2.Text = Convert.ToString(number[0]);
            button5.Text = Convert.ToString(number[1]);
            button6.Text = Convert.ToString(number[2]);
            button7.Text = Convert.ToString(number[3]);
            button8.Text = Convert.ToString(number[4]);
            button9.Text = Convert.ToString(number[5]);
            button10.Text = Convert.ToString(number[6]);
            button11.Text = Convert.ToString(number[7]);
            button12.Text = Convert.ToString(number[8]);
            button13.Text = Convert.ToString(number[9]);
            button14.Text = Convert.ToString(number[10]);
            button15.Text = Convert.ToString(number[11]);
            button16.Text = Convert.ToString(number[12]);
            button17.Text = Convert.ToString(number[13]);
            button18.Text = Convert.ToString(number[14]);
        }
        int timer = 0;
        private void button20_Click(object sender, EventArgs e)
        {
            if (timer == 0)
            {
                timer1.Start();
                timer++;
                button2.Enabled = true;
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
            }
            else
            {
                timer1.Stop();
                timer--;
                button1.Enabled = false;
                button2.Enabled = false;
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
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
