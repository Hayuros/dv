using System;
using System.Windows.Forms;
using System.Drawing;
using View.Biblio;

namespace TelaVeiculoPesado
{
    public class MenuListaVeiculoPesado : Form{
        BiblioButtonEdita btnEdita;
        BiblioButtonCancela btnCancela;
        
        BiblioLabel lbMarca;
        BiblioLabel lbModelo;
        BiblioLabel lbAnoVeiculo;
        BiblioLabel lbPreco;
        BiblioLabel lbRestricoes;

        BiblioTextBox tbMarca;
        BiblioTextBox tbModelo;
        BiblioTextBox tbPreco;
        BiblioTextBox tbRestricoes;

        BiblioDateTimePicker dtpAnoVeiculo;

        public MenuListaVeiculoPesado(string id) {           
            btnEdita = new BiblioButtonEdita(
                Text = this.Text,
                Location = new Point(30, 160),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnEdita.Click += new EventHandler(this.btnEditaClick);
            btnCancela = new BiblioButtonCancela(
                Text = this.Text,
                Location = new Point(110 , 160),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCancela.Click += new EventHandler(this.btnCancelaClick);
            
            lbMarca = new BiblioLabel(
                Text = "Marca",
                Location = new Point(5, 10),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbModelo = new BiblioLabel(
                Text = "Modelo",
                Location = new Point(5, 40),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbAnoVeiculo = new BiblioLabel(
                Text = "Ano do Veiculo",
                Location = new Point(5, 70),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbPreco = new BiblioLabel(
                Text = "Preco",
                Location = new Point(5,  100),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbRestricoes = new BiblioLabel(
                Text = "Restrições",
                Location = new Point(5, 130),
                Font = new Font(this.Font, FontStyle.Bold)
            );

            tbMarca = new BiblioTextBox(
                Location = new Point(105, 10),
                Size = new Size(100, 10)
            );
            tbModelo = new BiblioTextBox(
                Location = new Point(105, 40),
                Size = new Size(100, 10)
            );
            tbPreco = new BiblioTextBox(
                Location = new Point(105,  100),
                Size = new Size(100, 10)
            );
            tbRestricoes = new BiblioTextBox(
                Location = new Point(105, 130),
                Size = new Size(100, 10)
            );

            dtpAnoVeiculo = new BiblioDateTimePicker(
                Location = new Point(105, 70),
                Size = new Size(100, 10)                
            ) {
                MaxDate = DateTime.Today,
                MinDate = new DateTime(2005, 12, 31),
                CustomFormat = "yyyy",
                Format = DateTimePickerFormat.Custom
            };

            this.Controls.Add(btnEdita);
            this.Controls.Add(btnCancela);
            this.Controls.Add(lbMarca);
            this.Controls.Add(lbModelo);
            this.Controls.Add(lbAnoVeiculo);
            this.Controls.Add(lbPreco);
            this.Controls.Add(lbRestricoes);
            this.Controls.Add(tbMarca);
            this.Controls.Add(tbModelo);
            this.Controls.Add(tbPreco);
            this.Controls.Add(tbRestricoes);
            this.Controls.Add(dtpAnoVeiculo);
            
            this.Text = "Edição de Veículos Pesados";
            this.Size = new Size(220, 220);
        }

        private void btnEditaClick(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show(
                "Editar Veículo Pesado?",
                "Edição de Veículo Pesado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    Controller.VeiculoPesado.ListaVeiculosPesados();
                    MessageBox.Show("Edição efetuado com Sucesso!");    
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
                
            } else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Edição Cancelado!");
            } else {
                MessageBox.Show("Opção Inválida");
            }
            this.Close();
        }
        private void btnCancelaClick(object sender, EventArgs e) {
            this.Close();
        }
    }
}