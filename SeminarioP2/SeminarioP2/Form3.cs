using System;
using System.Windows.Forms;

namespace SeminarioP2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
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
            Table veiculo = new Table();
            veiculo.Marca = "Renaut";
            veiculo.Modelo = "Sandero 2022";

            using (CadastroEntities ctx = new CadastroEntities())
            {
                ctx.Table.Add(veiculo);
                ctx.SaveChanges();
                

            }
        }
    }
}
