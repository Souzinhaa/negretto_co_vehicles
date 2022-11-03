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
            using (ConcessionariaEntities ctx = new ConcessionariaEntities())
            {
                if(ctx == null)
                {
                    return;
                }

                dgv_dados.DataSource = ctx.Table.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_voltar_home_Click(object sender, System.EventArgs e)
        {
            Form1 voltarHome = new Form1();
            voltarHome.Show();
            Hide();
        }
    }
}
