namespace PedraPapelTesoura
{
    partial class Jokenpo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jokenpo));
            this.group_player = new System.Windows.Forms.GroupBox();
            this.group_comp = new System.Windows.Forms.GroupBox();
            this.lbl_jog = new System.Windows.Forms.Label();
            this.lbl_pc = new System.Windows.Forms.Label();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_comp = new System.Windows.Forms.PictureBox();
            this.pic_player = new System.Windows.Forms.PictureBox();
            this.btn_saida = new System.Windows.Forms.Button();
            this.btn_tesoura = new System.Windows.Forms.Button();
            this.btn_papel = new System.Windows.Forms.Button();
            this.btn_pedra = new System.Windows.Forms.Button();
            this.group_player.SuspendLayout();
            this.group_comp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_player)).BeginInit();
            this.SuspendLayout();
            // 
            // group_player
            // 
            this.group_player.Controls.Add(this.pic_player);
            this.group_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.group_player.Location = new System.Drawing.Point(18, 6);
            this.group_player.Name = "group_player";
            this.group_player.Size = new System.Drawing.Size(213, 218);
            this.group_player.TabIndex = 5;
            this.group_player.TabStop = false;
            this.group_player.Text = "Escolha do Jogador:";
            // 
            // group_comp
            // 
            this.group_comp.Controls.Add(this.pic_comp);
            this.group_comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.group_comp.Location = new System.Drawing.Point(894, 13);
            this.group_comp.Name = "group_comp";
            this.group_comp.Size = new System.Drawing.Size(213, 218);
            this.group_comp.TabIndex = 6;
            this.group_comp.TabStop = false;
            this.group_comp.Text = "Escolha do Computador:";
            // 
            // lbl_jog
            // 
            this.lbl_jog.AutoSize = true;
            this.lbl_jog.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_jog.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_jog.Location = new System.Drawing.Point(329, 94);
            this.lbl_jog.Name = "lbl_jog";
            this.lbl_jog.Size = new System.Drawing.Size(56, 61);
            this.lbl_jog.TabIndex = 8;
            this.lbl_jog.Text = "0";
            // 
            // lbl_pc
            // 
            this.lbl_pc.AutoSize = true;
            this.lbl_pc.BackColor = System.Drawing.Color.PowderBlue;
            this.lbl_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_pc.Location = new System.Drawing.Point(664, 94);
            this.lbl_pc.Name = "lbl_pc";
            this.lbl_pc.Size = new System.Drawing.Size(56, 61);
            this.lbl_pc.TabIndex = 9;
            this.lbl_pc.Text = "0";
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.BackgroundImage = global::PedraPapelTesoura.Properties.Resources.reiniciar;
            this.btn_reiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reiniciar.Location = new System.Drawing.Point(675, 255);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(213, 185);
            this.btn_reiniciar.TabIndex = 10;
            this.btn_reiniciar.UseVisualStyleBackColor = true;
            this.btn_reiniciar.Click += new System.EventHandler(this.btn_reiniciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PedraPapelTesoura.Properties.Resources.placar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(238, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 243);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pic_comp
            // 
            this.pic_comp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_comp.Location = new System.Drawing.Point(6, 25);
            this.pic_comp.Name = "pic_comp";
            this.pic_comp.Size = new System.Drawing.Size(200, 186);
            this.pic_comp.TabIndex = 1;
            this.pic_comp.TabStop = false;
            // 
            // pic_player
            // 
            this.pic_player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_player.Location = new System.Drawing.Point(7, 26);
            this.pic_player.Name = "pic_player";
            this.pic_player.Size = new System.Drawing.Size(200, 186);
            this.pic_player.TabIndex = 0;
            this.pic_player.TabStop = false;
            // 
            // btn_saida
            // 
            this.btn_saida.BackColor = System.Drawing.Color.Transparent;
            this.btn_saida.BackgroundImage = global::PedraPapelTesoura.Properties.Resources.sair;
            this.btn_saida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saida.Location = new System.Drawing.Point(900, 255);
            this.btn_saida.Name = "btn_saida";
            this.btn_saida.Size = new System.Drawing.Size(213, 185);
            this.btn_saida.TabIndex = 4;
            this.btn_saida.UseVisualStyleBackColor = false;
            this.btn_saida.Click += new System.EventHandler(this.btn_saida_Click);
            // 
            // btn_tesoura
            // 
            this.btn_tesoura.BackgroundImage = global::PedraPapelTesoura.Properties.Resources.tesoura;
            this.btn_tesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tesoura.Location = new System.Drawing.Point(456, 255);
            this.btn_tesoura.Name = "btn_tesoura";
            this.btn_tesoura.Size = new System.Drawing.Size(213, 185);
            this.btn_tesoura.TabIndex = 3;
            this.btn_tesoura.UseVisualStyleBackColor = true;
            this.btn_tesoura.Click += new System.EventHandler(this.btn_tesoura_Click);
            // 
            // btn_papel
            // 
            this.btn_papel.BackgroundImage = global::PedraPapelTesoura.Properties.Resources.papel;
            this.btn_papel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_papel.Location = new System.Drawing.Point(237, 255);
            this.btn_papel.Name = "btn_papel";
            this.btn_papel.Size = new System.Drawing.Size(213, 185);
            this.btn_papel.TabIndex = 2;
            this.btn_papel.UseVisualStyleBackColor = true;
            this.btn_papel.Click += new System.EventHandler(this.btn_papel_Click);
            // 
            // btn_pedra
            // 
            this.btn_pedra.BackgroundImage = global::PedraPapelTesoura.Properties.Resources.pedra;
            this.btn_pedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pedra.Location = new System.Drawing.Point(18, 255);
            this.btn_pedra.Name = "btn_pedra";
            this.btn_pedra.Size = new System.Drawing.Size(213, 185);
            this.btn_pedra.TabIndex = 1;
            this.btn_pedra.UseVisualStyleBackColor = true;
            this.btn_pedra.Click += new System.EventHandler(this.btn_pedra_Click);
            // 
            // Jokenpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 443);
            this.Controls.Add(this.btn_reiniciar);
            this.Controls.Add(this.lbl_pc);
            this.Controls.Add(this.lbl_jog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.group_comp);
            this.Controls.Add(this.group_player);
            this.Controls.Add(this.btn_saida);
            this.Controls.Add(this.btn_tesoura);
            this.Controls.Add(this.btn_papel);
            this.Controls.Add(this.btn_pedra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jokenpo";
            this.Text = "Pedra, Papel e Tesoura";
            this.group_player.ResumeLayout(false);
            this.group_comp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pedra;
        private System.Windows.Forms.Button btn_papel;
        private System.Windows.Forms.Button btn_tesoura;
        private System.Windows.Forms.Button btn_saida;
        private System.Windows.Forms.GroupBox group_player;
        private System.Windows.Forms.PictureBox pic_player;
        private System.Windows.Forms.GroupBox group_comp;
        private System.Windows.Forms.PictureBox pic_comp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_jog;
        private System.Windows.Forms.Label lbl_pc;
        private System.Windows.Forms.Button btn_reiniciar;
    }
}

