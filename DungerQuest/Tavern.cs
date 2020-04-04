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
    public partial class Tavern : Form
    {
        int gold_h, gold_E, lvl, exp_h, expMax, att, prot, atl, skill, hp_h, hpMax_h, hp_E, hpMax_E, Att_E, Prot_E, Z_h, score;

        private void button2_Click(object sender, EventArgs e)
        {
            Vilanger f = new Vilanger(att, prot, atl, skill, hp_h, hpMax_h, hp_E, hpMax_E, Att_E, Prot_E, dia_1, Name, gold_h, gold_E, lvl, exp_h, expMax, Z_h, score);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(gold_h < 10)
            {
                label2.Show();
            }
            else
            {
                label2.Hide();
                Z_h = Z_h + 1;
            }
        }

        string dia_1, Name;
        public Tavern(int att_o, int prot_o, int atl_o, int skill_o, int hp_h_o, int hpMax_h_o, int hp_E_o, int hpMax_E_o, int Att_E_o,int Prot_E_o,String dia_1_o,String Name_o,int gold_h_o,int gold_E_o,int lvl_o,int exp_h_o,int expMax_o, int Z_h_o, int score_o)
        {
            InitializeComponent();
            label2.Hide();
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
        }
    }
}
