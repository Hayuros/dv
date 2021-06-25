using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing; 
using View.Biblio;

namespace TelaCliente
{
    public class MenuCadastraCliente : Form{

        BiblioButtonCadastra btnCadastra;
        BiblioButtonCancela btnCancela;

        BiblioLabel lbNome;
        BiblioLabel lbAniversario;
        BiblioLabel lbIdentificacao;
        BiblioLabel lbDiasRetorno;

        BiblioTextBox tbNome;

        BiblioMaskedTextBox mtbAniversario;
        BiblioMaskedTextBox mtbIdentificacao;

        BiblioNumericUpDown nupDiasRetorno;

        delegate void Del(string nome);

        public MenuCadastraCliente() {
            btnCadastra = new BiblioButtonCadastra(
                Text = this.Text,
                Location = new Point(20, 135),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCadastra.Click += new EventHandler(this.btnCadastraClick);
            
            btnCancela = new BiblioButtonCancela(
                Text = this.Text,
                Location = new Point(110, 135),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCancela.Click += new EventHandler(this.btnCancelaClick);


            lbNome = new BiblioLabel(Text = "Nome",
                Location = new Point(5, 15),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbAniversario = new BiblioLabel(Text = "Aniversario",
                Location = new Point(5, 45),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbIdentificacao = new BiblioLabel(Text = "Identificação",
                Location = new Point(5, 75),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbDiasRetorno = new BiblioLabel(Text = "DiasRetorno",
                Location = new Point(5, 105),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            

            tbNome = new BiblioTextBox(
                Location = new Point(105, 15),
                Size = new Size(100, 10)
            );
            mtbAniversario = new BiblioMaskedTextBox(
                Location = new Point(105, 45),
                Size = new Size(100, 10)
            ) {
                Mask = "00/00/0000"
            };


            mtbIdentificacao = new BiblioMaskedTextBox(
                Location = new Point(105, 75),
                Size = new Size(100, 10)
            ) {
                Mask = "000,000,000-00"
            };


            nupDiasRetorno = new BiblioNumericUpDown(
                Location = new Point(105, 105),
                Size = new Size(100, 10)               
            ) {
                Value = 5,
                Maximum = 30,
                Minimum = 5,
                Increment = 5,
                ReadOnly = true
            };
            

            this.Controls.Add(btnCadastra);
            this.Controls.Add(btnCancela);
            this.Controls.Add(lbNome);
            this.Controls.Add(lbAniversario);
            this.Controls.Add(lbIdentificacao);
            this.Controls.Add(lbDiasRetorno);
            this.Controls.Add(tbNome);
            this.Controls.Add(mtbAniversario);
            this.Controls.Add(mtbIdentificacao);
            this.Controls.Add(nupDiasRetorno);

            this.Text = "Cadastro de Clientes";
            this.Size = new Size(220, 200);
        }
        private void btnCancelaClick(object sender, EventArgs e) {
            this.Close();
        }
        private void btnCadastraClick(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show(
                "Cadastrar Cliente?",
                "Cadastro do Cliente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == DialogResult.Yes)
            {
                string stNome = tbNome.Text;
                string stAniversario = mtbAniversario.Text;
                string stIdentificacao = mtbIdentificacao.Text;
                string stDiasRetorno = Convert.ToString(nupDiasRetorno.Value);
                try {
                    Controller.Cliente.CriarCliente(stNome, stAniversario, stIdentificacao, stDiasRetorno);
                    
                    Del delNome = new Del(Notify);
                    MessageBox.Show("Cadastro efetuado com Sucesso!");
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            } else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Cadastro Cancelado!");
            } else {
                MessageBox.Show("Opção Inválida");
            }
            this.Close();
        }

        static void Notify(string stNome) {
            MessageBox.Show($"Cliente: {stNome}");
        }
    }
}