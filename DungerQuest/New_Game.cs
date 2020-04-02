using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungerQuest
{
    public partial class New_Game : Form
    {
        int n = 20, att = 0, prot = 0, atl = 0, skill = 0;
        string dia_1, Name;
        public New_Game()
        {
            InitializeComponent();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name = textBox1.Text;
            textBox1.Hide();
            button1.Hide();
            dia_1 = "Приветствую " + Name + " в нашей армии. Скажи о своих характеристиках";
            label1.Text = dia_1;
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            label2.Text = "Очки умений: " + n;
            label3.Text = "Атака: " + att;
            label4.Text = "Защита: " + prot;
            label5.Text = "Ловкость: " + atl;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (n != 0)
            {
                att = att + 1;
                n = n - 1;
            }
            label2.Text = "Очки умений: " + n;
            label3.Text = "Атака: " + att;
            label4.Text = "Защита: " + prot;
            label5.Text = "Ловкость: " + atl;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (att != 0)
            {
                att = att - 1;
                n = n + 1;
            }
            label2.Text = "Очки умений: " + n;
            label3.Text = "Атака: " + att;
            label4.Text = "Защита: " + prot;
            label5.Text = "Ловкость: " + atl;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (n != 0)
            {
                prot = prot + 1;
                n = n - 1;
            }
            label2.Text = "Очки умений: " + n;
            label3.Text = "Атака: " + att;
            label4.Text = "Защита: " + prot;
            label5.Text = "Ловкость: " + atl;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Hide();
            button11.Hide();
            button12.Hide();
            att = att + 2;
            prot = prot + 1;
            atl = atl + 4;
            skill = 3;
            dia_1 = "Ассасин - скрытный класс. Довольно хороший выбор";
            label1.Text = dia_1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button10.Hide();
            button11.Hide();
            button12.Hide();
            att = att + 5;
            atl = atl + 2;
            skill = 2;
            dia_1 = "Лучник - класс для точных. Если умеешь стрелять, то этот класс для тебя";
            label1.Text = dia_1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button10.Hide();
            button11.Hide();
            button12.Hide();
            att = att + 3;
            prot = prot + 5;
            atl = atl - 2;
            skill = 1;
            dia_1 = "Мечник - самый стандартный класс. Если любишь ходить в тяжелой броне, мечник для тебя";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (prot != 0)
            {
                prot = prot - 1;
                n = n + 1;
            }
            label2.Text = "Очки умений: " + n;
            label3.Text = "Атака: " + att;
            label4.Text = "Защита: " + prot;
            label5.Text = "Ловкость: " + atl;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (n != 0)
            {
                atl = atl + 1;
                n = n - 1;
            }
            label2.Text = "Очки умений: " + n;
            label3.Text = "Атака: " + att;
            label4.Text = "Защита: " + prot;
            label5.Text = "Ловкость: " + atl;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (atl != 0)
            {
                atl = atl - 1;
                n = n + 1;
            }
            label2.Text = "Очки умений: " + n;
            label3.Text = "Атака: " + att;
            label4.Text = "Защита: " + prot;
            label5.Text = "Ловкость: " + atl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                button2.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                button2.Hide();
                button3.Hide();
                button4.Hide();
                button5.Hide();
                button6.Hide();
                button7.Hide();
                button8.Hide();
                button10.Show();
                button11.Show();
                button12.Show();
                dia_1 = "Молодец" + Name + ", хорошие характеристики. Теперь выбери свой класс";
                label1.Text = dia_1;
            }
        }
    }
}
