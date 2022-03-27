using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Media;
namespace JogoDaForca
{
    public partial class Form1 : Form
    {
        const int maxTentativas = 7;
        List<int> palavrasSelecionadas = new List<int>();
        string[] imageURI = {
            "FORCA_0.png","FORCA_1.png",
            "FORCA_2.png","FORCA_3.png",
            "FORCA_4.png","FORCA_5.png",
            "FORCA_6.png","FORCA_7.png"
        };
        string palavraAtual = "";
        string temaAtual = "";
        int pontos = 0;
        int acertos = 0;
        int tentativas = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temaAtual = EscolherTema.show();
            
            if (temaAtual == null)
                Application.Exit();
            else
                novoJogo();
        }

        private void handleButton(object sender, EventArgs e)
        {
            if (!lblTitulo.Focus())
                lblTitulo.Focus();

            Button button = (Button) sender;

            button.FlatAppearance.BorderSize = 1;
            button.Enabled = false;
            
            manipularEscolha(button.Text);
        }
        private void manipularEscolha(string control)
        {
            bool acertou = false;
            for (int x = 0; x < palavraAtual.Length; x++)
            {
                char letraAtual = verificarCodificacao(char.ToUpper(palavraAtual[x]));
                if (char.Parse(control) == letraAtual)
                {
                    acertou = true;
                    acertos += 1;
                    mostrarLetra(x, char.ToUpper(palavraAtual[x]));
                    
                    if (acertos >= 3)
                        desativarBotao("DICA");
                }
                if (x == palavraAtual.Length - 1 && !acertou)
                {
                    errou(1);
                    break;
                }
            }
            if (ganhou())
            {
                pontos += 1;
                tocarSom("ganhou");
                novoJogo();
                return;
            }
            if (perdeu())
            {
                tocarSom("perdeu");
                fimDeJogo();
                return;
            }
        }
        private void mostrarLetra(int pos, char letra) 
        {
            int index = 0;
            foreach (Control c in pPalavra.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if (index < pos)
                    index++;
                else
                {
                    if (c.GetType() == typeof(Label))
                    {
                        Label lbl = (Label) c;
                        if (lbl != null)
                        {
                            lbl.Text = letra + "";
                            break;
                        }
                    }
                }
            }
        }
        private char verificarCodificacao(char letra)
        {
            int ascChar = letra;
            
            if (ascChar >= 192 && ascChar <= 197)
                return 'A';
            if (ascChar == 199)
                return 'C';
            if (ascChar >= 200 && ascChar <= 203)
                return 'E';
            if (ascChar >= 204 && ascChar <= 207)
                return 'I';
            if (ascChar >= 210 && ascChar <= 214)
                return 'O';
            if (ascChar >= 217 && ascChar <= 220)
                return 'U';

            return letra;
        }
        private string handleTemaURI(string palavra)
        {
            string result = "";
            for(int x = 0; x < palavra.Length; x++)
                result += verificarCodificacao(palavra[x]);
            return result.ToLower();
        }
        private void errou(int vezes){
            for(int x = 0; x < vezes; x++)
            {
                tentativas += 1;
                lblTentativas.Text = "" + (maxTentativas - tentativas);

                pbForca.Image = Image.FromFile(@"../../../img/src/" + imageURI[tentativas]);

                tocarSom("errou");
            }
        }
        private bool perdeu()
        {
            return this.tentativas == maxTentativas;
        }
        private bool ganhou()
        {
            return this.acertos == this.palavraAtual.Length;
        }
        private void fimDeJogo()
        {
            int result = CustomMessageBox.show(palavraAtual, pontos.ToString());
            tentativas = 0;
            pontos = 0;

            if (result > 0)
                novoJogo();
            else
                Application.Exit();
        }
        private string gerarPalavra() 
        {
            string URI = @"../../../utils/words_" + handleTemaURI(temaAtual) + ".txt";
            int qtdItens = File.ReadLines(URI).Count();
            int randIndice = new Random().Next(0, qtdItens);


            while(palavrasSelecionadas.Contains(randIndice) && palavrasSelecionadas.Count < qtdItens)
                randIndice = new Random().Next(0, qtdItens);

            if(palavrasSelecionadas.Count == qtdItens)
                palavrasSelecionadas.Clear();

            palavrasSelecionadas.Add(randIndice);

            return File.ReadLines(URI).Skip(randIndice).Take(1).First();
        }
        private void novoJogo()
        {
            lblTitulo.Focus();
            lblTentativas.Text = maxTentativas + "";
            lblPontos.Text = pontos + "";
            lblTema.Text = temaAtual;

            palavraAtual = gerarPalavra();
            
            pbForca.Image = Image.FromFile(@"../../../img/src/" + imageURI[0]);
            
            tentativas = 0;
            acertos = 0;
            
            pPalavra.Controls.Clear();
            
            statusButton(true);

            esconderCorrespondencia();
        }
        private void esconderCorrespondencia()
        {
            pPalavra.Controls.Clear();
            int margin = 0;
            float porcent = ((palavraAtual.Length / (float)pPalavra.Size.Width) * 100);
            for (int x = 0; x < palavraAtual.Length; x++)
            {
                Label lblLetra = new Label();
                lblLetra.Text = "_";
                lblLetra.Left = margin;
                lblLetra.Top = pPalavra.Size.Height / 2;
                lblLetra.Font = new Font("Ink Free", Math.Abs(porcent - 26), FontStyle.Bold);
                lblLetra.AutoSize = true;

                lblLetra.Parent = pPalavra;

                margin += lblLetra.Size.Width + 1;
            }
        }
        private void statusButton(bool status)
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button btn = (Button)c;
                    if (btn != null)
                    {
                        if (palavraAtual.Length < 4 && btn.Text.Equals("DICA"))
                        {
                            btn.FlatAppearance.BorderSize = 1;
                            btn.Enabled = false;
                        }
                        else
                        {
                            btn.FlatAppearance.BorderSize = 2;
                            btn.Enabled = status;
                        }
                    }
                }
            }
        }
        private void tocarSom(string control)
        {
            SoundPlayer player = new SoundPlayer("../../../utils/" + control + ".wav");
            player.Play();
        }
        private void manipularTrocaPalavra(object sender, EventArgs e)
        {
            palavraAtual = gerarPalavra();
            esconderCorrespondencia();
            statusButton(true);
            acertos = 0;
            
            errou(2);

            Button btn = (Button)sender;
            btn.FlatAppearance.BorderSize = 1;
            btn.Enabled = false;

        }
        private void manipularDica(object obj, EventArgs e)
        {
            int randIndice = new Random().Next(0, palavraAtual.Length);
            while (!letraDisponivel(randIndice))
                randIndice = new Random().Next(0, palavraAtual.Length);

            string letraAtual = verificarCodificacao(char.ToUpper(palavraAtual[randIndice])).ToString();
            manipularEscolha(letraAtual);
            desativarBotao(letraAtual);
        }
        private bool letraDisponivel(int pos)
        {
            int index = 0;
            foreach (Control c in pPalavra.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if (index < pos)
                    index++;
                else
                {
                    Label lbl = (Label)c;
                    if (lbl != null)
                    {
                        if (lbl.Text.Equals("_"))
                            return true;
                        else
                            return false;
                    }
                }
            }
            return false;
        }
        private void desativarBotao(string id)
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button btn = (Button)c;
                    if (btn != null)
                    {
                        if (btn.Text.Equals(id))
                        {
                            btn.FlatAppearance.BorderSize = 1;
                            btn.Enabled = false;
                        }
                    }
                }
            }
        }
    }
}
