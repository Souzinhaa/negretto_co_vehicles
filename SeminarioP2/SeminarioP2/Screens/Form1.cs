using System;
using System.Windows.Forms;

namespace SeminarioP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_listar_veiculos_Click(object sender, EventArgs e)
        {
            Form2 listarVeiculos = new Form2();
            listarVeiculos.Show();
            Hide();
        }

        private void btn_cadastrar_veiculo_Click(object sender, EventArgs e)
        {
            Form3 cadastrarVeiculos = new Form3();
            cadastrarVeiculos.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
