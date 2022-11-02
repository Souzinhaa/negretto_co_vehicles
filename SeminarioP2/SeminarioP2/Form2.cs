using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace SeminarioP2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            atualizaGrid();

        }
        private void atualizaGrid()
        {
            using (CadastroEntities ctx = new CadastroEntities())
            {
                dgv_dados.DataSource = ctx.Table.ToList();
            }
        }

        private void btn_voltar_home_Click(object sender)
        {
            Form1 voltarHome = new Form1();
            voltarHome.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
