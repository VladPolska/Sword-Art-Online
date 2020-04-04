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
    public partial class Dungeon : Form
    {
        int gold_h, gold_E, lvl, exp_h, expMax, att, prot, atl, skill, hp_h, hpMax_h, hp_E, hpMax_E, Att_E, Prot_E, Z_h, score, battle = 0, n, att_old, prot_old, atl_old, t = 1;

        private void button18_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if(value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button17.Show();
                    button12.Show();
                }
            }
            else if (battle == 0)
            {
                button17.Show();
                button12.Show();
                button16.Hide();
                button18.Hide();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button8.Show();
                    button10.Show();
                    button20.Show();
                }
            }
            else if (battle == 0)
            {
                button8.Show();
                button10.Show();
                button20.Show();
                button15.Hide();
                button13.Hide();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();

                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button8.Show();
                    button10.Show();
                    button20.Show();
                }
            }
            else if (battle == 0)
            {
                button8.Show();
                button10.Show();
                button20.Show();
                button21.Hide();
                button22.Hide();
                button19.Hide();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button1.Show();
                    button2.Show();
                    button3.Show();
                }
            }
            else if (battle == 0)
            {
                button1.Show();
                button2.Show();
                button3.Show();
                button17.Hide();
                button12.Hide();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button21.Show();
                    button22.Show();
                    button19.Show();
                }
            }
            else if (battle == 0)
            {
                button8.Hide();
                button10.Hide();
                button20.Hide();
                button21.Show();
                button22.Show();
                button19.Show();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button25.Show();
                    button24.Show();
                    button26.Show();
                }
            }
            else if (battle == 0)
            {
                button25.Show();
                button24.Show();
                button26.Show();
                button21.Hide();
                button19.Hide();
                button22.Hide();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button18.Show();
                    button16.Show();
                }
            }
            else if (battle == 0)
            {
                button18.Show();
                button16.Show();
                button22.Hide();
                button19.Hide();
                button21.Hide();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button21.Show();
                    button19.Show();
                    button22.Show();
                }
            }
            else if (battle == 0)
            {
                button21.Show();
                button19.Show();
                button22.Show();
                button16.Hide();
                button18.Hide();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                else if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button23.Show();
                    button14.Show();
                    button16.Hide();
                    button17.Hide();
                    button18.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                }
            }
            else if (battle == 0)
            {
                button25.Hide();
                button24.Hide();
                button26.Hide();
                button23.Show();
                button14.Show();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if(att >= Prot_E)
            {
                if (Prot_E <= att)
                {
                    hp_E = hp_E - (att - Prot_E);
                }
                if (prot <= Att_E)
                {
                    hp_h = hp_h - (Att_E - prot);
                }
            }
            else
            {
                if (prot <= Att_E)
                {
                    hp_h = hp_h - (Att_E - prot);
                }
            }
            if (score < 3)
            {
                score = score + 1;
            }
            label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
            label6.Text = "Здоровье: " + hp_h + "/" + hpMax_h;
            if (hp_E <= 0)
            {
                exp_h = exp_h + 1;
                gold_h = gold_h + gold_E;
                hp_E = hpMax_E;
                battle = 0;
                if (exp_h == expMax)
                {
                    label10.Show();
                    label11.Show();
                    label12.Show();
                    label13.Show();
                    button30.Show();
                    button31.Show();
                    button32.Show();
                    button33.Show();
                    button34.Show();
                    button35.Show();
                    button36.Show();
                    n = 5;
                    att_old = att;
                    prot_old = prot;
                    atl_old = atl;
                    exp_h = 0;
                    hpMax_h = hpMax_h + 5;
                    hp_h = hpMax_h;
                    lvl = lvl + 1;
                    Att_E = Att_E + 3;
                    Prot_E = Prot_E + 2;
                    hpMax_E = hpMax_E + 5;
                    hp_E = hpMax_E;
                    label10.Text = "Очки умения: " + n;
                    label11.Text = "Атака: " + att;
                    label12.Text = "Защита: " + prot;
                    label13.Text = "Ловкость: " + atl;
                    if (n == 0)
                    {
                        label10.Hide();
                        label11.Hide();
                        label12.Hide();
                        label13.Hide();
                        button30.Hide();
                        button31.Hide();
                        button32.Hide();
                        button33.Hide();
                        button34.Hide();
                        button35.Hide();
                        button36.Hide();
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button1.Show();
                    button2.Show();
                    button3.Show();
                    button4.Show();
                    button5.Show();
                    pictureBox2.Hide();
                }
                if (t == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    label10.Hide();
                    label11.Hide();
                    label12.Hide();
                    label13.Hide();
                    button1.Hide();
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
                    button18.Hide();
                    button19.Hide();
                    button20.Hide();
                    button21.Hide();
                    button22.Hide();
                    button23.Hide();
                    button24.Hide();
                    button25.Hide();
                    button26.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button31.Hide();
                    button32.Hide();
                    button33.Hide();
                    button34.Hide();
                    button35.Hide();
                    button36.Hide();
                    pictureBox2.Hide();
                    label14.Show();
                }
            }
            if (hp_h <= 0)
            {
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Hide();
                button28.Hide();
                button29.Hide();
                button30.Hide();
                button31.Hide();
                button32.Hide();
                button33.Hide();
                button34.Hide();
                button35.Hide();
                button36.Hide();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Show();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button21.Show();
                    button19.Show();
                    button22.Show();
                }
            }
            else if (battle == 0)
            {
                button25.Hide();
                button24.Hide();
                button26.Hide();
                button21.Show();
                button19.Show();
                button22.Show();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (n <= 5)
            {
                n = n - 1;
                prot = prot + 1;
                label10.Text = "Очки умения: " + n;
                label11.Text = "Атака: " + att;
                label12.Text = "Защита: " + prot;
                label13.Text = "Ловкость: " + atl;
            }
            if (n == 0)
            {
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                button30.Hide();
                button31.Hide();
                button32.Hide();
                button33.Hide();
                button34.Hide();
                button35.Hide();
                button36.Hide();
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (prot_old < prot)
            {
                n = n + 1;
                prot = prot - 1;
                label10.Text = "Очки умения: " + n;
                label11.Text = "Атака: " + att;
                label12.Text = "Защита: " + prot;
                label13.Text = "Ловкость: " + atl;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (n <= 5)
            {
                n = n - 1;
                atl = atl + 1;
                label10.Text = "Очки умения: " + n;
                label11.Text = "Атака: " + att;
                label12.Text = "Защита: " + prot;
                label13.Text = "Ловкость: " + atl;
            }
            if (n == 0)
            {
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                button30.Hide();
                button31.Hide();
                button32.Hide();
                button33.Hide();
                button34.Hide();
                button35.Hide();
                button36.Hide();
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (atl_old < atl)
            {
                n = n + 1;
                atl = atl - 1;
                label10.Text = "Очки умения: " + n;
                label11.Text = "Атака: " + att;
                label12.Text = "Защита: " + prot;
                label13.Text = "Ловкость: " + atl;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inventory f = new Inventory(att, prot, atl, skill, hp_h, hpMax_h, hp_E, hpMax_E, Att_E, Prot_E, dia_1, Name, gold_h, gold_E, lvl, exp_h, expMax, Z_h, score);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            button1.Hide();
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
            button18.Hide();
            button19.Hide();
            button20.Hide();
            button21.Hide();
            button22.Hide();
            button23.Hide();
            button24.Hide();
            button25.Hide();
            button26.Hide();
            button27.Show();
            button28.Show();
            button29.Show();
            button30.Show();
            pictureBox3.Show();
            hp_E = 100;
            hpMax_E = hp_E;
            Att_E = 15;
            Prot_E = 10;
            t = 0;
            label1.Text = "Кровавый дракон";
            label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
            label3.Text = "Атака: " + Att_E;
            label4.Text = "Защита: " + Prot_E;
            label5.Text = Name;
            label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
            label7.Text = "Атака: " + att;
            label8.Text = "Защита: " + prot;
            label9.Text = "Ловкость: " + atl;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if(prot * 2 > value)
            {
                if (Prot_E <= att)
                {
                    hp_E = hp_E - ((att - Prot_E) / 2);
                }
            }
            else
            {
                if (Prot_E <= att)
                {
                    hp_E = hp_E - ((att - Prot_E) / 2);
                }
                if (prot <= Att_E)
                {
                    hp_h = hp_h - (Att_E - prot);
                }
            }
            if(score < 3)
            {
                score = score + 1;
            }
            label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
            label6.Text = "Здоровье: " + hp_h + "/" + hpMax_h;
            if (hp_E <= 0)
            {
                exp_h = exp_h + 1;
                gold_h = gold_h + gold_E;
                hp_E = hpMax_E;
                battle = 0;
                if (exp_h == expMax)
                {
                    label10.Show();
                    label11.Show();
                    label12.Show();
                    label13.Show();
                    button30.Show();
                    button31.Show();
                    button32.Show();
                    button33.Show();
                    button34.Show();
                    button35.Show();
                    button36.Show();
                    n = 5;
                    att_old = att;
                    prot_old = prot;
                    atl_old = atl;
                    hpMax_h = hpMax_h + 5;
                    hp_h = hpMax_h;
                    exp_h = 0;
                    lvl = lvl + 1;
                    Att_E = Att_E + 3;
                    Prot_E = Prot_E + 2;
                    hpMax_E = hpMax_E + 5;
                    hp_E = hpMax_E;
                    score = 3;
                    label10.Text = "Очки умения: " + n;
                    label11.Text = "Атака: " + att;
                    label12.Text = "Защита: " + prot;
                    label13.Text = "Ловкость: " + atl;
                    if (n == 0)
                    {
                        label10.Hide();
                        label11.Hide();
                        label12.Hide();
                        label13.Hide();
                        button30.Hide();
                        button31.Hide();
                        button32.Hide();
                        button33.Hide();
                        button34.Hide();
                        button35.Hide();
                        button36.Hide();
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button1.Show();
                    button2.Show();
                    button3.Show();
                    button4.Show();
                    button5.Show();
                    pictureBox2.Hide();
                }
                if(t == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    label10.Hide();
                    label11.Hide();
                    label12.Hide();
                    label13.Hide();
                    button1.Hide();
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
                    button18.Hide();
                    button19.Hide();
                    button20.Hide();
                    button21.Hide();
                    button22.Hide();
                    button23.Hide();
                    button24.Hide();
                    button25.Hide();
                    button26.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button31.Hide();
                    button32.Hide();
                    button33.Hide();
                    button34.Hide();
                    button35.Hide();
                    button36.Hide();
                    pictureBox2.Hide();
                    label14.Show();
                }
            }
            if (hp_h <= 0)
            {
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Hide();
                button28.Hide();
                button29.Hide();
                button30.Hide();
                button31.Hide();
                button32.Hide();
                button33.Hide();
                button34.Hide();
                button35.Hide();
                button36.Hide();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Show();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if(skill == 1)
            {
                score = 0;
                if (prot <= Att_E)
                {
                    hp_E = hp_E - (att * 2);
                    hp_h = hp_h - (Att_E - prot);
                }
            }
            if (skill == 2)
            {
                score = 0;
                if (Prot_E <= att + 10)
                {
                    hp_E = hp_E - ((att + 10) - Prot_E);
                }
            }
            if (skill == 3)
            {
                score = 0;
                if (Prot_E <= att + 15)
                {
                    hp_E = hp_E - ((att + 15) - Prot_E);
                }
                if(prot <= Att_E)
                {
                    hp_h = hp_h - (Att_E - prot);
                }
            }
            label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
            label6.Text = "Здоровье: " + hp_h + "/" + hpMax_h;
            if (hp_E <= 0)
            {
                battle = 0;
                exp_h = exp_h + 1;
                gold_h = gold_h + gold_E;
                hp_E = hpMax_E;
                if (exp_h == expMax)
                {
                    label10.Show();
                    label11.Show();
                    label12.Show();
                    label13.Show();
                    button30.Show();
                    button31.Show();
                    button32.Show();
                    button33.Show();
                    button34.Show();
                    button35.Show();
                    button36.Show();
                    n = 5;
                    att_old = att;
                    prot_old = prot;
                    atl_old = atl;
                    hpMax_h = hpMax_h + 5;
                    hp_h = hpMax_h;
                    exp_h = 0;
                    lvl = lvl + 1;
                    Att_E = Att_E + 3;
                    Prot_E = Prot_E + 2;
                    hpMax_E = hpMax_E + 5;
                    hp_E = hpMax_E;
                    label10.Text = "Очки умения: " + n;
                    label11.Text = "Атака: " + att;
                    label12.Text = "Защита: " + prot;
                    label13.Text = "Ловкость: " + atl;
                    if (n == 0)
                    {
                        label10.Hide();
                        label11.Hide();
                        label12.Hide();
                        label13.Hide();
                        button30.Hide();
                        button31.Hide();
                        button32.Hide();
                        button33.Hide();
                        button34.Hide();
                        button35.Hide();
                        button36.Hide();
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button1.Show();
                    button2.Show();
                    button3.Show();
                    button4.Show();
                    button5.Show();
                    pictureBox2.Hide();
                }
                if (t == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    label10.Hide();
                    label11.Hide();
                    label12.Hide();
                    label13.Hide();
                    button1.Hide();
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
                    button18.Hide();
                    button19.Hide();
                    button20.Hide();
                    button21.Hide();
                    button22.Hide();
                    button23.Hide();
                    button24.Hide();
                    button25.Hide();
                    button26.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button31.Hide();
                    button32.Hide();
                    button33.Hide();
                    button34.Hide();
                    button35.Hide();
                    button36.Hide();
                    pictureBox2.Hide();
                    label14.Show();
                }
            }
            if (hp_h <= 0)
            {
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Hide();
                button28.Hide();
                button29.Hide();
                button30.Hide();
                button31.Hide();
                button32.Hide();
                button33.Hide();
                button34.Hide();
                button35.Hide();
                button36.Hide();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Show();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if(att_old < att)
            {
                n = n + 1;
                att = att - 1;
                label10.Text = "Очки умения: " + n;
                label11.Text = "Атака: " + att;
                label12.Text = "Защита: " + prot;
                label13.Text = "Ловкость: " + atl;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if(n <= 5)
            {
                n = n - 1;
                att = att + 1;
                label10.Text = "Очки умения: " + n;
                label11.Text = "Атака: " + att;
                label12.Text = "Защита: " + prot;
                label13.Text = "Ловкость: " + atl;
            }
            if(n == 0)
            {
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                button30.Hide();
                button31.Hide();
                button32.Hide();
                button33.Hide();
                button34.Hide();
                button35.Hide();
                button36.Hide();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (atl * 2 > value)
            {
                if (Prot_E <= att)
                {
                    hp_E = hp_E - (att - Prot_E);
                }
            }
            else
            {
                if (prot <= Att_E)
                {
                    hp_h = hp_h - (Att_E - prot);
                }
            }
            if (score < 3)
            {
                score = score + 1;
            }
            label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
            label6.Text = "Здоровье: " + hp_h + "/" + hpMax_h;
            if (hp_E <= 0)
            {
                exp_h = exp_h + 1;
                gold_h = gold_h + gold_E;
                hp_E = hpMax_E;
                battle = 0;
                if (exp_h == expMax)
                {
                    label10.Show();
                    label11.Show();
                    label12.Show();
                    label13.Show();
                    button30.Show();
                    button31.Show();
                    button32.Show();
                    button33.Show();
                    button34.Show();
                    button35.Show();
                    button36.Show();
                    n = 5;
                    att_old = att;
                    prot_old = prot;
                    atl_old = atl;
                    hpMax_h = hpMax_h + 5;
                    hp_h = hpMax_h;
                    exp_h = 0;
                    lvl = lvl + 1;
                    Att_E = Att_E + 3;
                    Prot_E = Prot_E + 2;
                    hpMax_E = hpMax_E + 5;
                    hp_E = hpMax_E;
                    label10.Text = "Очки умения: " + n;
                    label11.Text = "Атака: " + att;
                    label12.Text = "Защита: " + prot;
                    label13.Text = "Ловкость: " + atl;
                    if (n == 0)
                    {
                        label10.Hide();
                        label11.Hide();
                        label12.Hide();
                        label13.Hide();
                        button31.Hide();
                        button32.Hide();
                        button33.Hide();
                        button34.Hide();
                        button35.Hide();
                        button36.Hide();
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button1.Show();
                    button2.Show();
                    button3.Show();
                    button4.Show();
                    button5.Show();
                    pictureBox2.Hide();
                }
            }
            if (hp_h <= 0)
            {
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Hide();
                button28.Hide();
                button29.Hide();
                button30.Hide();
                button31.Hide();
                button32.Hide();
                button33.Hide();
                button34.Hide();
                button35.Hide();
                button36.Hide();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Show();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if(n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button25.Show();
                    button24.Show();
                    button26.Show();
                    pictureBox2.Hide();
                }
            }
            else if (battle == 0)
            {
                button25.Show();
                button24.Show();
                button26.Show();
                button23.Hide();
                button14.Hide();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button14.Show();
                    button23.Show();
                    pictureBox2.Hide();
                }
            }
            else if (battle == 0)
            {
                button14.Show();
                button23.Show();
                button10.Hide();
                button8.Hide();
                button20.Hide();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button10.Show();
                    button8.Show();
                    button20.Show();
                    pictureBox2.Hide();
                }
            }
            else if (battle == 0)
            {
                button10.Show();
                button8.Show();
                button20.Show();
                button14.Hide();
                button23.Hide();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button16.Show();
                    button18.Show();
                    pictureBox2.Hide();
                }
            }
            else if (battle == 0)
            {
                button12.Hide();
                button17.Hide();
                button16.Show();
                button18.Show();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button9.Show();
                    button11.Show();
                    pictureBox2.Hide();
                }
            }
            else if (battle == 0)
            {
                button9.Show();
                button11.Show();
                button13.Hide();
                button15.Hide();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button7.Show();
                    button6.Show();
                    pictureBox2.Hide();
                }
            }
            else if (battle == 0)
            {
                button9.Hide();
                button11.Hide();
                button7.Show();
                button6.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    int b = 1;
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        b = 0;
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                            b = 1;
                        }
                    }
                    while (b != 1)
                    {
                        battle = 0;
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button9.Show();
                    button11.Show();
                    pictureBox2.Hide();
                }
            }
            else if (battle == 0)
            {
                button9.Show();
                button11.Show();
                button7.Hide();
                button6.Hide();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button13.Show();
                    button15.Show();
                    pictureBox2.Hide();
                }
            }
            else if (battle == 0)
            {
                button13.Show();
                button15.Show();
                button11.Hide();
                button9.Hide();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button13.Show();
                    button15.Show();
                    pictureBox2.Hide();
                }
            }
            else if (battle == 0)
            {
                button13.Show();
                button15.Show();
                button8.Hide();
                button10.Hide();
                button20.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button1.Show();
                    button2.Show();
                    button3.Show();
                    pictureBox2.Hide();
                }
            }
            else if (battle == 0)
            {
                button6.Hide();
                button7.Hide();
                button1.Show();
                button2.Show();
                button3.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vilanger f = new Vilanger(att, prot, atl, skill, hp_h, hpMax_h, hp_E, hpMax_E, Att_E, Prot_E, dia_1, Name, gold_h, gold_E, lvl, exp_h, expMax, Z_h, score);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button17.Show();
                    button12.Show();
                    pictureBox2.Hide();
                }
            }
            else if (battle == 0)
            {
                button17.Show();
                button12.Show();
                button1.Hide();
                button2.Hide();
                button3.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value <= 30)
            {
                battle = 1;
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button1.Hide();
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
                button18.Hide();
                button19.Hide();
                button20.Hide();
                button21.Hide();
                button22.Hide();
                button23.Hide();
                button24.Hide();
                button25.Hide();
                button26.Hide();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                pictureBox2.Show();
                label1.Text = "Скелет";
                label2.Text = "Здоровье: " + hp_E + "/" + hpMax_E;
                label3.Text = "Атака: " + Att_E;
                label4.Text = "Защита: " + Prot_E;
                label5.Text = Name;
                label6.Text = "Здоровья: " + hp_h + "/" + hpMax_h;
                label7.Text = "Атака: " + att;
                label8.Text = "Защита: " + prot;
                label9.Text = "Ловкость: " + atl;
                if (hp_E <= 0)
                {
                    exp_h = exp_h + 1;
                    gold_h = gold_h + gold_E;
                    hp_E = hpMax_E;
                    battle = 0;
                    if (exp_h == expMax)
                    {
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        button30.Show();
                        button31.Show();
                        button32.Show();
                        button33.Show();
                        button34.Show();
                        button35.Show();
                        button36.Show();
                        n = 5;
                        att_old = att;
                        prot_old = prot;
                        atl_old = atl;
                        exp_h = 0;
                        lvl = lvl + 1;
                        Att_E = Att_E + 3;
                        Prot_E = Prot_E + 2;
                        hpMax_E = hpMax_h + 5;
                        hp_E = hpMax_E;
                        label10.Text = "Очки умения: " + n;
                        label11.Text = "Атака: " + att;
                        label12.Text = "Защита: " + prot;
                        label13.Text = "Ловкость: " + atl;
                        if (n == 0)
                        {
                            label10.Hide();
                            label11.Hide();
                            label12.Hide();
                            label13.Hide();
                            button30.Hide();
                            button31.Hide();
                            button32.Hide();
                            button33.Hide();
                            button34.Hide();
                            button35.Hide();
                            button36.Hide();
                        }
                    }
                }
                if (battle == 0)
                {
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    label9.Hide();
                    button27.Hide();
                    button28.Hide();
                    button29.Hide();
                    button30.Hide();
                    button6.Show();
                    button7.Show();
                    pictureBox2.Hide();
                }
            }
            else if (battle == 0)
            {
                button6.Show();
                button7.Show();
                button1.Hide();
                button2.Hide();
                button3.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Map f = new Map();
            f.ShowDialog();
        }

        string dia_1, Name;
        public Dungeon(int att_o, int prot_o, int atl_o, int skill_o, int hp_h_o, int hpMax_h_o, int hp_E_o, int hpMax_E_o, int Att_E_o, int Prot_E_o, String dia_1_o, String Name_o, int gold_h_o, int gold_E_o, int lvl_o, int exp_h_o, int expMax_o, int Z_h_o, int score_o)
        {
            InitializeComponent();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
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
            button18.Hide();
            button19.Hide();
            button20.Hide();
            button21.Hide();
            button22.Hide();
            button23.Hide();
            button24.Hide();
            button25.Hide();
            button26.Hide();
            button27.Hide();
            button28.Hide();
            button29.Hide();
            button30.Hide();
            button31.Hide();
            button32.Hide();
            button33.Hide();
            button34.Hide();
            button35.Hide();
            button36.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
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
