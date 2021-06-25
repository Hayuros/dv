using System;
using System.Windows.Forms;
using System.Drawing; 
using View.Biblio;

namespace TelaCliente
{
    public class MenuListaCliente : Form{

        BiblioButtonEdita btnEdita;
        BiblioButtonCancela btnCancela;

        BiblioLabel lbNome;
        BiblioLabel lbAniversario;
        BiblioLabel lbIdentificacao;
        BiblioLabel lbDiasRetorno;
        BiblioLabel lbNomeBd;
        BiblioLabel lbAniversarioBd;
        BiblioLabel lbIdentificacaoBd;
        BiblioLabel lbDiasRetornoBd;

        public MenuListaCliente(string id) {
            Model.Cliente cliente;
            cliente = Controller.Cliente.GetCliente(Convert.ToInt32(id));

            btnCancela = new BiblioButtonCancela(
                Text = this.Text,
                Location = new Point(110, 165),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCancela.Click += new EventHandler(this.btnCancelaClick);

            lbNome = new BiblioLabel(
                Text = "Nome",
                Location = new Point(5, 15),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbAniversario = new BiblioLabel(
                Text = "Aniversario",
                Location = new Point(5, 45),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbIdentificacao = new BiblioLabel(
                Text = "Identificação",
                Location = new Point(5, 75),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbDiasRetorno = new BiblioLabel(
                Text = "DiasRetorno",
                Location = new Point(5, 105),
                Font = new Font(this.Font, FontStyle.Bold)
            );

            lbNomeBd = new BiblioLabel(
                Text = cliente.Nome,
                Location = new Point(110, 15),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbAniversarioBd = new BiblioLabel(
                Text = cliente.Aniversario.ToString(),
                Location = new Point(110, 45),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbIdentificacaoBd = new BiblioLabel(
                Text = cliente.Identificacao.ToString(),
                Location = new Point(110, 75),
                Font = new Font(this.Font, FontStyle.Bold)
            ) {
                Size = new Size(100, 100)
            };
            lbDiasRetornoBd = new BiblioLabel(
                Text = cliente.DiasRetorno.ToString(),
                Location = new Point(110, 105),
                Font = new Font(this.Font, FontStyle.Bold)
            ) {
                Size = new Size(150, 100)
            };
            
            this.Controls.Add(btnCancela);
            this.Controls.Add(lbNome);
            this.Controls.Add(lbAniversario);
            this.Controls.Add(lbIdentificacao);
            this.Controls.Add(lbDiasRetorno);
            this.Controls.Add(lbNomeBd);
            this.Controls.Add(lbAniversarioBd);
            this.Controls.Add(lbIdentificacaoBd);
            this.Controls.Add(lbDiasRetornoBd);


            this.Text = "Edição de Clientes";
            this.Size = new Size(250, 250);
        }
        private void btnCancelaClick(object sender, EventArgs e) {
            this.Close();
        }
    }
}