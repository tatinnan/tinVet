using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int A=0,sum_gb01=0,sum_gb02=0,yearmn=0,sum_gb03=0,sum_gb04=0, sum_gb05=0,SumAll=0;

        private void Form1_Load(object sender, EventArgs e)
        {// โหลดกลุ่ม 1 ***********************************************************************************************************************************
            gb02.Visible = false;
            gb03.Visible = false;
            gb04.Visible = false;
            gb05.Visible = false;
            gb01.Visible = true;
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            mnr_gb01_babyAt61.Enabled = false;
            mnr_gb01_babyBf61.Enabled = false;
            //*******************************************************************************************************************************************
        }
        private void Button1_Click(object sender, EventArgs e)
        {// ปุ่มกลุ่มที่ 1 ***********************************************************************************************************************************
            gb02.Visible = false;
            gb03.Visible = false;
            gb04.Visible = false;
            gb05.Visible = false;
            gb01.Visible = true;
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            cb_gb01_single.Checked = false;
            cb_gb01_My.Checked = false;
            cb_gb01_Mn.Checked = false;
            cb_gb01_babyN.Checked = false;
            cb_gb01_babyBf61.Checked = false;
            cb_gb01_babyAt61.Checked = false;
            cb_gb01_Ad_Ma.Checked = false;
            cb_gb01_Ad_Fa.Checked = false;
            cb_gb01_AdNo.Checked = false;
            cb_gb01_AdFa.Checked = false;
            cb_gb01_AdMa.Checked = false;
            mnr_gb01_babyBf61.Value = 0;
            mnr_gb01_babyAt61.Value = 0;
            tbAdWeak.Text = "0";
            tb_gb01_brn.Text = "0";
            tb_gb01_VSum.Text = "";
            mnr_gb01_babyAt61.Enabled = false;
            mnr_gb01_babyBf61.Enabled = false;
        }//*********************************************************************************************************************************************

        private void Button4_Click(object sender, EventArgs e)
        {// ปุ่มกลุ่มที่ 2 ***********************************************************************************************************************************
            gb02.Visible = true;
            gb03.Visible = false;
            gb04.Visible = false;
            gb05.Visible = false;
            gb01.Visible = false;
            button4.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button1.Enabled = true;
            button5.Enabled = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            mnr_gb02_1.Enabled = false;
            mnr_gb02_2.Enabled = false;
            mnr_gb02_3.Enabled = false;
            numericUpDown7.Enabled = false;
            numericUpDown3.Enabled = false;
            textBox10.Enabled = false;
            textBox29.Text = "";


        }//*********************************************************************************************************************************************

        private void Button2_Click(object sender, EventArgs e)
        {// ปุ่มกลุ่มที่ 3 ***********************************************************************************************************************************
            gb02.Visible = false;
            gb03.Visible = true;
            gb04.Visible = false;
            gb05.Visible = false;
            gb01.Visible = false;
            button2.Enabled = false;
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            gb2558.Visible = false;
            gb2562.Visible = false;
        }//*********************************************************************************************************************************************

        private void Button3_Click(object sender, EventArgs e)
        {// ปุ่มกลุ่มที่ 4 ***********************************************************************************************************************************
            gb02.Visible = false;
            gb03.Visible = false;
            gb04.Visible = true;
            gb05.Visible = false;
            gb01.Visible = false;
            button3.Enabled = false;
            button2.Enabled = true;
            button1.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            tb_gb04_SumVet.Text = "0";
            tb_gb04_12.Text = "0";
            tb_gb04_22.Text = "0";
            tb_gb04_32.Text = "0";
            tb_gb04_42.Text = "0";
            tb_gb04_52.Text = "0";
            tb_gb04_62.Text = "0";
            mnr_gb04_72.Text = "0";
            tb_gb04_1.Text = "0";
            tb_gb04_2.Text = "0";
            tb_gb04_3.Text = "0";
            tb_gb04_4.Text = "0";
            tb_gb04_5.Text = "0";
            tb_gb04_6.Text = "0";
            mmr_gb04_7.Value = 0;
            tbSumVet.Text = "0";
        }//*********************************************************************************************************************************************

        private void Button5_Click(object sender, EventArgs e)
        {// ปุ่มกลุ่มที่ 5 ***********************************************************************************************************************************
            gb02.Visible = false;
            gb03.Visible = false;
            gb04.Visible = false;
            gb05.Visible = true;
            gb01.Visible = false;
            button5.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button1.Enabled = true;
            numericUpDown19.Value = 0;
            numericUpDown18.Value = 0;
            numericUpDown17.Value = 0;
            numericUpDown16.Value = 0;
            numericUpDown15.Value = 0;
            numericUpDown14.Value = 0;
            numericUpDown13.Value = 0;
            numericUpDown12.Value = 0;
            textBox31.Text = "";
        }//***********************************************************************************************************************************************

        private void Bt_gb01_sum_Click(object sender, EventArgs e)
        {//คำนวณกลุ่มที่ 1 ***********************************************************************************************************************************
            int bff=0, att=0,father=0,mather=0,_father=0,_mather=0;
            int weak = int.Parse(tbAdWeak.Text);
            int weakk = weak * 60000;
            int baby = int.Parse(tb_gb01_brn.Text);
            if (baby > 60000)
            {
                baby = 60000;
            }
            if (cb_gb01_babyBf61.Checked)
            {
                int bf = int.Parse(mnr_gb01_babyBf61.Text);
                bff = bf * 30000;
            }
            if (cb_gb01_babyAt61.Checked)
            {
                int at = int.Parse(mnr_gb01_babyAt61.Text);
                att = at * 60000;
            }
            if (cb_gb01_Mn.Checked)
            {
                A = 60000;
            }
            if (cb_gb01_AdFa.Checked)
            {
                father = 30000;
            }
            if (cb_gb01_AdMa.Checked)
            {
                mather = 30000;
            }
            if (cb_gb01_Ad_Fa.Checked)
            {
                _father = 30000;
            }
            if (cb_gb01_Ad_Ma.Checked)
            {
                _mather = 30000;
            }
            sum_gb01 = A + bff + att + father + mather + weakk +_father + _mather + baby;
            tb_gb01_VSum.Text = sum_gb01.ToString();
            label85.Text = sum_gb01.ToString();
        }//***************************************************************************************************************************************************

        private void Button7_Click(object sender, EventArgs e)
        {//เงินตลอดทั้งปี *****************************************************************************************************************************************
            int mnMoney = int.Parse(nmrMnMoney.Text);
            yearmn = mnMoney * 12 + (int.Parse(nmrMoreMoney.Text)) + (int.Parse(nmrMBonus.Text));
            string Y = Convert.ToString(yearmn);
            tbMoneySum.Text = Y.ToString();

        }//***************************************************************************************************************************************************

        private void NmrMnMoney_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TbAdWeak_MouseClick(object sender, MouseEventArgs e)
        {// คลิกแล้วเป็นว่างเปล่า ***********************************************************************************************************************************
            tbAdWeak.Text = "";
        }

        private void Tb_gb01_brn_MouseClick(object sender, MouseEventArgs e)
        {
            tb_gb01_brn.Text = "";
        }//***************************************************************************************************************************************************

        private void Label85_Click(object sender, EventArgs e)
        {

        }

        private void Cb_gb01_babyBf61_CheckedChanged(object sender, EventArgs e)
        {//ควบคุม checkbox ***********************************************************************************************************************************
            mnr_gb01_babyBf61.Enabled = true;
            cb_gb01_babyN.Enabled = false;
            if (cb_gb01_babyBf61.Checked == false)
            {
                mnr_gb01_babyBf61.Enabled = false;
                cb_gb01_babyN.Enabled = true;
            }
        }

        private void Cb_gb01_babyAt61_CheckedChanged(object sender, EventArgs e)
        {
            mnr_gb01_babyAt61.Enabled = true;
            cb_gb01_babyN.Enabled = false;
            if (cb_gb01_babyAt61.Checked == false)
            {
                mnr_gb01_babyAt61.Enabled = false;
                cb_gb01_babyN.Enabled = true;
            }
        }

        private void Cb_gb01_Mn_CheckedChanged(object sender, EventArgs e)
        {
            cb_gb01_single.Enabled = false;
            cb_gb01_My.Enabled = false;
            if (cb_gb01_Mn.Checked == false)
            {
                cb_gb01_single.Enabled = true;
                cb_gb01_My.Enabled = true;
            }
        }

        private void Cb_gb01_single_CheckedChanged_1(object sender, EventArgs e)
        {
            cb_gb01_My.Enabled = false;
            cb_gb01_Mn.Enabled = false;
            if (cb_gb01_single.Checked == false)
            {
                cb_gb01_My.Enabled = true;
                cb_gb01_Mn.Enabled = true;
            }
        }

        private void CheckBox18_CheckedChanged(object sender, EventArgs e)
        {
            mnr_gb02_1.Enabled = true;
            if (checkBox18.Checked == false)
            {
                mnr_gb02_1.Enabled = false;
            }
        }

        private void CheckBox13_CheckedChanged(object sender, EventArgs e)
        {
            mnr_gb02_2.Enabled = true;
            if (checkBox13.Checked == false)
            {
                mnr_gb02_2.Enabled = false;
            }
        }

        private void CheckBox15_CheckedChanged(object sender, EventArgs e)
        {
            mnr_gb02_3.Enabled = true;
            if (checkBox15.Checked == false)
            {
                mnr_gb02_3.Enabled = false;
            }
        }

        private void CheckBox17_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown7.Enabled = true;
            if (checkBox17.Checked == false)
            {
                numericUpDown7.Enabled = false;
            }
        }

        private void CheckBox16_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown3.Enabled = true;
            if (checkBox16.Checked == false)
            {
                numericUpDown3.Enabled = false;
            }
        }

        private void CheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            textBox10.Enabled = true;
            if (checkBox12.Checked == false)
            {
                textBox10.Enabled = false;
            }
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            gb2558.Visible = true;
            if (radioButton5.Checked == false)
            {
                gb2558.Visible = false;
            }
            numericUpDown10.Value = 0;
            textBox14.Text = "";
            textBox13.Text = "";
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            gb2562.Visible = true;
            if (radioButton4.Checked == false)
            {
                gb2562.Visible = false;
            }
            numericUpDown9.Value = 0;
            x.Text = "";
            y.Text = "";
        }//******************************************************************************************************************************************

        private void Button9_Click(object sender, EventArgs e)
        {//กลุ่มที่ 3 ***********************************************************************************************************************************
            int homee = int.Parse(home.Text);
            int homee58 = int.Parse(numericUpDown10.Text);
            int home20;
            if (homee58 > 300000)
            {
                homee58 = 300000;
            }
            if (homee > 100000)
            {
                homee = 100000;
            }
            home20 = (homee58 * 20) / 100;
            textBox14.Text = home20.ToString();
            textBox11.Text = (home20/5).ToString();
            textBox13.Text = (homee + (home20 / 5)).ToString();
            sum_gb03 = int.Parse(textBox13.Text);
            label50.Text = sum_gb03.ToString();
        }//***************************************************************************************************************************************************

        private void Tb_gb04_1_MouseClick(object sender, MouseEventArgs e)
        {// คลิกแล้วเป็นว่างเปล่า ***********************************************************************************************************************************
            tb_gb04_1.Text = "";
        }

        private void Tb_gb04_2_MouseClick(object sender, MouseEventArgs e)
        {
            tb_gb04_2.Text = "";
        }

        private void Tb_gb04_3_MouseClick(object sender, MouseEventArgs e)
        {
            tb_gb04_3.Text = "";
        }

        private void Tb_gb04_4_MouseClick(object sender, MouseEventArgs e)
        {
            tb_gb04_4.Text = "";
        }

        private void Tb_gb04_5_MouseClick(object sender, MouseEventArgs e)
        {
            tb_gb04_5.Text = "";
        }

        private void Tb_gb04_6_MouseClick(object sender, MouseEventArgs e)
        {
            tb_gb04_6.Text = "";
        }// *******************************************************************************************************************************************

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {// reset 5*******************************************************************************************************************************************
            sum_gb05 = 0;
            numericUpDown19.Value = 0;
            numericUpDown18.Value = 0;
            numericUpDown17.Value = 0;
            numericUpDown16.Value = 0;
            numericUpDown15.Value = 0;
            numericUpDown14.Value = 0;
            numericUpDown13.Value = 0;
            numericUpDown12.Value = 0;
            textBox31.Text = "";
            label111.Text = sum_gb05.ToString();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {// reset 4 *******
            sum_gb04 = 0;
            tb_gb04_SumVet.Text = "0";
            tb_gb04_12.Text = "0";
            tb_gb04_22.Text = "0";
            tb_gb04_32.Text = "0";
            tb_gb04_42.Text = "0";
            tb_gb04_52.Text = "0";
            tb_gb04_62.Text = "0";
            mnr_gb04_72.Text = "0";
            tb_gb04_1.Text = "0";
            tb_gb04_2.Text = "0";
            tb_gb04_3.Text = "0";
            tb_gb04_4.Text = "0";
            tb_gb04_5.Text = "0";
            tb_gb04_6.Text = "0";
            mmr_gb04_7.Value = 0;
            tbSumVet.Text = "0";
            label109.Text = sum_gb04.ToString();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {// reset 3 *******
            sum_gb03 = 0;
            label50.Text = sum_gb03.ToString();
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {// reset 2 ********
            sum_gb02 = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            mnr_gb02_1.Enabled = false;
            mnr_gb02_2.Enabled = false;
            mnr_gb02_3.Enabled = false;
            numericUpDown7.Enabled = false;
            numericUpDown3.Enabled = false;
            textBox10.Enabled = false;
            textBox29.Text = "";
            label29.Text = sum_gb02.ToString();
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {// reset 1 *********
            sum_gb01 = 0;
            cb_gb01_single.Checked = false;
            cb_gb01_My.Checked = false;
            cb_gb01_Mn.Checked = false;
            cb_gb01_babyN.Checked = false;
            cb_gb01_babyBf61.Checked = false;
            cb_gb01_babyAt61.Checked = false;
            cb_gb01_Ad_Ma.Checked = false;
            cb_gb01_Ad_Fa.Checked = false;
            cb_gb01_AdNo.Checked = false;
            cb_gb01_AdFa.Checked = false;
            cb_gb01_AdMa.Checked = false;
            mnr_gb01_babyBf61.Value = 0;
            mnr_gb01_babyAt61.Value = 0;
            tbAdWeak.Text = "0";
            tb_gb01_brn.Text = "0";
            tb_gb01_VSum.Text = "";
            mnr_gb01_babyAt61.Enabled = false;
            mnr_gb01_babyBf61.Enabled = false;
            label85.Text = sum_gb01.ToString();
        }//********************************************************************************************************************************************

        private void BtCal_Click(object sender, EventArgs e)
        {//คำนวณภาษี ***********************************************************************************************************************************
            int SumAll1 = sum_gb01 + sum_gb02 + sum_gb03  + sum_gb05;//รวม ลดหย่อนได้ทั้งหมด
            int cal04 = SumAll1 * (10 / 100);//10% ของทั้งหมด
            if (sum_gb04 > cal04)//ภ้า > 10% = 10% นั้น
            {
                sum_gb04 = cal04;
            }
            SumAll = SumAll1 + sum_gb04;
            tbSumVet.Text = SumAll.ToString();
            int moneymax = yearmn - SumAll;
            int vet = 0;
            tbMoneyMax.Text = (moneymax).ToString();
            if (moneymax >= 150000)
            {
                vet = (moneymax * 5) / 100;
                tbTrueVet.Text = vet.ToString();
            }
            else if (moneymax >= 300000)
            {
                vet = (moneymax * 10) / 100;
                tbTrueVet.Text = vet.ToString();
            }
            else if (moneymax >= 500000)
            {
                vet = (moneymax * 15) / 100;
                tbTrueVet.Text = vet.ToString();
            }
            else if (moneymax >= 750000)
            {
                vet = (moneymax * 20) / 100;
                tbTrueVet.Text = vet.ToString();
            }
            else if (moneymax >= 1000000)
            {
                vet = (moneymax * 25) / 100;
                tbTrueVet.Text = vet.ToString();
            }
            else if (moneymax >= 2000000)
            {
                vet = (moneymax * 30) / 100;
                tbTrueVet.Text = vet.ToString();
            }
            else if (moneymax >= 5000000)
            {
                vet = (moneymax * 35) / 100;
                tbTrueVet.Text = vet.ToString();
            }
            else
            {
                vet = 0;
                tbTrueVet.Text = vet.ToString();
            }
            
        }//******************************************************************************************************************************************

        private void Button13_Click(object sender, EventArgs e)
        {//กลุ่มที่ 5 ***********************************************************************************************************************************
            int m_s =0,c_h=0;
            int shopH = int.Parse(numericUpDown19.Text);
            int sport = int.Parse(numericUpDown18.Text);
            int book = int.Parse(numericUpDown17.Text);
            int otop = int.Parse(numericUpDown16.Text);
            int maen = int.Parse(numericUpDown15.Text);
            int supT = int.Parse(numericUpDown14.Text);
            int homefix = int.Parse(numericUpDown13.Text);
            int carfix = int.Parse(numericUpDown12.Text);
            if (shopH > 15000)
            {
                shopH = 15000;
            }
            if (sport > 15000)
            {
                sport = 15000;
            }
            if (book > 15000)
            {
                book = 15000;
            }
            if (otop > 15000)
            {
                otop = 15000;
            }
            if (maen + supT > 20000)
            {
                m_s = 20000;
                maen = 0;
                supT = 0;
            }
            if (carfix + homefix > 100000)
            {
                c_h = 100000;
                carfix = 0;
                homefix = 0;
            }
            sum_gb05 = m_s + c_h + shopH + sport + book + otop + maen + supT + carfix + homefix;
            textBox31.Text = sum_gb05.ToString();
            label111.Text = sum_gb05.ToString();
        }//******************************************************************************************************************************************

        private void Bt_gb04_Click(object sender, EventArgs e)
        {//กลุ่มที่ 4 ***********************************************************************************************************************************
            int supL = int.Parse(tb_gb04_1.Text);
            int rush = int.Parse(tb_gb04_2.Text);
            int sport = int.Parse(tb_gb04_3.Text);
            int satha = int.Parse(tb_gb04_4.Text);
            int phabuik = int.Parse(tb_gb04_5.Text);
            int touphai = int.Parse(tb_gb04_6.Text);
            int karnmerng = int.Parse(mmr_gb04_7.Text);
            sum_gb04 = (((supL + rush + sport +  touphai) *2) + (satha + phabuik + karnmerng));
            tb_gb04_SumVet.Text = sum_gb04.ToString();
            tb_gb04_12.Text = (supL * 2).ToString();
            tb_gb04_22.Text = (rush * 2).ToString();
            tb_gb04_32.Text = (sport * 2).ToString();
            tb_gb04_42.Text = satha.ToString();
            tb_gb04_52.Text = phabuik.ToString();
            tb_gb04_62.Text = (touphai * 2).ToString();
            mnr_gb04_72.Text = karnmerng.ToString();
            label109.Text = sum_gb04.ToString();
        }//***********************************************************************************************************************************************

        private void Button8_Click(object sender, EventArgs e)
        {//กลุ่มที่ 3 2562 ***********************************************************************************************************************************
            int homee = int.Parse(home.Text);
            int home62 = int.Parse(numericUpDown9.Text);
            if (home62 > 5000000)
            {
                MessageBox.Show("ราคาบ้านเกิน 5,000,000 บาท");
                x.Text = "0";
            }
            else if (home62 <=500000)
            {
                if (home62 > 200000)
                {
                    home62 = 200000;
                    x.Text = home62.ToString();
                }
                x.Text = home62.ToString();
            }
            y.Text = (home62 + homee).ToString();
            sum_gb03 = int.Parse(x.Text);
            label50.Text = sum_gb03.ToString();
        }

        private void Cb_gb01_My_CheckedChanged_1(object sender, EventArgs e)
        {
            cb_gb01_single.Enabled = false;
            cb_gb01_Mn.Enabled = false;
            if (cb_gb01_My.Checked == false)
            {
                cb_gb01_single.Enabled = true;
                cb_gb01_Mn.Enabled = true;
            }
        }

        private void Cb_gb01_single_CheckStateChanged(object sender, EventArgs e)
        {

        }

        /*private void Cb_gb01_Mn_CheckedChanged(object sender, EventArgs e)
        {
            cb_gb01_My.Enabled = false;
            cb_gb01_single.Enabled = false;
        }*/
        private void Button12_Click(object sender, EventArgs e)
        {//กลุ่มที่ 2 ********************************************************************************************************************
            int snO=0,sangkomm=0,leanggg=0,mafa=0,life=0,heal=0,gbk=0;
            if (radioButton3.Checked)
            {
                snO = 10000;
            }
            if (checkBox18.Checked)
            {
                int sangkom = int.Parse(mnr_gb02_1.Text);
                sangkomm = sangkom;
                if (sangkomm > 9000)
                {
                    sangkomm = 9000;
                }
                lb_mnr_gb02_1.Text = sangkomm.ToString();
            }
            if (checkBox13.Checked)
            {
                int leangg=0;
                int leang = int.Parse(mnr_gb02_2.Text);
                leangg = leang;
                if (leangg > 10000)
                {
                    leanggg = leangg - 10000;
                    if (leanggg < ((15 * yearmn) / 100) && leanggg < 490000)
                    {
                        leanggg = 0;
                    }
                    lb_mnr_gb02_2.Text = leang.ToString();
                }
                else
                {
                    leanggg = leangg;
                    lb_mnr_gb02_2.Text = leangg.ToString();
                }
            }
            if (checkBox15.Checked)
            {
                mafa = int.Parse(mnr_gb02_3.Text);
                if (mafa > 15000)
                {
                    mafa = 15000;
                }
                lb_mnr_gb02_3.Text = mafa.ToString();
            }
            if (checkBox17.Checked)
            {
                life = int.Parse(numericUpDown7.Text);
                if (life > 100000)
                {
                    life = 100000;
                }
                b.Text = life.ToString();
            }
            if (checkBox16.Checked)
            {
                heal = int.Parse(numericUpDown3.Text);
                if (heal > 15000)
                {
                    heal = 15000;
                    if (heal + life > 100000)
                    {
                        heal = 0;
                    }
                }
                c.Text = heal.ToString();
            }
            if (checkBox12.Checked)
            {
                gbk = int.Parse(textBox10.Text);
                if (gbk>500000)
                {
                    gbk = 500000;
                }
                g.Text = gbk.ToString();
            }
            sum_gb02 = snO+sangkomm+leanggg+mafa+life+heal+gbk;
            textBox29.Text = sum_gb02.ToString();
            label29.Text = sum_gb02.ToString();
        }//***********************************************************************************************************************************
    }

}
