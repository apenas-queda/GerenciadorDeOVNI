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
            // Atualizar os botões ligar e desligar:
            btnDesligar.Enabled = ovni.Situacao;
            btnLigar.Enabled = !ovni.Situacao;
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
    }
    
}
