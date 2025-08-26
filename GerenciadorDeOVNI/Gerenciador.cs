using BibliotecaOVNI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOVNI
{
    public partial class Gerenciador : Form
    {
        // Objetos globais:
        BibliotecaOVNI.OVNI ovni;
        public Gerenciador(BibliotecaOVNI.OVNI ovni) // Obrigatoriamente deve-se iniciar passando um ovni
        {
            InitializeComponent();
            // "copiando" o ovni vindo da outra janela para um obj global:
            this.ovni = ovni;
            // Atualizar as informações:
            AtualizarInformacoes();
        }


        public void AtualizarInformacoes()
        {
            lblTripulantes.Text = $"Tripulantes: {ovni.QtdTripulantes}";
            lblAbduzidos.Text = $"Abduzidos: {ovni.QtdAbduzidos}";
            lblSituacao.Text = $"Situação: {(ovni.Situacao ? "Ligado" : "desligado")}";
            lblPlanetaAtual.Text = $"Planeta atual{ovni.PlanetaAtual}";
            cmbPlanetas.Text = ovni.PlanetaAtual;
            // Atualizar os botões ligar e desligar:
            btnDesligar.Enabled = ovni.Situacao;
            btnLigar.Enabled = !ovni.Situacao;

            // Ativar/Desativar o grb de acordo com o status da nave:
            grbAbduzidos.Enabled = ovni.Situacao;
            grbPlaneta.Enabled = ovni.Situacao;
            grbTripulantes.Enabled = ovni.Situacao;
            if (ovni.PlanetaAtual == "Terra")
            { ptbTerra.Visible = true; }
            else 
            { ptbTerra.Visible = false; }
            if (ovni.PlanetaAtual == "Krypton")
            { ptbKrypton.Visible = true; }
            else
            { ptbKrypton.Visible = false; }
            if(ovni.PlanetaAtual == "Gallifrey")
            { ptbGallifrey.Visible = true; }
            else
            { ptbGallifrey .Visible = false; }
            if (ovni.PlanetaAtual == "Pandora")
            { ptbPandora.Visible = true; }
            else
            { ptbPandora.Visible = false; }
            if (ovni.PlanetaAtual == "Miller")
            { ptbMiller.Visible = true; }
            else
            { ptbMiller.Visible = false; }

        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (ovni.Ligar())

            {
                MessageBox.Show(" O OVNI foi ligado!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" O ovni já está ligado!",
                       "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Atualizar as informações:
            AtualizarInformacoes();
            
            
            
            
            // Popular o combobox com os planetas validos:
            cmbPlanetas.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);
           
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            if (ovni.Desligar())

            {
                MessageBox.Show(" O OVNI foi Desligado!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" O ovni já está Desligado!",
                       "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Atualizar as informações:
            AtualizarInformacoes();
        }

        private void btnAdicionarTripulantes_Click(object sender, EventArgs e)
        {
            if (ovni.AdicionarTripulante())
            {

                MessageBox.Show("Tripulante adicionado!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" A nave ja está lotada de tripulantes!",
                       "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Atualizar as informações:
            AtualizarInformacoes();

        }

        private void btnRemoverTripulantes_Click(object sender, EventArgs e)
        {
            if (ovni.RemoverTripulante())
            {

                MessageBox.Show("Tripulante Removido!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" A nave está com falta de tripulantes!",
                       "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Atualizar as informações:
            AtualizarInformacoes();


        }

        private void btnAdicionarAbduzidos_Click(object sender, EventArgs e)
        {
            if (ovni.Abduzir())
            {

                MessageBox.Show("Abduzido com sucesso!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" A nave está lotada de abduzidos!",
                       "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Atualizar as informações:
            AtualizarInformacoes();
        }

        private void btnRomoverAbduzidos_Click(object sender, EventArgs e)
        {
            if (ovni.Desabduzir())
            {

                MessageBox.Show("Devolvido com sucesso!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" A nave está vazia de abduzidos!",
                       "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Atualizar as informações:
            AtualizarInformacoes();
        }

        private void btnMudarPlaneta_Click(object sender, EventArgs e)
        {

            if (ovni.MudarPlaneta(cmbPlanetas.Text))
            {

                MessageBox.Show("Viagem feita com sucesso!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            

            }
            else
            {
                MessageBox.Show(" A nave já está no planeta!",
                       "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Atualizar as informações:
            AtualizarInformacoes();
            
        }

        private void btnRetonarPlaneta_Click(object sender, EventArgs e)
        {
            if (ovni.RetornarAoPlanetaDeOrigem())
            {

                MessageBox.Show("Retorno com sucesso!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" A nave já está no planeta!",
                       "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Atualizar as informações:
            AtualizarInformacoes();
        }
    }
}
    

