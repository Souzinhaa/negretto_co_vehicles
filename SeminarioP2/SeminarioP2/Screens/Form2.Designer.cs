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
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voltar_home
            // 
            this.btn_voltar_home.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_voltar_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar_home.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar_home.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_voltar_home.Location = new System.Drawing.Point(343, 331);
            this.btn_voltar_home.Name = "btn_voltar_home";
            this.btn_voltar_home.Size = new System.Drawing.Size(96, 41);
            this.btn_voltar_home.TabIndex = 0;
            this.btn_voltar_home.Text = "Home";
            this.btn_voltar_home.UseVisualStyleBackColor = false;
            this.btn_voltar_home.Click += new System.EventHandler(this.btn_voltar_home_Click);
            // 
            // dgv_dados
            // 
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Location = new System.Drawing.Point(12, 75);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.Size = new System.Drawing.Size(776, 215);
            this.dgv_dados.TabIndex = 1;
            this.dgv_dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_dados);
            this.Controls.Add(this.btn_voltar_home);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar_home;
        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.Label label1;
    }
}