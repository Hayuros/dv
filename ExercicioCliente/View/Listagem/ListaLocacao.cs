using System;
using System.Windows.Forms;
using System.Drawing; 
using View.Biblio;

namespace TelaLocacao {
    public class MenuListaLocacao : Form {
        BiblioButtonCancela btnCancela;

        BiblioLabel lbIdCLiente;
        BiblioLabel lbDataLocacao;
        BiblioLabel lbIdVeiculoLeve;
        BiblioLabel lbIdVeiculoPesado;
        BiblioLabel lbIdCLienteBd;
        BiblioLabel lbDataLocacaoBd;
        BiblioLabel lbIdVeiculoLeveBd;
        BiblioLabel lbIdVeiculoPesadoBd;

        public MenuListaLocacao(string id) {
            Model.Locacao locacao;
            locacao = Controller.Locacao.GetLocacao(Convert.ToInt32(id));
            
            btnCancela = new BiblioButtonCancela(
                Text = this.Text,
                Location = new Point(110, 275),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCancela.Click += new EventHandler(btnCancelaClick);

            
            lbIdCLiente = new BiblioLabel(
                Text = "Controller.Locacao.ListaLocacao()", 
                Location = new Point(5, 25),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbIdVeiculoLeve = new BiblioLabel(
                Text = "Id Veículo Leve",
                Location = new Point(5, 50),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbIdVeiculoPesado = new BiblioLabel(
                Text = "Veículo Pesado",
                Location = new Point(5, 75),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbDataLocacao = new BiblioLabel(
                Text = "Data de Locação",
                Location = new Point(5, 100),
                Font = new Font(this.Font, FontStyle.Bold)
            ) {
                Size = new Size(200, 15)
            };

            lbIdCLienteBd = new BiblioLabel(
                Text = locacao.IdCliente.ToString(),
                Location = new Point(100, 25),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbDataLocacaoBd = new BiblioLabel(
                Text = locacao.DataLocacao.ToString(),
                Location = new Point(100, 50),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbIdVeiculoLeveBd = new BiblioLabel(
                Text = "locacao.veiculo.veiculoLeve.Preco",
                Location = new Point(100, 75),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbIdVeiculoPesadoBd = new BiblioLabel(
                Text = "locacao.idVeiculoPesado",
                Location = new Point(100, 100),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            this.Controls.Add(btnCancela);   
            this.Controls.Add(lbIdCLiente);
            this.Controls.Add(lbIdVeiculoLeve);
            this.Controls.Add(lbIdVeiculoPesado);
            this.Controls.Add(lbDataLocacao); 
            this.Controls.Add(lbIdCLienteBd);
            this.Controls.Add(lbDataLocacaoBd);
            this.Controls.Add(lbIdVeiculoLeveBd);
            this.Controls.Add(lbIdVeiculoPesadoBd);

            this.Text = "Edição de Locações";
            this.Size = new Size(220, 350);
        }

        private void btnCancelaClick(object sender, EventArgs e) {
            this.Close();
        }
    }
}