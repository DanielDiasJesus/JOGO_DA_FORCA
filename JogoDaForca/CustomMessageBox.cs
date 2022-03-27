using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class CustomMessageBox : Form
    {
        static CustomMessageBox cmb;
        static int BUTTON_ID;

        public CustomMessageBox()
        {
            InitializeComponent();
        }
        public static int show(string palavra, string pontos)
        {
            cmb = new CustomMessageBox();

            cmb.Left = 678;
            cmb.Top = 190;

            cmb.lblPalavra.Text = palavra;
            cmb.lblPontos.Text = pontos;

            cmb.ShowDialog();
            return BUTTON_ID;
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            BUTTON_ID = 0;
            cmb.Dispose();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            BUTTON_ID = 1;
            cmb.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
