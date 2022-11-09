namespace SeminarioP2
{
    partial class Form2
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
            this.btn_voltar_home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxVeiculos = new System.Windows.Forms.ListBox();
            this.btn_vender = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.lbl_beneficio = new System.Windows.Forms.Label();
            this.lbl_id_value = new System.Windows.Forms.Label();
            this.lbl_modelo_value = new System.Windows.Forms.Label();
            this.lbl_beneficio_value = new System.Windows.Forms.Label();
            this.pb_veiculo = new System.Windows.Forms.PictureBox();
            this.btn_voltar_cadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_veiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voltar_home
            // 
            this.btn_voltar_home.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_voltar_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar_home.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar_home.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_voltar_home.Location = new System.Drawing.Point(302, 352);
            this.btn_voltar_home.Name = "btn_voltar_home";
            this.btn_voltar_home.Size = new System.Drawing.Size(96, 41);
            this.btn_voltar_home.TabIndex = 0;
            this.btn_voltar_home.Text = "Home";
            this.btn_voltar_home.UseVisualStyleBackColor = false;
            this.btn_voltar_home.Click += new System.EventHandler(this.btn_voltar_home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listagem de cadastro";
            // 
            // listBoxVeiculos
            // 
            this.listBoxVeiculos.FormattingEnabled = true;
            this.listBoxVeiculos.Location = new System.Drawing.Point(10, 63);
            this.listBoxVeiculos.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxVeiculos.Name = "listBoxVeiculos";
            this.listBoxVeiculos.Size = new System.Drawing.Size(389, 251);
            this.listBoxVeiculos.TabIndex = 3;
            this.listBoxVeiculos.SelectedIndexChanged += new System.EventHandler(this.listBoxVeiculos_SelectedIndexChanged);
            // 
            // btn_vender
            // 
            this.btn_vender.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vender.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_vender.Location = new System.Drawing.Point(10, 352);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(96, 41);
            this.btn_vender.TabIndex = 4;
            this.btn_vender.Text = "Vender";
            this.btn_vender.UseVisualStyleBackColor = false;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(433, 263);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(433, 300);
            this.lbl_modelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(45, 13);
            this.lbl_modelo.TabIndex = 6;
            this.lbl_modelo.Text = "Modelo:";
            // 
            // lbl_beneficio
            // 
            this.lbl_beneficio.AutoSize = true;
            this.lbl_beneficio.Location = new System.Drawing.Point(611, 263);
            this.lbl_beneficio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_beneficio.Name = "lbl_beneficio";
            this.lbl_beneficio.Size = new System.Drawing.Size(54, 13);
            this.lbl_beneficio.TabIndex = 7;
            this.lbl_beneficio.Text = "Beneficio:";
            // 
            // lbl_id_value
            // 
            this.lbl_id_value.AutoSize = true;
            this.lbl_id_value.Location = new System.Drawing.Point(490, 263);
            this.lbl_id_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_id_value.Name = "lbl_id_value";
            this.lbl_id_value.Size = new System.Drawing.Size(10, 13);
            this.lbl_id_value.TabIndex = 9;
            this.lbl_id_value.Text = "-";
            // 
            // lbl_modelo_value
            // 
            this.lbl_modelo_value.AutoSize = true;
            this.lbl_modelo_value.Location = new System.Drawing.Point(490, 300);
            this.lbl_modelo_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_modelo_value.Name = "lbl_modelo_value";
            this.lbl_modelo_value.Size = new System.Drawing.Size(10, 13);
            this.lbl_modelo_value.TabIndex = 10;
            this.lbl_modelo_value.Text = "-";
            // 
            // lbl_beneficio_value
            // 
            this.lbl_beneficio_value.AutoSize = true;
            this.lbl_beneficio_value.Location = new System.Drawing.Point(668, 263);
            this.lbl_beneficio_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_beneficio_value.Name = "lbl_beneficio_value";
            this.lbl_beneficio_value.Size = new System.Drawing.Size(10, 13);
            this.lbl_beneficio_value.TabIndex = 11;
            this.lbl_beneficio_value.Text = "-";
            // 
            // pb_veiculo
            // 
            this.pb_veiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_veiculo.Location = new System.Drawing.Point(482, 63);
            this.pb_veiculo.Margin = new System.Windows.Forms.Padding(2);
            this.pb_veiculo.Name = "pb_veiculo";
            this.pb_veiculo.Size = new System.Drawing.Size(212, 180);
            this.pb_veiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_veiculo.TabIndex = 13;
            this.pb_veiculo.TabStop = false;
            // 
            // btn_voltar_cadastro
            // 
            this.btn_voltar_cadastro.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_voltar_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar_cadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar_cadastro.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_voltar_cadastro.Location = new System.Drawing.Point(157, 352);
            this.btn_voltar_cadastro.Name = "btn_voltar_cadastro";
            this.btn_voltar_cadastro.Size = new System.Drawing.Size(96, 41);
            this.btn_voltar_cadastro.TabIndex = 0;
            this.btn_voltar_cadastro.Text = "Cadastrar";
            this.btn_voltar_cadastro.UseVisualStyleBackColor = false;
            this.btn_voltar_cadastro.Click += new System.EventHandler(this.btn_voltar_cadastro_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_voltar_cadastro);
            this.Controls.Add(this.pb_veiculo);
            this.Controls.Add(this.lbl_beneficio_value);
            this.Controls.Add(this.lbl_modelo_value);
            this.Controls.Add(this.lbl_id_value);
            this.Controls.Add(this.lbl_beneficio);
            this.Controls.Add(this.lbl_modelo);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_vender);
            this.Controls.Add(this.listBoxVeiculos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_voltar_home);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pb_veiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar_home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxVeiculos;
        private System.Windows.Forms.Button btn_vender;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Label lbl_beneficio;
        private System.Windows.Forms.Label lbl_id_value;
        private System.Windows.Forms.Label lbl_modelo_value;
        private System.Windows.Forms.Label lbl_beneficio_value;
        private System.Windows.Forms.PictureBox pb_veiculo;
        private System.Windows.Forms.Button btn_voltar_cadastro;
    }
}