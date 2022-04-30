using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedraPapelTesoura
{
    public partial class Jokenpo : System.Windows.Forms.Form
    {
        public Jokenpo()
        {
            InitializeComponent();
        }
        enum Opcoes { Pedra, Papel, Tesoura };
        Opcoes player = new Opcoes();
        Opcoes comp = new Opcoes();
        Random gerador = new Random();
        int resultado = 0;

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            lbl_jog.Text = "0";
            lbl_pc.Text = "0";
            pic_player.BackgroundImage = null;
            pic_comp.BackgroundImage = null;

        }

        private void btn_saida_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_tesoura_Click(object sender, EventArgs e)
        {
            player = Opcoes.Tesoura;
            Escolha();
            EscolhaComp();
            Vencedor();
        }

        private void btn_papel_Click(object sender, EventArgs e)
        {
            player = Opcoes.Papel;
            Escolha();
            EscolhaComp();
            Vencedor();
        }

        private void btn_pedra_Click(object sender, EventArgs e)
        {
            player = Opcoes.Pedra;
            Escolha();
            EscolhaComp();
            Vencedor();
        }
        void Escolha()
        {
            switch (player)
            {
                case Opcoes.Pedra:
                    pic_player.BackgroundImage = Properties.Resources.pedra;
                    break;
                case Opcoes.Papel:
                    pic_player.BackgroundImage = Properties.Resources.papel;
                    break;
                case Opcoes.Tesoura:
                    pic_player.BackgroundImage = Properties.Resources.tesoura;
                    break;
            }
        }
        void EscolhaComp()
        {
            int num_comp = gerador.Next(1, 4);
            switch (num_comp)
            {
                case 1:
                    comp = Opcoes.Pedra;
                    pic_comp.BackgroundImage = Properties.Resources.pedra;
                    break;
                case 2:
                    comp = Opcoes.Papel;
                    pic_comp.BackgroundImage = Properties.Resources.papel;
                    break;
                case 3:
                    comp = Opcoes.Tesoura;
                    pic_comp.BackgroundImage = Properties.Resources.tesoura;
                    break;
            }
        }
        void Vencedor()
        {
            /* Resultado 
               0 = Empate
              1 = Vitória
              2 = Derrota
            */
            switch (player)
            {
                case Opcoes.Pedra:
                    if (comp == Opcoes.Pedra)
                        resultado = 0;
                    else if (comp == Opcoes.Papel)
                        resultado = 2;
                    else if (comp == Opcoes.Tesoura)
                        resultado = 1;
                    break;
                case Opcoes.Papel:
                    if (comp == Opcoes.Pedra)
                        resultado = 1;
                    else if (comp == Opcoes.Papel)
                        resultado = 0;
                    else if (comp == Opcoes.Tesoura)
                        resultado = 2;
                    break;
                case Opcoes.Tesoura:
                    if (comp == Opcoes.Pedra)
                        resultado = 2;
                    else if (comp == Opcoes.Papel)
                        resultado = 1;
                    else if (comp == Opcoes.Tesoura)
                        resultado = 0;
                    break;
            }
            if (resultado == 1)
            {
                lbl_jog.Text = (int.Parse(lbl_jog.Text) + 1).ToString();
            }
            else if (resultado == 2)
            {
                lbl_pc.Text = (int.Parse(lbl_pc.Text) + 1).ToString();
            }

            // Limite de Pontuação

            if (lbl_jog.Text == "1000" || lbl_jog.Text == "1000")
            {
                lbl_jog.Text = "0";
                lbl_pc.Text = "0";
            }
        }
    }
}
