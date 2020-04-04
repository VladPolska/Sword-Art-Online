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
    public partial class Inventory : Form
    {
        int att, prot, atl, skill, hp_h, hpMax_h, hp_E, hpMax_E, Att_E, Prot_E, gold_h, gold_E, lvl, exp_h, expMax, Z_h, score;

        private void button2_Click(object sender, EventArgs e)
        {
            Dungeon f = new Dungeon(att, prot, atl, skill, hp_h, hpMax_h, hp_E, hpMax_E, Att_E, Prot_E, dia_1, Name, gold_h, gold_E, lvl, exp_h, expMax, Z_h, score);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Z_h > 0)
            {
                if(hp_h + 10 <= hpMax_h)
                {
                    hp_h = hp_E + 10;
                }
                else
                {
                    hp_h = hpMax_h;
                }
                label6.Text = "Здоворье: " + hp_h + "/" + hpMax_h;
            }
        }

        string dia_1, Name;
        public Inventory(int att_o, int prot_o, int atl_o, int skill_o, int hp_h_o, int hpMax_h_o, int hp_E_o, int hpMax_E_o, int Att_E_o, int Prot_E_o, String dia_1_o, String Name_o, int gold_h_o, int gold_E_o, int lvl_o, int exp_h_o, int expMax_o, int Z_h_o, int score_o)
        {
            InitializeComponent();
            att = att_o;
            prot = prot_o;
            atl = atl_o;
            skill = skill_o;
            hp_h = hp_h_o;
            hpMax_h = hpMax_h_o;
            hp_E = hp_E_o;
            hpMax_E = hpMax_E_o;
            Att_E = Att_E_o;
            Prot_E = Prot_E_o;
            dia_1 = dia_1_o;
            Name = Name_o;
            gold_h = gold_h_o;
            gold_E = gold_E_o;
            lvl = lvl_o;
            exp_h = exp_h_o;
            expMax = expMax_o;
            Z_h = Z_h_o;
            score = score_o;
            label1.Text = Name;
            label2.Text = "Уровень: " + lvl;
            label3.Text = "Опыт: " + exp_h + "/" + expMax;
            label4.Text = "Золото: " + gold_h;
            label6.Text = "Здоворье: " + hp_h + "/" + hpMax_h;
            label7.Text = "Атака: " + att;
            label8.Text = "Защита: " + prot;
            label9.Text = "Ловкость: " + atl;
            label10.Text = "Зелья здоровья: " + Z_h;
            if(skill == 1)
            {
                label11.Text = "Класс: Мечник";
            }
            if (skill == 2)
            {
                label11.Text = "Класс: Лучник";
            }
            if (skill == 3)
            {
                label11.Text = "Класс: Ассасин";
            }
        }
    }
}
