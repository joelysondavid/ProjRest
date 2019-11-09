using ControllerProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelProject;
using System.IO;

namespace ViewProject.Itens
{
    public partial class Cardapio : Form
    {
        private ItemController itemController;
        int pagina = 1;
        public Cardapio()
        {
            InitializeComponent();
            itemController = new ItemController();
            GetItens();
        }

        // carrega items
        public void GetItens()
        {
            IList<Item> items = itemController.GetAll();
            for (int i = 0; i < items.Count; i++)
            {
                lblDescr1.Text = items[i*pagina].Descricao;
                txtDetalhes1.Text = items[i*pagina].Detalhes;
                lblTempo1.Text = items[i*pagina].TempoPreparo.ToString();
                lblPreco1.Text = "R$ " + items[i*pagina].Preco;
                string path = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, items[i*pagina].URLImagem);
                ptbURL1.Image = Image.FromFile(path);
            }
        }
    }
}
