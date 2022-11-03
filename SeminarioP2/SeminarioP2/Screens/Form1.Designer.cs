namespace SeminarioP2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_cadastrar_veiculo = new System.Windows.Forms.Button();
            this.btn_listar_veiculos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cadastrar_veiculo
            // 
            this.btn_cadastrar_veiculo.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_cadastrar_veiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar_veiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar_veiculo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_veiculo.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_cadastrar_veiculo.Location = new System.Drawing.Point(207, 342);
            this.btn_cadastrar_veiculo.Name = "btn_cadastrar_veiculo";
            this.btn_cadastrar_veiculo.Size = new System.Drawing.Size(172, 50);
            this.btn_cadastrar_veiculo.TabIndex = 1;
            this.btn_cadastrar_veiculo.Text = "Cadastrar Veiculo";
            this.btn_cadastrar_veiculo.UseVisualStyleBackColor = false;
            this.btn_cadastrar_veiculo.Click += new System.EventHandler(this.btn_cadastrar_veiculo_Click);
            // 
            // btn_listar_veiculos
            // 
            this.btn_listar_veiculos.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_listar_veiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listar_veiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listar_veiculos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listar_veiculos.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_listar_veiculos.Location = new System.Drawing.Point(423, 342);
            this.btn_listar_veiculos.Name = "btn_listar_veiculos";
            this.btn_listar_veiculos.Size = new System.Drawing.Size(172, 50);
            this.btn_listar_veiculos.TabIndex = 2;
            this.btn_listar_veiculos.Text = "Listar Veiculos";
            this.btn_listar_veiculos.UseVisualStyleBackColor = false;
            this.btn_listar_veiculos.Click += new System.EventHandler(this.btn_listar_veiculos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 266);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(792, 455);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_listar_veiculos);
            this.Controls.Add(this.btn_cadastrar_veiculo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cadastrar_veiculo;
        private System.Windows.Forms.Button btn_listar_veiculos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

