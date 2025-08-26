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
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.grbTripulantes = new System.Windows.Forms.GroupBox();
            this.btnAdicionarTripulantes = new System.Windows.Forms.Button();
            this.btnRemoverTripulantes = new System.Windows.Forms.Button();
            this.grbAbduzidos = new System.Windows.Forms.GroupBox();
            this.btnRomoverAbduzidos = new System.Windows.Forms.Button();
            this.btnAdicionarAbduzidos = new System.Windows.Forms.Button();
            this.grbPlaneta = new System.Windows.Forms.GroupBox();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.btnMudarPlaneta = new System.Windows.Forms.Button();
            this.btnRetonarPlaneta = new System.Windows.Forms.Button();
            this.ptb = new System.Windows.Forms.PictureBox();
            this.lblPlanetaAtual = new System.Windows.Forms.Label();
            this.grbInfomacoes.SuspendLayout();
            this.grbTripulantes.SuspendLayout();
            this.grbAbduzidos.SuspendLayout();
            this.grbPlaneta.SuspendLayout();
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
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(6, 26);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:";
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
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(6, 77);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(59, 13);
            this.lblAbduzidos.TabIndex = 2;
            this.lblAbduzidos.Text = "Abduzidos:";
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
            // btnRemoverTripulantes
            // 
            this.btnRemoverTripulantes.Location = new System.Drawing.Point(9, 80);
            this.btnRemoverTripulantes.Name = "btnRemoverTripulantes";
            this.btnRemoverTripulantes.Size = new System.Drawing.Size(233, 33);
            this.btnRemoverTripulantes.TabIndex = 1;
            this.btnRemoverTripulantes.Text = "Remover";
            this.btnRemoverTripulantes.UseVisualStyleBackColor = true;
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
            // 
            // btnAdicionarAbduzidos
            // 
            this.btnAdicionarAbduzidos.Location = new System.Drawing.Point(9, 32);
            this.btnAdicionarAbduzidos.Name = "btnAdicionarAbduzidos";
            this.btnAdicionarAbduzidos.Size = new System.Drawing.Size(233, 33);
            this.btnAdicionarAbduzidos.TabIndex = 0;
            this.btnAdicionarAbduzidos.Text = "Adicionar";
            this.btnAdicionarAbduzidos.UseVisualStyleBackColor = true;
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
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(6, 41);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(236, 21);
            this.cmbPlanetas.TabIndex = 0;
            // 
            // btnMudarPlaneta
            // 
            this.btnMudarPlaneta.Location = new System.Drawing.Point(6, 77);
            this.btnMudarPlaneta.Name = "btnMudarPlaneta";
            this.btnMudarPlaneta.Size = new System.Drawing.Size(236, 77);
            this.btnMudarPlaneta.TabIndex = 2;
            this.btnMudarPlaneta.Text = "Mudar Planeta";
            this.btnMudarPlaneta.UseVisualStyleBackColor = true;
            // 
            // btnRetonarPlaneta
            // 
            this.btnRetonarPlaneta.Location = new System.Drawing.Point(6, 160);
            this.btnRetonarPlaneta.Name = "btnRetonarPlaneta";
            this.btnRetonarPlaneta.Size = new System.Drawing.Size(236, 81);
            this.btnRetonarPlaneta.TabIndex = 3;
            this.btnRetonarPlaneta.Text = "Retonar";
            this.btnRetonarPlaneta.UseVisualStyleBackColor = true;
            // 
            // ptb
            // 
            this.ptb.Image = global::GerenciadorDeOVNI.Properties.Resources.Goodstuff_No_Nonsense_Free_Space_Alien_obduction_1024__1_;
            this.ptb.Location = new System.Drawing.Point(610, 60);
            this.ptb.Name = "ptb";
            this.ptb.Size = new System.Drawing.Size(284, 378);
            this.ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb.TabIndex = 4;
            this.ptb.TabStop = false;
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
            // Gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 560);
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
    }
}