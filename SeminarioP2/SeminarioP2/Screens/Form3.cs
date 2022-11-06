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
            progressBar1.Maximum = 1000000;
            progressBar1.Step = 1;
            progressBar1.Value = 1;
        }

        private async void loadProgressBar()
        {
            for (int j = 0; j < 500000; j++)
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btn_cadastrar_Click(object sender, EventArgs e)
        {
            progressBar();
            loadProgressBar();

            await Task.Run(() =>
            {
                for (int i = 0; i < clb_lista_tipo_veiculos.CheckedItems.Count; i++)
                {
                    if (clb_lista_tipo_veiculos.CheckedItems[i].ToString() == "Caminhão")
                    {
                        program.comprarCaminhao(text_modelo.Text, text_beneficio.Text);
                    }

                    if (clb_lista_tipo_veiculos.CheckedItems[i].ToString() == "Carro")
                    {
                        program.comprarCarro(text_modelo.Text, text_beneficio.Text);
                    }

                    if (clb_lista_tipo_veiculos.CheckedItems[i].ToString() == "Moto")
                    {
                        program.comprarMoto(text_modelo.Text, text_beneficio.Text);
                    }
                }
            });

            loadProgressBar();
            

            Form2 listarVeiculos = new Form2();
            listarVeiculos.Show();
            Hide();
        }
    }
}
