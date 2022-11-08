using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using SeminarioP2.Interface;
using System.Collections.Generic;
using SeminarioP2.Classes;
using System;
using System.Data;
using System.Drawing;
using System.Web;
using System.IO;

namespace SeminarioP2
{
    public partial class Form2 : Form
    {

        string pathImageCaminhao = @"C:\Users\Bruno\Documents\C#\negretto_co_vehicles\SeminarioP2\SeminarioP2\Image\caminhao.png";
        string pathImageCarro = @"C:\Users\Bruno\Documents\C#\negretto_co_vehicles\SeminarioP2\SeminarioP2\Image\carro.png";
        string pathImageMoto = @"C:\Users\Bruno\Documents\C#\negretto_co_vehicles\SeminarioP2\SeminarioP2\Image\moto.jpg";
        public Form2()
        {
            InitializeComponent();
            atualizaGrid();


            listBoxVeiculos.MultiColumn = true;
            // Set the selection mode to multiple and extended.
            listBoxVeiculos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void atualizaGrid()
        {
            using (ConcessionariaEntities ctx = new ConcessionariaEntities())
            {
                if(ctx == null)
                {
                    return;
                }

                listBoxVeiculos.Items.Clear();
                List<Table> v = ctx.Table.ToList();
                List<IVeiculo> listaVeiculos = new List<IVeiculo>();
                foreach (Table t in v)
                {
                    String i = t.Id.ToString();
                    String id = null;

                    switch (i.Length)
                    {
                        case (1):
                            id = "00" + i;
                            break;
                        case (2):
                            id = "0" + i;
                            break;
                        case (3):
                            id = i;
                            break;
                    }

                    listBoxVeiculos.Items.Add(id + " Veiculo - " + t.Modelo);
                }
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

        private void listBoxVeiculos_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int id = selecionarId();

            using (ConcessionariaEntities ctx = new ConcessionariaEntities())
            {
                if (ctx == null)
                {
                    return;
                }

                Table itemTable = ctx.Table.Where(x => x.Id == id).SingleOrDefault();

                if (itemTable != null)
                {
                    lbl_id_value.Text = itemTable.Id.ToString();
                    lbl_modelo_value.Text = itemTable.Modelo.ToString();
                    lbl_beneficio_value.Text = itemTable.Beneficio.ToString();

                    String img = "";

                    switch (itemTable.Categoria)
                    {
                        case 1:
                            img = pathImageMoto;
                            break;
                        case 2:
                            img = pathImageCarro;
                            break;
                        case 3:
                            img = pathImageCaminhao;
                            break;
                    }


                    Image image = Image.FromFile(img);

                    if(image != null)
                        pb_veiculo.Image = image;
                }
            }
        }

        private void btn_vender_Click(object sender, System.EventArgs e)
        {
            int id = selecionarId();

            using (ConcessionariaEntities ctx = new ConcessionariaEntities())
            {
                if (ctx == null)
                {
                    return;
                }

                Table itemTable = ctx.Table.Where(x => x.Id == id).SingleOrDefault();

                if (itemTable != null) { 
                    ctx.Table.Remove(itemTable);
                    ctx.SaveChanges();
                }
            }

            atualizaGrid();
        }

        private int selecionarId()
        {
            try { 
            string item = listBoxVeiculos.Items[listBoxVeiculos.SelectedIndex].ToString();
            string aux = item.Substring(0, 3);
            return int.Parse(aux);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
            return 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
