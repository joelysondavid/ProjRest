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
    public partial class TelaGerenciamentoMenu : Form
    {
        private ItemController itemController;
        private Item itemSel; // item selecionado
        public TelaGerenciamentoMenu()
        {
            InitializeComponent();
            itemController = new ItemController();
            GetItens();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja realmente indisponibilizar/disponibilizar o item?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    Item item;
                    if (itemSel.Disponivel == true)
                        item = itemController.UpdateDisponibilidade((int)itemSel.Id, false); // chamo método para deletar itens
                    else
                        item = itemController.UpdateDisponibilidade((int)itemSel.Id, true); // chamo método para deletar itens

                    if (item != null)
                    {
                        GetItens(); // atualizo a grid
                        MessageBox.Show("Item deletado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos(); // limpa os campso
                        AlterControls(false); // seta os controles para false
                        btnExcluir.Enabled = false; // desabilita o botão excluir
                    }
                    else
                    {
                        MessageBox.Show("Erro ao desabilitar o item!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                Item item = new Item
                {
                    Id = (itemSel != null) ? itemSel.Id : null,
                    Descricao = txtDescr.Text,
                    Detalhes = txtDetalhes.Text,
                    Preco = Convert.ToDecimal(txtPreco.Text),
                    TempoPreparo = Convert.ToInt32(txtTempoPrep.Text),
                    URLImagem = txtUrl.Text
                };
                this.itemController.Save(item); // salva o item
                LimparCampos(); // limpa os campos
                GetItens(); // reload a grid
                MessageBox.Show("Item salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AlterControls(false); // altera os controles pra false
                btnExcluir.Enabled = false; // desabilita o btnexcluir
            }
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            if (ofdImagem.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // converte a url string em um path para passar para imagem
                    string path = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, ofdImagem.FileName);
                    pctImagem.Image = Image.FromFile(path); // seta o caminho da imagem que será exibida no picture
                    txtUrl.Text = path; // o path da imagem é passado para o txt
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro ao trocar imagem!\nErro: " + err, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // btnNovo é responsável por habilitar os txt que serão inseridos os atributos do item
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos(); // primeiro limpa os campos
            AlterControls(true); // dpois habilita os campos
            btnExcluir.Enabled = false; // desabilita botao excluir
        }

        // --- métodos auxiliares ---

        // verifica se os campos são validos para realizar alguma operação
        private bool CamposValidos()
        {
            bool valido = false;
            int inteiro = 0;
            decimal dec = 0.0m;
            // primeira if verifica se os campos obrigatórios das tabelas estão vazios
            if (!string.IsNullOrWhiteSpace(txtDescr.Text) && txtPreco.Text != string.Empty && txtTempoPrep.Text != string.Empty)
            {
                // segunda if verifica se o txtPreco e txtTempo são dos tipos corretos
                if (txtDescr.Text.Length <= 100 && txtDetalhes.Text.Length <= 100 && txtUrl.Text.Length <= 250)
                {
                    if (int.TryParse(txtTempoPrep.Text, out inteiro) && decimal.TryParse(txtPreco.Text, out dec))
                    {
                        int tempoPrep = Convert.ToInt32(txtTempoPrep.Text); decimal preco = Convert.ToDecimal(txtPreco.Text);
                        if (tempoPrep >= 0 && preco >= 0)
                            valido = true;
                        else
                            MessageBox.Show("Atenção os valores de tempo e preço do item não pode ser negativos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Os campos tempo de preparo e preco devem estar nos formatos corretos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Os campos descrição, detalhes e URL imagem contém limites, verifique passando o mouse em cima!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Os campos obrigatórios devem ser preenchidos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return valido;
        }

        // carrega items
        public void GetItens()
        {
            dgvItens.DataSource = 0;
            dgvItens.DataSource = itemController.GetAll();
        }

        // método para passar o item obtido pelo param para os campos corretos
        private void SetCampos(Item item)
        {
            // só por garantia vamos chamar o metodo limparcampos
            txtDescr.Text = item.Descricao;
            txtPreco.Text = Convert.ToString(item.Preco);
            txtTempoPrep.Text = Convert.ToString(item.TempoPreparo);
            txtDetalhes.Text = item.Detalhes;

            if (item.URLImagem != string.Empty) // para não dar erro ao mandar um URLImagem vazia é necessário verificar
            {
                pctImagem.Image = Image.FromFile(item.URLImagem);
                txtUrl.Text = item.URLImagem;
            }
            else
            {
                pctImagem.Image = null;
                txtUrl.Text = "";
            }
        }

        // método para limpar os campos
        private void LimparCampos()
        {
            itemSel = null;
            dgvItens.ClearSelection();
            txtDescr.Clear();
            txtDetalhes.Clear();
            txtPreco.Clear();
            txtTempoPrep.Clear();
            pctImagem.Image = null;
            txtUrl.Clear();
        }

        // metodos changecontrols
        private void AlterControls(bool chav)
        {
            txtDescr.Enabled = chav;
            txtDetalhes.Enabled = chav;
            txtPreco.Enabled = chav;
            txtTempoPrep.Enabled = chav;
            btnSalvar.Enabled = chav;
            btnImagem.Enabled = chav;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            dgvItens.DataSource = itemController.GetItemsByDescr("%" + txtProcurar.Text + "%");
        }

        private void dgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                // variavel que armazenara a quantidade de linhas
                int qtdL = dgvItens.Rows.Count;
                int qtdC = dgvItens.Columns.Count; // qtd de colunas

                // caso o meu objeto que esta sendo recebido 'e' (event) tiver linhas menos que zero ou 
                // colunas ou maior que a quatidade retornará nada
                if ((e.RowIndex < 0 || e.ColumnIndex < 0) || (e.RowIndex > qtdL || e.ColumnIndex > qtdC))
                    return;

                // busco usuario pelo Id obtido na linha do indice clicado na celula 0 "primeira celula"
                // e atribuo a item ID
                int itemId = Convert.ToInt32(dgvItens.Rows[e.RowIndex].Cells[0].Value);

                itemSel = null; // limpando o itemSel
                itemSel = itemController.GetById(itemId);

                // chma o metodo responsavel por setar os campos
                SetCampos(itemSel);

                // metodo altercontrols
                AlterControls(true);
                btnExcluir.Enabled = true;
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Erro ao buscar no item clicado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Erro: " + ex);
            }
        }
    }
}
