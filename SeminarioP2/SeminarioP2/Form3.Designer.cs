namespace SeminarioP2
{
    partial class Form3
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
            this.btn_voltar_home_cadastrar = new System.Windows.Forms.Button();
            this.clb_lista_tipo_veiculos = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_voltar_home_cadastrar
            // 
            this.btn_voltar_home_cadastrar.Location = new System.Drawing.Point(586, 277);
            this.btn_voltar_home_cadastrar.Name = "btn_voltar_home_cadastrar";
            this.btn_voltar_home_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar_home_cadastrar.TabIndex = 0;
            this.btn_voltar_home_cadastrar.Text = "Home";
            this.btn_voltar_home_cadastrar.UseVisualStyleBackColor = true;
            this.btn_voltar_home_cadastrar.Click += new System.EventHandler(this.btn_voltar_home_cadastrar_Click);
            // 
            // clb_lista_tipo_veiculos
            // 
            this.clb_lista_tipo_veiculos.FormattingEnabled = true;
            this.clb_lista_tipo_veiculos.Items.AddRange(new object[] {
            "Caminhão",
            "Carro",
            "Moto"});
            this.clb_lista_tipo_veiculos.Location = new System.Drawing.Point(541, 65);
            this.clb_lista_tipo_veiculos.Name = "clb_lista_tipo_veiculos";
            this.clb_lista_tipo_veiculos.Size = new System.Drawing.Size(120, 94);
            this.clb_lista_tipo_veiculos.TabIndex = 1;
            this.clb_lista_tipo_veiculos.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(322, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(269, 68);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(37, 13);
            this.lbl_marca.TabIndex = 4;
            this.lbl_marca.Text = "Marca";
            this.lbl_marca.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(264, 107);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(42, 13);
            this.lbl_modelo.TabIndex = 5;
            this.lbl_modelo.Text = "Modelo";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(465, 277);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.lbl_modelo);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.clb_lista_tipo_veiculos);
            this.Controls.Add(this.btn_voltar_home_cadastrar);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar_home_cadastrar;
        private System.Windows.Forms.CheckedListBox clb_lista_tipo_veiculos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Button btn_cadastrar;
    }
}