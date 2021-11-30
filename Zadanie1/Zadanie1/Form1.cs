using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        abstract class Komplect<k>
        {
            protected string price;
            protected string god;
            protected string articul;
            public Komplect(string Price, string God, string Articul)
            {
                price = Price;
                god = God;
                articul = Articul;
            }
            public abstract void Display(ListBox listBox1);
        }
        class CP : Komplect<string>
        {
            public string chast;
            public string core;
            public string potoki;
            public CP(string Chast, string Core, string Potoki, string Price, string God, string Articul)
                : base(Price, God, Articul)
            {
                chast = Chast;
                core = Core;
                potoki = Potoki;
            }
            public string chasta { get { return chast; } set { chast = value; } }
            public string cores { get { return core; } set { core = value; } }
            public string potoks { get { return potoki; } set { potoki = value; } }
            public override void Display(ListBox listBox1)
            {
                listBox1.Items.Add($"Цена - {price},Год - {god},Частота - {chast},Ядра - {core},Потоки - {potoki}");
            }
        }
         class VideoCard : Komplect<string>
        {
            public string chastgpu;
            public string proizvod;
            public string pamat;
            public VideoCard(string Price, string God, string Articul, string Chastgpu, string Proizvod, string Pamat)
                : base(Price, God, Articul)
            {
                chastgpu = Chastgpu;
                proizvod = Proizvod;
                pamat = Pamat;
            }
            public string chastgpuu { get { return chastgpu; } set { chastgpu = value; } }
            public string proiz { get { return proizvod; } set { proizvod = value; } }
            public string pamats { get { return pamat; } set { pamat = value; } }
            public override void Display(ListBox listBox1)
            {
                listBox1.Items.Add($"Цена - {price},Год - {god},ЧастотаГПУ - {chastgpu},Производитель - {proizvod},Память - {pamat}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string price = Convert.ToString(textBox1.Text);
            string god = Convert.ToString(textBox2.Text);
            string chast = Convert.ToString(textBox3.Text);
            string core = Convert.ToString(textBox4.Text);
            string potoki = Convert.ToString(textBox5.Text);
            string articul = Convert.ToString(textBox6.Text);
            CP cp1 = new CP(price, god, chast, core, potoki, articul);
            cp1.Display(listBox1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string price = Convert.ToString(textBox1.Text);
            string god = Convert.ToString(textBox2.Text);
            string chast = Convert.ToString(textBox3.Text);
            string proizvod = Convert.ToString(textBox4.Text);
            string pamat = Convert.ToString(textBox5.Text);
            string articul = Convert.ToString(textBox6.Text);
            VideoCard vd1 = new VideoCard(price, god, chast, proizvod, pamat, articul);
            vd1.Display(listBox1);



        }
    }
}
