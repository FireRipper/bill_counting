using System;
using System.Windows.Forms;

namespace Calculation
{
    public partial class Calculation : Form
    {
        public int[] val_​for_calc = new int[] { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

        public int bill_500, res_1, bill_200, res_2, bill_100, res_3, bill_50, res_4,
                   bill_20, res_5, bill_10, res_6, bill_5, res_7, bill_2, res_8, bill_1, res_9;

        public Calculation()
        {
            InitializeComponent();
        }

        public void Calculate()
        {
            calc_500();
            calc_200();
            calc_100();
            calc_50();
            calc_20();
            calc_10();
            calc_5();
            calc_2();
            calc_1();
            sum_all_bills();
        }

        public void sum_all_bills()
        {
            int results_sum;

            res_1 = Convert.ToInt32(label21.Text);
            res_2 = Convert.ToInt32(label20.Text);
            res_3 = Convert.ToInt32(label19.Text);
            res_4 = Convert.ToInt32(label18.Text);
            res_5 = Convert.ToInt32(label17.Text);
            res_6 = Convert.ToInt32(label16.Text);
            res_7 = Convert.ToInt32(label15.Text);
            res_8 = Convert.ToInt32(label14.Text);
            res_9 = Convert.ToInt32(label13.Text);

            results_sum = res_1 + res_2 + res_3 + res_4 + res_5 + res_6 + res_7 + res_8 + res_9;

            label22.Text = Convert.ToString("Итого: " + results_sum + " грн.");
        }

        private void calc_500()
        {
            if (string.IsNullOrEmpty(mTB1.Text))
            {
                label21.Text = Convert.ToString("0");
            }
            else
            {
                bill_500 = Convert.ToInt32(mTB1.Text);

                int[] bills = new int[] { bill_500 };

                res_1 = val_​for_calc[0] * bills[0];

                label21.Text = Convert.ToString(res_1);
            }
        }

        private void calc_200()
        {
            if (string.IsNullOrEmpty(mTB2.Text))
            {
                label20.Text = Convert.ToString("0");
            }
            else
            {
                bill_200 = Convert.ToInt32(mTB2.Text);

                int[] bills = new int[] { bill_200 };

                res_2 = val_​for_calc[1] * bills[0];

                label20.Text = Convert.ToString(res_2);
            }
        }

        private void calc_100()
        {
            if (string.IsNullOrEmpty(mTB3.Text))
            {
                label19.Text = Convert.ToString("0");
            }
            else
            {
                bill_100 = Convert.ToInt32(mTB3.Text);

                int[] bills = new int[] { bill_100 };

                res_3 = val_​for_calc[2] * bills[0];

                label19.Text = Convert.ToString(res_3);
            }
        }

        private void calc_50()
        {
            if (string.IsNullOrEmpty(mTB4.Text))
            {
                label18.Text = Convert.ToString("0");
            }
            else
            {
                bill_50 = Convert.ToInt32(mTB4.Text);

                int[] bills = new int[] { bill_50 };

                res_4 = val_​for_calc[3] * bills[0];

                label18.Text = Convert.ToString(res_4);
            }
        }

        private void mTB1_MouseClick(object sender, MouseEventArgs e)
        {
            ((MaskedTextBox)sender).SelectionStart = 0;
        }

        private void mTB2_MouseClick(object sender, MouseEventArgs e)
        {
            ((MaskedTextBox)sender).SelectionStart = 0;
        }

        private void mTB3_MouseClick(object sender, MouseEventArgs e)
        {
            ((MaskedTextBox)sender).SelectionStart = 0;
        }

        private void mTB4_MouseClick(object sender, MouseEventArgs e)
        {
            ((MaskedTextBox)sender).SelectionStart = 0;
        }

        private void mTB5_MouseClick(object sender, MouseEventArgs e)
        {
            ((MaskedTextBox)sender).SelectionStart = 0;
        }

        private void mTB6_MouseClick(object sender, MouseEventArgs e)
        {
            ((MaskedTextBox)sender).SelectionStart = 0;
        }

        private void mTB7_MouseClick(object sender, MouseEventArgs e)
        {
            ((MaskedTextBox)sender).SelectionStart = 0;
        }

        private void mTB8_MouseClick(object sender, MouseEventArgs e)
        {
            ((MaskedTextBox)sender).SelectionStart = 0;
        }

        private void mTB9_MouseClick(object sender, MouseEventArgs e)
        {
            ((MaskedTextBox)sender).SelectionStart = 0;
        }

        private void calc_20()
        {
            if (string.IsNullOrEmpty(mTB5.Text))
            {
                label17.Text = Convert.ToString("0"); 
            }
            else
            {
                bill_20 = Convert.ToInt32(mTB5.Text);

                int[] bills = new int[] { bill_20 };

                res_5 = val_​for_calc[4] * bills[0];

                label17.Text = Convert.ToString(res_5);
            }
        }

        private void calc_10()
        {
            if (string.IsNullOrEmpty(mTB6.Text))
            {
                label16.Text = Convert.ToString("0");
            }
            else
            {
                bill_10 = Convert.ToInt32(mTB6.Text);

                int[] bills = new int[] { bill_10 };

                res_6 = val_​for_calc[5] * bills[0];

                label16.Text = Convert.ToString(res_6);
            }
        }

        private void calc_5()
        {
            if (string.IsNullOrEmpty(mTB7.Text))
            {
                label15.Text = Convert.ToString("0");
            }
            else
            {
                bill_5 = Convert.ToInt32(mTB7.Text);

                int[] bills = new int[] { bill_5 };

                res_7 = val_​for_calc[6] * bills[0];

                label15.Text = Convert.ToString(res_7);
            }
        }

        private void calc_2()
        {
            if (string.IsNullOrEmpty(mTB8.Text))
            {
                label14.Text = Convert.ToString("0");
            }
            else
            {
                bill_2 = Convert.ToInt32(mTB8.Text);

                int[] bills = new int[] { bill_2 };

                res_8 = val_​for_calc[7] * bills[0];

                label14.Text = Convert.ToString(res_8);
            }
        }

        private void calc_1()
        {
            if (string.IsNullOrEmpty(mTB9.Text))
            {
                label13.Text = Convert.ToString("0");
            }
            else
            {
                bill_1 = Convert.ToInt32(mTB9.Text);

                int[] bills = new int[] { bill_1 };

                res_9 = val_​for_calc[8] * bills[0];

                label13.Text = Convert.ToString(res_9);
            }
        }

        private void Btn_Clear_all_mtb(object sender, EventArgs e)
        {
            ClearAlltextBox();
            ClearLabels();
            mTB1.Focus();
        }

        private void mTB1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void mTB2_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void mTB3_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void mTB4_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void mTB5_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void mTB6_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void mTB7_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void mTB8_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void mTB9_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void ClearAlltextBox()
        {
            foreach (Control c in Controls)
            {
                if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Clear();
                }
            }
        }
        
        private void ClearLabels()
        {
            for (int i = 13; i <=21; i++)
            {
                this.Controls.Find("label" + i, true)[0].Text = "0";
            }
        }
    }
}
