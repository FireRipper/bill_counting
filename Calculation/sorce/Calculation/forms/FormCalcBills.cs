using System;
using System.Windows.Forms;

namespace Calculation
{
    public partial class Calculation : Form
    {
        public Calculation()
        {
            InitializeComponent();
            sidePanel.Height = btn_uah.Height;
            sidePanel.Top = btn_uah.Top;
            formCalculationUAH1.BringToFront();
        }
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_uah_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_uah.Height;
            formCalculationUAH1.BringToFront();
            sidePanel.Top = btn_uah.Top;
        }

        private void btn_usd_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_usd.Height;
            formCalculationUSD1.BringToFront();
            sidePanel.Top = btn_usd.Top;
        }

        private void btn_eur_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_eur.Height;
            formCalculationEUR1.BringToFront();
            sidePanel.Top = btn_eur.Top;
        }
    }
}
