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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btn_voltar_home_cadastrar = new System.Windows.Forms.Button();
            this.clb_lista_tipo_veiculos = new System.Windows.Forms.CheckedListBox();
            this.text_modelo = new System.Windows.Forms.TextBox();
            this.text_beneficio = new System.Windows.Forms.TextBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voltar_home_cadastrar
            // 
            this.btn_voltar_home_cadastrar.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_voltar_home_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar_home_cadastrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar_home_cadastrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_voltar_home_cadastrar.Location = new System.Drawing.Point(154, 448);
            this.btn_voltar_home_cadastrar.Name = "btn_voltar_home_cadastrar";
            this.btn_voltar_home_cadastrar.Size = new System.Drawing.Size(132, 40);
            this.btn_voltar_home_cadastrar.TabIndex = 0;
            this.btn_voltar_home_cadastrar.Text = "Home";
            this.btn_voltar_home_cadastrar.UseVisualStyleBackColor = false;
            this.btn_voltar_home_cadastrar.Click += new System.EventHandler(this.btn_voltar_home_cadastrar_Click);
            // 
            // clb_lista_tipo_veiculos
            // 
            this.clb_lista_tipo_veiculos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clb_lista_tipo_veiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_lista_tipo_veiculos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_lista_tipo_veiculos.ForeColor = System.Drawing.SystemColors.InfoText;
            this.clb_lista_tipo_veiculos.FormattingEnabled = true;
            this.clb_lista_tipo_veiculos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clb_lista_tipo_veiculos.Items.AddRange(new object[] {
            "Caminhão",
            "Carro",
            "Moto"});
            this.clb_lista_tipo_veiculos.Location = new System.Drawing.Point(240, 280);
            this.clb_lista_tipo_veiculos.Name = "clb_lista_tipo_veiculos";
            this.clb_lista_tipo_veiculos.Size = new System.Drawing.Size(127, 63);
            this.clb_lista_tipo_veiculos.TabIndex = 1;
            this.clb_lista_tipo_veiculos.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // text_modelo
            // 
            this.text_modelo.Location = new System.Drawing.Point(240, 132);
            this.text_modelo.Name = "text_modelo";
            this.text_modelo.Size = new System.Drawing.Size(185, 20);
            this.text_modelo.TabIndex = 2;
            // 
            // text_beneficio
            // 
            this.text_beneficio.Location = new System.Drawing.Point(240, 208);
            this.text_beneficio.Name = "text_beneficio";
            this.text_beneficio.Size = new System.Drawing.Size(185, 20);
            this.text_beneficio.TabIndex = 3;
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca.Location = new System.Drawing.Point(150, 205);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(84, 22);
            this.lbl_marca.TabIndex = 4;
            this.lbl_marca.Text = "Benefício";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modelo.Location = new System.Drawing.Point(150, 129);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(73, 22);
            this.lbl_modelo.TabIndex = 5;
            this.lbl_modelo.Text = "Modelo";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_cadastrar.Location = new System.Drawing.Point(154, 376);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(132, 40);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(235, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cadastro:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 547);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(142, 526);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(298, 20);
            this.progressBar1.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 609);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.lbl_modelo);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.text_beneficio);
            this.Controls.Add(this.text_modelo);
            this.Controls.Add(this.clb_lista_tipo_veiculos);
            this.Controls.Add(this.btn_voltar_home_cadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar_home_cadastrar;
        private System.Windows.Forms.CheckedListBox clb_lista_tipo_veiculos;
        private System.Windows.Forms.TextBox text_modelo;
        private System.Windows.Forms.TextBox text_beneficio;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}