namespace GerenciadorDeOVNI
{
    partial class Gerenciador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbInfomacoes = new System.Windows.Forms.GroupBox();
            this.lblPlanetaAtual = new System.Windows.Forms.Label();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnLigar = new System.Windows.Forms.Button();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.grbTripulantes = new System.Windows.Forms.GroupBox();
            this.btnRemoverTripulantes = new System.Windows.Forms.Button();
            this.btnAdicionarTripulantes = new System.Windows.Forms.Button();
            this.grbAbduzidos = new System.Windows.Forms.GroupBox();
            this.btnRomoverAbduzidos = new System.Windows.Forms.Button();
            this.btnAdicionarAbduzidos = new System.Windows.Forms.Button();
            this.grbPlaneta = new System.Windows.Forms.GroupBox();
            this.btnRetonarPlaneta = new System.Windows.Forms.Button();
            this.btnMudarPlaneta = new System.Windows.Forms.Button();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.ptbMiller = new System.Windows.Forms.PictureBox();
            this.ptbPandora = new System.Windows.Forms.PictureBox();
            this.ptbGallifrey = new System.Windows.Forms.PictureBox();
            this.ptbKrypton = new System.Windows.Forms.PictureBox();
            this.ptbTerra = new System.Windows.Forms.PictureBox();
            this.ptb = new System.Windows.Forms.PictureBox();
            this.grbInfomacoes.SuspendLayout();
            this.grbTripulantes.SuspendLayout();
            this.grbAbduzidos.SuspendLayout();
            this.grbPlaneta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMiller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPandora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGallifrey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKrypton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTerra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInfomacoes
            // 
            this.grbInfomacoes.Controls.Add(this.lblPlanetaAtual);
            this.grbInfomacoes.Controls.Add(this.btnDesligar);
            this.grbInfomacoes.Controls.Add(this.btnLigar);
            this.grbInfomacoes.Controls.Add(this.lblAbduzidos);
            this.grbInfomacoes.Controls.Add(this.lblTripulantes);
            this.grbInfomacoes.Controls.Add(this.lblSituacao);
            this.grbInfomacoes.Location = new System.Drawing.Point(38, 60);
            this.grbInfomacoes.Name = "grbInfomacoes";
            this.grbInfomacoes.Size = new System.Drawing.Size(248, 242);
            this.grbInfomacoes.TabIndex = 0;
            this.grbInfomacoes.TabStop = false;
            this.grbInfomacoes.Text = "Informações";
            // 
            // lblPlanetaAtual
            // 
            this.lblPlanetaAtual.AutoSize = true;
            this.lblPlanetaAtual.Location = new System.Drawing.Point(6, 100);
            this.lblPlanetaAtual.Name = "lblPlanetaAtual";
            this.lblPlanetaAtual.Size = new System.Drawing.Size(73, 13);
            this.lblPlanetaAtual.TabIndex = 5;
            this.lblPlanetaAtual.Text = "Planeta Atual:";
            // 
            // btnDesligar
            // 
            this.btnDesligar.Location = new System.Drawing.Point(6, 194);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(236, 43);
            this.btnDesligar.TabIndex = 4;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnLigar
            // 
            this.btnLigar.Location = new System.Drawing.Point(6, 126);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(236, 43);
            this.btnLigar.TabIndex = 3;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(6, 77);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(59, 13);
            this.lblAbduzidos.TabIndex = 2;
            this.lblAbduzidos.Text = "Abduzidos:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(6, 52);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(62, 13);
            this.lblTripulantes.TabIndex = 1;
            this.lblTripulantes.Text = "Tripulantes:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(6, 26);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:";
            // 
            // grbTripulantes
            // 
            this.grbTripulantes.Controls.Add(this.btnRemoverTripulantes);
            this.grbTripulantes.Controls.Add(this.btnAdicionarTripulantes);
            this.grbTripulantes.Location = new System.Drawing.Point(38, 325);
            this.grbTripulantes.Name = "grbTripulantes";
            this.grbTripulantes.Size = new System.Drawing.Size(248, 131);
            this.grbTripulantes.TabIndex = 1;
            this.grbTripulantes.TabStop = false;
            this.grbTripulantes.Text = "Tripulantes";
            // 
            // btnRemoverTripulantes
            // 
            this.btnRemoverTripulantes.Location = new System.Drawing.Point(9, 80);
            this.btnRemoverTripulantes.Name = "btnRemoverTripulantes";
            this.btnRemoverTripulantes.Size = new System.Drawing.Size(233, 33);
            this.btnRemoverTripulantes.TabIndex = 1;
            this.btnRemoverTripulantes.Text = "Remover";
            this.btnRemoverTripulantes.UseVisualStyleBackColor = true;
            this.btnRemoverTripulantes.Click += new System.EventHandler(this.btnRemoverTripulantes_Click);
            // 
            // btnAdicionarTripulantes
            // 
            this.btnAdicionarTripulantes.Location = new System.Drawing.Point(9, 32);
            this.btnAdicionarTripulantes.Name = "btnAdicionarTripulantes";
            this.btnAdicionarTripulantes.Size = new System.Drawing.Size(233, 33);
            this.btnAdicionarTripulantes.TabIndex = 0;
            this.btnAdicionarTripulantes.Text = "Adicionar";
            this.btnAdicionarTripulantes.UseVisualStyleBackColor = true;
            this.btnAdicionarTripulantes.Click += new System.EventHandler(this.btnAdicionarTripulantes_Click);
            // 
            // grbAbduzidos
            // 
            this.grbAbduzidos.Controls.Add(this.btnRomoverAbduzidos);
            this.grbAbduzidos.Controls.Add(this.btnAdicionarAbduzidos);
            this.grbAbduzidos.Location = new System.Drawing.Point(324, 60);
            this.grbAbduzidos.Name = "grbAbduzidos";
            this.grbAbduzidos.Size = new System.Drawing.Size(248, 131);
            this.grbAbduzidos.TabIndex = 2;
            this.grbAbduzidos.TabStop = false;
            this.grbAbduzidos.Text = "Abduzidos";
            // 
            // btnRomoverAbduzidos
            // 
            this.btnRomoverAbduzidos.Location = new System.Drawing.Point(9, 80);
            this.btnRomoverAbduzidos.Name = "btnRomoverAbduzidos";
            this.btnRomoverAbduzidos.Size = new System.Drawing.Size(233, 33);
            this.btnRomoverAbduzidos.TabIndex = 1;
            this.btnRomoverAbduzidos.Text = "Remover";
            this.btnRomoverAbduzidos.UseVisualStyleBackColor = true;
            this.btnRomoverAbduzidos.Click += new System.EventHandler(this.btnRomoverAbduzidos_Click);
            // 
            // btnAdicionarAbduzidos
            // 
            this.btnAdicionarAbduzidos.Location = new System.Drawing.Point(9, 32);
            this.btnAdicionarAbduzidos.Name = "btnAdicionarAbduzidos";
            this.btnAdicionarAbduzidos.Size = new System.Drawing.Size(233, 33);
            this.btnAdicionarAbduzidos.TabIndex = 0;
            this.btnAdicionarAbduzidos.Text = "Adicionar";
            this.btnAdicionarAbduzidos.UseVisualStyleBackColor = true;
            this.btnAdicionarAbduzidos.Click += new System.EventHandler(this.btnAdicionarAbduzidos_Click);
            // 
            // grbPlaneta
            // 
            this.grbPlaneta.Controls.Add(this.btnRetonarPlaneta);
            this.grbPlaneta.Controls.Add(this.btnMudarPlaneta);
            this.grbPlaneta.Controls.Add(this.cmbPlanetas);
            this.grbPlaneta.Location = new System.Drawing.Point(324, 197);
            this.grbPlaneta.Name = "grbPlaneta";
            this.grbPlaneta.Size = new System.Drawing.Size(248, 259);
            this.grbPlaneta.TabIndex = 3;
            this.grbPlaneta.TabStop = false;
            this.grbPlaneta.Text = "Planeta";
            // 
            // btnRetonarPlaneta
            // 
            this.btnRetonarPlaneta.Location = new System.Drawing.Point(6, 160);
            this.btnRetonarPlaneta.Name = "btnRetonarPlaneta";
            this.btnRetonarPlaneta.Size = new System.Drawing.Size(236, 81);
            this.btnRetonarPlaneta.TabIndex = 3;
            this.btnRetonarPlaneta.Text = "Retonar";
            this.btnRetonarPlaneta.UseVisualStyleBackColor = true;
            this.btnRetonarPlaneta.Click += new System.EventHandler(this.btnRetonarPlaneta_Click);
            // 
            // btnMudarPlaneta
            // 
            this.btnMudarPlaneta.Location = new System.Drawing.Point(6, 77);
            this.btnMudarPlaneta.Name = "btnMudarPlaneta";
            this.btnMudarPlaneta.Size = new System.Drawing.Size(236, 77);
            this.btnMudarPlaneta.TabIndex = 2;
            this.btnMudarPlaneta.Text = "Mudar Planeta";
            this.btnMudarPlaneta.UseVisualStyleBackColor = true;
            this.btnMudarPlaneta.Click += new System.EventHandler(this.btnMudarPlaneta_Click);
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(6, 41);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(236, 21);
            this.cmbPlanetas.TabIndex = 0;
            // 
            // ptbMiller
            // 
            this.ptbMiller.Image = global::GerenciadorDeOVNI.Properties.Resources.Miller;
            this.ptbMiller.Location = new System.Drawing.Point(670, 37);
            this.ptbMiller.Name = "ptbMiller";
            this.ptbMiller.Size = new System.Drawing.Size(224, 211);
            this.ptbMiller.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMiller.TabIndex = 9;
            this.ptbMiller.TabStop = false;
            // 
            // ptbPandora
            // 
            this.ptbPandora.Image = global::GerenciadorDeOVNI.Properties.Resources.Pandora;
            this.ptbPandora.Location = new System.Drawing.Point(727, 37);
            this.ptbPandora.Name = "ptbPandora";
            this.ptbPandora.Size = new System.Drawing.Size(167, 201);
            this.ptbPandora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPandora.TabIndex = 8;
            this.ptbPandora.TabStop = false;
            // 
            // ptbGallifrey
            // 
            this.ptbGallifrey.Image = global::GerenciadorDeOVNI.Properties.Resources.Gallifrey;
            this.ptbGallifrey.Location = new System.Drawing.Point(645, 37);
            this.ptbGallifrey.Name = "ptbGallifrey";
            this.ptbGallifrey.Size = new System.Drawing.Size(249, 201);
            this.ptbGallifrey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbGallifrey.TabIndex = 7;
            this.ptbGallifrey.TabStop = false;
            // 
            // ptbKrypton
            // 
            this.ptbKrypton.Image = global::GerenciadorDeOVNI.Properties.Resources.Kripton;
            this.ptbKrypton.Location = new System.Drawing.Point(706, 37);
            this.ptbKrypton.Name = "ptbKrypton";
            this.ptbKrypton.Size = new System.Drawing.Size(188, 190);
            this.ptbKrypton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbKrypton.TabIndex = 6;
            this.ptbKrypton.TabStop = false;
            // 
            // ptbTerra
            // 
            this.ptbTerra.Image = global::GerenciadorDeOVNI.Properties.Resources.Planeta_terra;
            this.ptbTerra.Location = new System.Drawing.Point(778, 37);
            this.ptbTerra.Margin = new System.Windows.Forms.Padding(0);
            this.ptbTerra.Name = "ptbTerra";
            this.ptbTerra.Size = new System.Drawing.Size(116, 134);
            this.ptbTerra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTerra.TabIndex = 5;
            this.ptbTerra.TabStop = false;
            // 
            // ptb
            // 
            this.ptb.Image = global::GerenciadorDeOVNI.Properties.Resources.Goodstuff_No_Nonsense_Free_Space_Alien_obduction_1024__1_;
            this.ptb.Location = new System.Drawing.Point(572, 258);
            this.ptb.Name = "ptb";
            this.ptb.Size = new System.Drawing.Size(322, 290);
            this.ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb.TabIndex = 4;
            this.ptb.TabStop = false;
            // 
            // Gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 560);
            this.Controls.Add(this.ptbMiller);
            this.Controls.Add(this.ptbPandora);
            this.Controls.Add(this.ptbKrypton);
            this.Controls.Add(this.ptbGallifrey);
            this.Controls.Add(this.ptbTerra);
            this.Controls.Add(this.ptb);
            this.Controls.Add(this.grbPlaneta);
            this.Controls.Add(this.grbAbduzidos);
            this.Controls.Add(this.grbTripulantes);
            this.Controls.Add(this.grbInfomacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador";
            this.grbInfomacoes.ResumeLayout(false);
            this.grbInfomacoes.PerformLayout();
            this.grbTripulantes.ResumeLayout(false);
            this.grbAbduzidos.ResumeLayout(false);
            this.grbPlaneta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMiller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPandora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGallifrey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKrypton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTerra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfomacoes;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.GroupBox grbTripulantes;
        private System.Windows.Forms.Button btnRemoverTripulantes;
        private System.Windows.Forms.Button btnAdicionarTripulantes;
        private System.Windows.Forms.GroupBox grbAbduzidos;
        private System.Windows.Forms.Button btnRomoverAbduzidos;
        private System.Windows.Forms.Button btnAdicionarAbduzidos;
        private System.Windows.Forms.GroupBox grbPlaneta;
        private System.Windows.Forms.Button btnRetonarPlaneta;
        private System.Windows.Forms.Button btnMudarPlaneta;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.PictureBox ptb;
        private System.Windows.Forms.Label lblPlanetaAtual;
        private System.Windows.Forms.PictureBox ptbTerra;
        private System.Windows.Forms.PictureBox ptbKrypton;
        private System.Windows.Forms.PictureBox ptbGallifrey;
        private System.Windows.Forms.PictureBox ptbPandora;
        private System.Windows.Forms.PictureBox ptbMiller;
    }
}