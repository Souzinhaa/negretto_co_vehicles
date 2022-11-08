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
            ((System.ComponentModel.ISupportInitialize)(this.pb_veiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voltar_home
            // 
            this.btn_voltar_home.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_voltar_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar_home.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar_home.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_voltar_home.Location = new System.Drawing.Point(402, 433);
            this.btn_voltar_home.Margin = new System.Windows.Forms.Padding(4);
            this.btn_voltar_home.Name = "btn_voltar_home";
            this.btn_voltar_home.Size = new System.Drawing.Size(128, 50);
            this.btn_voltar_home.TabIndex = 0;
            this.btn_voltar_home.Text = "Home";
            this.btn_voltar_home.UseVisualStyleBackColor = false;
            this.btn_voltar_home.Click += new System.EventHandler(this.btn_voltar_home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listagem de cadastro";
            // 
            // listBoxVeiculos
            // 
            this.listBoxVeiculos.FormattingEnabled = true;
            this.listBoxVeiculos.ItemHeight = 16;
            this.listBoxVeiculos.Location = new System.Drawing.Point(13, 77);
            this.listBoxVeiculos.Name = "listBoxVeiculos";
            this.listBoxVeiculos.Size = new System.Drawing.Size(517, 308);
            this.listBoxVeiculos.TabIndex = 3;
            this.listBoxVeiculos.SelectedIndexChanged += new System.EventHandler(this.listBoxVeiculos_SelectedIndexChanged);
            // 
            // btn_vender
            // 
            this.btn_vender.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vender.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_vender.Location = new System.Drawing.Point(13, 433);
            this.btn_vender.Margin = new System.Windows.Forms.Padding(4);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(128, 50);
            this.btn_vender.TabIndex = 4;
            this.btn_vender.Text = "Vender";
            this.btn_vender.UseVisualStyleBackColor = false;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(577, 324);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(23, 16);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(577, 369);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(56, 16);
            this.lbl_modelo.TabIndex = 6;
            this.lbl_modelo.Text = "Modelo:";
            // 
            // lbl_beneficio
            // 
            this.lbl_beneficio.AutoSize = true;
            this.lbl_beneficio.Location = new System.Drawing.Point(815, 324);
            this.lbl_beneficio.Name = "lbl_beneficio";
            this.lbl_beneficio.Size = new System.Drawing.Size(66, 16);
            this.lbl_beneficio.TabIndex = 7;
            this.lbl_beneficio.Text = "Beneficio:";
            // 
            // lbl_id_value
            // 
            this.lbl_id_value.AutoSize = true;
            this.lbl_id_value.Location = new System.Drawing.Point(653, 324);
            this.lbl_id_value.Name = "lbl_id_value";
            this.lbl_id_value.Size = new System.Drawing.Size(11, 16);
            this.lbl_id_value.TabIndex = 9;
            this.lbl_id_value.Text = "-";
            // 
            // lbl_modelo_value
            // 
            this.lbl_modelo_value.AutoSize = true;
            this.lbl_modelo_value.Location = new System.Drawing.Point(653, 369);
            this.lbl_modelo_value.Name = "lbl_modelo_value";
            this.lbl_modelo_value.Size = new System.Drawing.Size(11, 16);
            this.lbl_modelo_value.TabIndex = 10;
            this.lbl_modelo_value.Text = "-";
            // 
            // lbl_beneficio_value
            // 
            this.lbl_beneficio_value.AutoSize = true;
            this.lbl_beneficio_value.Location = new System.Drawing.Point(891, 324);
            this.lbl_beneficio_value.Name = "lbl_beneficio_value";
            this.lbl_beneficio_value.Size = new System.Drawing.Size(11, 16);
            this.lbl_beneficio_value.TabIndex = 11;
            this.lbl_beneficio_value.Text = "-";
            // 
            // pb_veiculo
            // 
            this.pb_veiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_veiculo.Location = new System.Drawing.Point(642, 77);
            this.pb_veiculo.Name = "pb_veiculo";
            this.pb_veiculo.Size = new System.Drawing.Size(282, 221);
            this.pb_veiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_veiculo.TabIndex = 13;
            this.pb_veiculo.TabStop = false;
            this.pb_veiculo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}