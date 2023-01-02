using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCrud
{
    public partial class telaCadastro : Form
    {
        public Livro livro = new Livro();
        public telaCadastro(Livro livro)
        {
            try
            {
                InitializeComponent();
                if (livro != null)
                {
                    nomeTextBox.Text = livro.Nome;
                    autorTextBox.Text = livro.Autor;
                    editoraTextBox.Text = livro.Editora;
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Cadastre um livro");
            }
        }

        private void aoClicarEmVoltar(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void aoClicarEmSalvar(object sender, EventArgs e)
        {
            try
            {
                livro.Nome = nomeTextBox.Text;
                livro.Autor = autorTextBox.Text;
                livro.Editora = editoraTextBox.Text;
                livro.AnoPublicacao = Convert.ToDateTime(anoPublicacaodateTime.Text);

                if (Validacao.ValidarCampo(livro) == true)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
