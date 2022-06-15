using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace проект_по_проге
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //создаём фоновую музыку с помощью волнового файла формата wav
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"48bb90af8e1e401.wav");
            sp.PlayLooping();//зацикливаем музыку
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newform= new Form2();
            newform.Show();
        }
        
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newform = new Form3();
            newform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 newform = new Form4();
            newform.Show();
        }
    }
}
