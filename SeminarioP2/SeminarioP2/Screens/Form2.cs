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

        private static string pathImageCaminhao = @"C:\Users\Bruno\Documents\C#\negretto_co_vehicles\SeminarioP2\SeminarioP2\Image\caminhao.png";
        private static string pathImageCarro = @"C:\Users\Bruno\Documents\C#\negretto_co_vehicles\SeminarioP2\SeminarioP2\Image\carro.png";
        private static string pathImageMoto = @"C:\Users\Bruno\Documents\C#\negretto_co_vehicles\SeminarioP2\SeminarioP2\Image\moto.jpg";

        public Form2()
        {
            InitializeComponent();
            listBoxVeiculos.MultiColumn = true;
            listBoxVeiculos.SelectionMode = SelectionMode.MultiExtended;
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

                listBoxVeiculos.Items.Clear();
                List<Table> listItem = ctx.Table.ToList();

                foreach (Table item in listItem)
                {
                    listBoxVeiculos.Items.Add(tratarId(item.Id.ToString()) + " Veiculo - " + item.Modelo);
                }
            }
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
                MessageBox.Show("Venda realizado com sucesso - " + itemTable.Modelo);
            }

            atualizaGrid();
        }

        private int selecionarId()
        {
            try { 
            string item = listBoxVeiculos.Items[listBoxVeiculos.SelectedIndex].ToString();
            return int.Parse(item.Substring(0, 3));
            } catch(Exception ex) {
                Console.WriteLine(ex);
            }
            return 0;
        }

        private string tratarId(string i)
        {
            switch (i.Length)
            {
                case (1):
                    return "00" + i;
                case (2):
                    return "0" + i;
                case (3):
                    return i;
            }
            return "0";
        }

        private void btn_voltar_cadastro_Click(object sender, EventArgs e)
        {
            Form3 voltarTelaCadastro = new Form3();
            voltarTelaCadastro.Show();
            Hide();
        }
    }
}
