using System;
using System.Windows.Forms;
using System.Drawing; 
using View.Biblio;

namespace TelaCliente
{
    public class MenuAtualizaCliente : Form{

        BiblioButtonAtualiza btnAtualiza;
        BiblioButtonCancela btnCancela;

        BiblioLabel lbId;
        BiblioLabel lbNome;
        BiblioLabel lbAniversario;
        BiblioLabel lbIdentificacao;
        BiblioLabel lbDiasRetorno;

        BiblioTextBox tbId;
        BiblioTextBox tbNome;
        BiblioTextBox tbAniversario;

        BiblioMaskedTextBox mtbIdentificacao;

        BiblioNumericUpDown nupDiasRetorno;

        public MenuAtualizaCliente(string id) {
            Model.Cliente cliente;
            cliente = Controller.Cliente.GetCliente(Convert.ToInt32(id));

            btnAtualiza = new BiblioButtonAtualiza(
                Text = this.Text,
                Location = new Point(20, 170),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnAtualiza.Click += new EventHandler(this.btnAtualizaClick);
            
            btnCancela = new BiblioButtonCancela(
                Text = this.Text,
                Location = new Point(110, 170),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCancela.Click += new EventHandler(this.btnCancelaClick);


            lbId = new BiblioLabel(
                Text = "Id Cliente",
                Location = new Point(5, 15),
                Font = new Font(this.Font, FontStyle.Bold)  
            );
            lbNome = new BiblioLabel(Text = "Nome",
                Location = new Point(5, 45),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbAniversario = new BiblioLabel(Text = "Aniversario",
                Location = new Point(5, 75),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbIdentificacao = new BiblioLabel(Text = "Identificação",
                Location = new Point(5, 105),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbDiasRetorno = new BiblioLabel(Text = "DiasRetorno",
                Location = new Point(5, 135),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            
            tbId = new BiblioTextBox (
                Location = new Point(105, 15),
                Size = new Size(100, 10)
            );
            tbNome = new BiblioTextBox(
                Location = new Point(105, 45),
                Size = new Size(100, 10)
            );
            tbAniversario = new BiblioTextBox(
                Location = new Point(105, 75),
                Size = new Size(100, 10)
            );


            mtbIdentificacao = new BiblioMaskedTextBox(
                Location = new Point(105, 105),
                Size = new Size(100, 10)
            ) {
                Mask = "000.000.000-00"
            };


            nupDiasRetorno = new BiblioNumericUpDown(
                Location = new Point(105, 135),
                Size = new Size(100, 10)               
            ) {
                Value = 5,
                Maximum = 30,
                Minimum = 5,
                Increment = 5,
                ReadOnly = true
            };
            

            this.Controls.Add(btnAtualiza);
            this.Controls.Add(btnCancela);
            this.Controls.Add(lbId);
            this.Controls.Add(lbNome);
            this.Controls.Add(lbAniversario);
            this.Controls.Add(lbIdentificacao);
            this.Controls.Add(lbDiasRetorno);
            this.Controls.Add(tbId);
            this.Controls.Add(tbNome);
            this.Controls.Add(tbAniversario);
            this.Controls.Add(mtbIdentificacao);
            this.Controls.Add(nupDiasRetorno);


            this.Text = "Atualização de Clientes";
            this.Size = new Size(220, 250);
        }
        private void btnCancelaClick(object sender, EventArgs e) {
            this.Close();
        }
        private void btnAtualizaClick(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show(
                "Atualizar Cliente?",
                "Atualização do Cliente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    // int id = Convert.ToInt32(tbId);
                    // Controller.Cliente.AtualizarCliente(id);
                    MessageBox.Show("Atualização efetuada com Sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Atualização Cancelada!");
            } else {
                MessageBox.Show("Opção Inválida");
            }
            this.Close();
        }
    }
}