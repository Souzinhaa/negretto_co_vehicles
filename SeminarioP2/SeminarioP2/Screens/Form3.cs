using SeminarioP2.Classes;
using System;
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

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < clb_lista_tipo_veiculos.Items.Count; i++)
            {
                if (clb_lista_tipo_veiculos.Items[i].ToString() == "Caminhão")
                {
                    program.comprarCaminhao(text_modelo.Text, text_beneficio.Text);
                }

                if (clb_lista_tipo_veiculos.Items[i].ToString() == "Carro")
                {
                    program.comprarCarro(text_modelo.Text, text_beneficio.Text);
                }

                if (clb_lista_tipo_veiculos.Items[i].ToString() == "Moto")
                {
                    program.comprarMoto(text_modelo.Text, text_beneficio.Text);
                }
            }

            /*
            Table veiculo = new Table();
            veiculo.Marca = "Renaut";
            veiculo.Modelo = "Sandero 2022";

            using (CadastroEntities ctx = new CadastroEntities())
            {
                ctx.Table.Add(veiculo);
                ctx.SaveChanges();
                

            }*/
        }
    }
}
