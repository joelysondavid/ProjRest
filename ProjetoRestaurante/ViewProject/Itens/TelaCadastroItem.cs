using ControllerProject;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ModelProject;

namespace ViewProject.Itens
{
    public partial class TelaCadastroItem : Form
    {
        ItemController itemController;
        public TelaCadastroItem()
        {
            InitializeComponent();
            itemController = new ItemController();
        }

        private void btnSelecionaImagem_Click(object sender, EventArgs e)
        {
            if (ofdImagem.ShowDialog() == DialogResult.OK) // caso eu selecione uma imagem
            {
                txtURL.Text = ofdImagem.FileName; // aqui mostramos o diretorio e o arquivo no txtbox
                // aqui passamos o path para uma string convertendo o diretorio da imagem
                string path = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, txtURL.Text);
                ptbImagem.Image = Image.FromFile(path); // exibimos a imagem em um pctbox
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!VerificaCampos())
            {
                Item item = new Item
                {
                    Descricao = txtDescr.Text,
                    Detalhes = txtDetalhes.Text,
                    TempoPreparo = Convert.ToInt32(txtTempoPrep.Text),
                    Preco = Convert.ToDecimal(txtPreco.Text),
                    URLImagem = txtURL.Text
                };
                itemController.Save(item);
                LimparCampos();
            }
        }

        // limpar campos
        public void LimparCampos()
        {
            txtDescr.Clear();
            txtDetalhes.Clear();
            txtPreco.Clear();
            txtTempoPrep.Clear();
            txtURL.Clear();
            ptbImagem.Image = null;
        }

        // métodos auxiliares
        private bool VerificaCampos()
        {
            if (txtDescr.Text== string.Empty || txtTempoPrep.Text == string.Empty || txtPreco.Text == string.Empty)
                return true; // caso haja algum campo vazio retorna vazio

            // caso contrário
            return false; // return false e poderá salvar
        }
    }
}
