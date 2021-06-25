using System;
using System.Windows.Forms;
using System.Drawing;
using View.Biblio;

namespace TelaVeiculoLeve
{
    public class MenuAtualizaVeiculoLeve : Form{
        BiblioButtonAtualiza btnAtualiza;
        BiblioButtonCancela btnCancela;
        
        BiblioLabel lbId;
        BiblioLabel lbMarca;
        BiblioLabel lbModelo;
        BiblioLabel lbAnoVeiculo;
        BiblioLabel lbPreco;
        BiblioLabel lbCor;

        BiblioTextBox tbId;
        BiblioTextBox tbMarca;
        BiblioTextBox tbModelo;
        BiblioTextBox tbPreco;
        BiblioTextBox tbCor;

        BiblioDateTimePicker dtpAnoVeiculo;

        public MenuAtualizaVeiculoLeve(string id) {  
           
            Model.VeiculoLeve veiculoLeve;
            veiculoLeve = Controller.VeiculoLeve.GetVeiculoLeve(Convert.ToInt32(id));

         

            btnAtualiza = new BiblioButtonAtualiza(
                Text = this.Text,
                Location = new Point(30, 160),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnAtualiza.Click += new EventHandler(this.btnAtualizaClick);
            btnCancela = new BiblioButtonCancela(
                Text = this.Text,
                Location = new Point(110 , 160),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCancela.Click += new EventHandler(this.btnCancelaClick);
            
            lbId = new BiblioLabel(
                Text = "Id Veículo",
                Location = new Point(5, 10),
                Font = new Font(this.Font, FontStyle.Bold)
            );

            lbMarca = new BiblioLabel(
                Text = "Marca",
                Location = new Point(5, 40),
                Font = new Font(this.Font, FontStyle.Bold)    
            );

            lbModelo = new BiblioLabel(
                Text = "Modelo",
                Location = new Point(5, 70),
                Font = new Font(this.Font, FontStyle.Bold)    
            );

            lbAnoVeiculo = new BiblioLabel(
                Text = "Ano do Veiculo",
                Location = new Point(5, 100),
                Font = new Font(this.Font, FontStyle.Bold)    
            );

            lbPreco = new BiblioLabel(
                Text = "Preco",
                Location = new Point(5,  130),
                Font = new Font(this.Font, FontStyle.Bold)    
            );

            lbCor = new BiblioLabel(
                Text = "Cor",
                Location = new Point(5, 160),
                Font = new Font(this.Font, FontStyle.Bold)    
            );


            tbId = new BiblioTextBox(
                Location = new Point(105, 10),
                Size = new Size(100, 10)
            );
            tbId.Text = veiculoLeve.Id.ToString();

            tbMarca = new BiblioTextBox(
                Location = new Point(105, 40),
                Size = new Size(100, 10)
            );
            tbMarca.Text = veiculoLeve.Marca;

            tbModelo = new BiblioTextBox(
                Location = new Point(105, 70),
                Size = new Size(100, 10)
            );
            tbModelo.Text = veiculoLeve.Modelo;

            tbPreco = new BiblioTextBox(
                Location = new Point(105,  130),
                Size = new Size(100, 10)
            );
            tbPreco.Text = Convert.ToString(veiculoLeve.Preco);

            tbCor = new BiblioTextBox(
                Location = new Point(105, 160),
                Size = new Size(100, 10)
            );
            tbCor.Text = veiculoLeve.Cor;

            dtpAnoVeiculo = new BiblioDateTimePicker(
                Location = new Point(105, 100),
                Size = new Size(100, 10)                
            ) {
                MaxDate = DateTime.Today,
                MinDate = new DateTime(2005, 12, 31),
                CustomFormat = "yyyy",
                Format = DateTimePickerFormat.Custom
            };
            dtpAnoVeiculo.Value = new DateTime(veiculoLeve.Ano, 1, 1);


            this.Controls.Add(btnAtualiza);
            this.Controls.Add(btnCancela);
            this.Controls.Add(lbId);
            this.Controls.Add(lbMarca);
            this.Controls.Add(lbModelo);
            this.Controls.Add(lbAnoVeiculo);
            this.Controls.Add(lbPreco);
            this.Controls.Add(lbCor);
            this.Controls.Add(tbId);
            this.Controls.Add(tbMarca);
            this.Controls.Add(tbModelo);
            this.Controls.Add(tbPreco);
            this.Controls.Add(tbCor);
            this.Controls.Add(dtpAnoVeiculo);


            this.Text = "Atualização de Veículos Leves";
            this.Size = new Size(220, 220);
        }

        private void btnAtualizaClick(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show(
                "Atualizar Veículo Leve?",
                "Atualização de Veículo Leve",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    // Model.VeiculoLeve veiculoLeve;
                    // veiculoLeve = Controller.VeiculoLeve.GetVeiculoLeve(id);
                    // veiculoLeve.Marca = tbMarca.Text;
                    // veiculoLeve.Modelo = tbModelo.Text;
                    // veiculoLeve.Preco = Convert.ToDouble(tbPreco.Text);                    
                    // veiculoLeve.Cor = tbCor.Text;
                    // Controller.VeiculoLeve.AtualizarVeiculoLeve(veiculoLeve);
                    // MessageBox.Show("Atualização efetuada com Sucesso!");
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
            } else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Atualização Cancelada!");
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