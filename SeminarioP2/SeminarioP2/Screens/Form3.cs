using SeminarioP2.Classes;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarioP2
{
    public partial class Form3 : Form
    {
        BackProgram program;
        public Form3()
        {
            program = BackProgram.getInstance();
            InitializeComponent();
        }

        private async void progressBar()
        {
            progressBar1.Visible = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 900000;
            progressBar1.Step = 1;
            progressBar1.Value = 1;
        }

        private async void loadProgressBar()
        {
            for (int j = 0; j < 300000; j++)
            {
                progressBar1.PerformStep();
            }
        }

        private void btn_voltar_home_cadastrar_Click(object sender, EventArgs e)
        {
            Form1 voltarHome = new Form1();
            voltarHome.Show();
            Hide();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Only one checked in checkbox list item
            int iSelectedIndex = clb_lista_tipo_veiculos.SelectedIndex;
            if (iSelectedIndex == -1)
                return;
            for (int iIndex = 0; iIndex < clb_lista_tipo_veiculos.Items.Count; iIndex++)
                clb_lista_tipo_veiculos.SetItemCheckState(iIndex, CheckState.Unchecked);
            clb_lista_tipo_veiculos.SetItemCheckState(iSelectedIndex, CheckState.Checked);
        }


        private async void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Console.WriteLine(text_modelo.ToString());

            if (string.IsNullOrWhiteSpace(text_modelo.Text))
            { 
                text_modelo.Focus();
                MessageBox.Show("Insira um Modelo!", "ListBox",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(text_beneficio.Text))
            {
                text_modelo.Focus();
                MessageBox.Show("Insira um Benefício!", "ListBox",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(clb_lista_tipo_veiculos.Text))
            {
                clb_lista_tipo_veiculos.Focus();
                MessageBox.Show("Insira um Tipo!", "ListBox",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            progressBar();
                    loadProgressBar();

                    for (int i = 0; i < clb_lista_tipo_veiculos.CheckedItems.Count; i++)
                    {
                        if (clb_lista_tipo_veiculos.CheckedItems[i].ToString() == "Caminhão")
                        {
                            loadProgressBar();
                            program.comprarCaminhao(text_modelo.Text, text_beneficio.Text);
                        }

                        if (clb_lista_tipo_veiculos.CheckedItems[i].ToString() == "Carro")
                        {
                            loadProgressBar();
                            program.comprarCarro(text_modelo.Text, text_beneficio.Text);
                        }

                        if (clb_lista_tipo_veiculos.CheckedItems[i].ToString() == "Moto")
                        {
                            loadProgressBar();
                            program.comprarMoto(text_modelo.Text, text_beneficio.Text);
                        }
                    }

            loadProgressBar();
            

            Form2 listarVeiculos = new Form2();
            listarVeiculos.Show();
            Hide();
        }
    }
}
