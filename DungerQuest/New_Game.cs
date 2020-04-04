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
        int n = 20, att = 0, prot = 0, atl = 0, skill = 0, hp_h = 20, hpMax_h, hp_E = 10000, hpMax_E, Att_E, Prot_E, gold_h = 0, gold_E = 2, lvl = 1, exp_h = 0, expMax = 3, Z_h = 0, score = 3;
        string dia_1, Name;
        public New_Game()
        {
            InitializeComponent();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();
            label16.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();
            button17.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
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
            pictureBox1.Hide();
            pictureBox2.Show();
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

        private void button14_Click(object sender, EventArgs e)
        {
            hp_E = hp_E - ((att - Prot_E) / 2);
            button14.Hide();
            button15.Show();
            label8.Text = "Жизни: " + hp_E + "/" + hpMax_E;
            dia_1 = "Если атака успешна, то вы нанесете урон в два раза меньше, а по вам урон не будет нанесен";
            label1.Text = dia_1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hp_E = hp_E - (att - Prot_E);
            button15.Hide();
            button16.Show();
            label16.Show();
            label8.Text = "Жизни: " + hp_E + "/" + hpMax_E;
            dia_1 = "Если вы достаточно ловки, то можете нанести урон по противнику, а он нет";
            label1.Text = dia_1;
            if(skill == 1)
            {
                dia_1 = "Теперь попробуй умение. У тебя это 'Берсерк'(В два раза больше атаки и игнорирование брони)";
                label16.Text = dia_1;
            }
            if (skill == 2)
            {
                dia_1 = "Теперь попробуй умение. У тебя это 'Выстрел из лука'(Атака на 10 ед сильнее, и без ответного урона)";
                label16.Text = dia_1;
            }
            if (skill == 3)
            {
                dia_1 = "Теперь попробуй умение. У тебя это 'Мастер клинка'(Увеличение атаки на 15 ед)";
                label16.Text = dia_1;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(skill == 1)
            {
                hp_E = hp_E - (att * 2);
            }
            if (skill == 2)
            {
                hp_E = hp_E - ((att + 10) - Prot_E);
            }
            if (skill == 3)
            {
                hp_E = hp_E - ((att + 15) - Prot_E);
            }
            button16.Hide();
            label16.Hide();
            button17.Show();
            label8.Text = "Жизни: " + hp_E + "/" + hpMax_E;
            dia_1 = "Отлично боец. Теперь поговорим о задании. Нужно отправиться в подземелие и победить дракона. Удачи";
            label1.Text = dia_1;
            hp_E = 35;
            hpMax_E = 35;
            Att_E = 5;
            Prot_E = 3;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            Vilanger f = new Vilanger(att, prot, atl, skill, hp_h, hpMax_h, hp_E, hpMax_E, Att_E, Prot_E, dia_1, Name, gold_h, gold_E, lvl, exp_h, expMax, Z_h, score);
            this.Hide();
            f.ShowDialog();
            this.Close();
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
            dia_1 = "Ассасин - скрытный класс. Довольно хороший выбор. Теперь опробуем тебя в бою";
            label1.Text = dia_1;
            button9.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hp_E = hp_E - (att - Prot_E);
            button13.Hide();
            button14.Show();
            label8.Text = "Жизни: " + hp_E + "/" + hpMax_E;
            dia_1 = "Обычный удар наносит урон, учитывая защиту противника. Теперь попробуй удар с защитой";
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
            dia_1 = "Лучник - класс для точных. Если умеешь стрелять, то этот класс для тебя. Теперь опробуем тебя в бою";
            label1.Text = dia_1;
            button9.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label11.Show();
            label12.Show();
            label13.Show();
            label14.Show();
            label15.Show();
            button9.Hide();
            button13.Show();
            pictureBox3.Show();
            pictureBox1.Hide();
            String Name_E = "Манекен";
            Att_E = 0;
            Prot_E = 0;
            hpMax_h = hp_h;
            hpMax_E = hp_E;
            label7.Text = "Имя: " + Name_E;
            label8.Text = "Жизни: " + hp_E + "/" + hpMax_E;
            label9.Text = "Атака: " + Att_E;
            label10.Text = "Защита: " + Prot_E;
            label11.Text = "Имя: " + Name;
            label12.Text = "Жизни: " + hp_h + "/" + hpMax_h;
            label13.Text = "Атака: " + att;
            label14.Text = "Защита: " + prot;
            label15.Text = "Ловкость: " + atl;
            dia_1 = "Попробуй ударить по Манекену";
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
            dia_1 = "Мечник - самый стандартный класс. Если любишь ходить в тяжелой броне, мечник для тебя. Теперь опробуем тебя в бою";
            label1.Text = dia_1;
            button9.Show();
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
                pictureBox1.Show();
                pictureBox2.Hide();
                dia_1 = "Молодец" + Name + ", хорошие характеристики. Теперь выбери свой класс";
                label1.Text = dia_1;
            }
        }
    }
}
