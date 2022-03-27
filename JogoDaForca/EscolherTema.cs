using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class EscolherTema : Form
    {
        private static EscolherTema et;
        private static string TEMA;
        
        public EscolherTema()
        {
            InitializeComponent();
        }
        public static string show()
        {
            et = new EscolherTema();
            et.ShowDialog();
            return TEMA;
        }
        
        private void EscolherTema_Load(object sender, EventArgs e)
        {
            
        }
        public void handleAnimais(object sender, EventArgs e)
        {
            TEMA = "ANIMAIS";
            et.Dispose();
        }
        public void handleProfissoes(object sender, EventArgs e)
        {
            TEMA = "PROFISSÕES";
            et.Dispose();
        }
        public void handlePaises(object sender, EventArgs e)
        {
            TEMA = "PAÍSES";
            et.Dispose();
        }
        public void handleAlimentos(object sender, EventArgs e)
        {
            TEMA = "ALIMENTOS";
            et.Dispose();
        }
    }
}
