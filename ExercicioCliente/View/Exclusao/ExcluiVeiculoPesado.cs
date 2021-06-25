using System;
using System.Windows.Forms;
using System.Drawing;
using View.Biblio;

namespace TelaVeiculoPesado
{
    public class MenuExcluiVeiculoPesado : Form{
        BiblioButtonExclui btnExclui;
        BiblioButtonCancela btnCancela;
        
        BiblioLabel lbId;

        BiblioTextBox tbId;

        public MenuExcluiVeiculoPesado() {           
            btnExclui = new BiblioButtonExclui(
                Text = this.Text,
                Location = new Point(30, 40),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnExclui.Click += new EventHandler(this.btnExcluiClick);
            btnCancela = new BiblioButtonCancela(
                Text = this.Text,
                Location = new Point(110 , 40),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCancela.Click += new EventHandler(this.btnCancelaClick);
            
            lbId = new BiblioLabel(
                Text = "Id Veículo",
                Location = new Point(5, 10),
                Font = new Font(this.Font, FontStyle.Bold)
            );

            tbId = new BiblioTextBox(
                Location = new Point(105, 10),
                Size = new Size(100, 10)
            );

            this.Controls.Add(btnExclui);
            this.Controls.Add(btnCancela);
            this.Controls.Add(lbId);
            this.Controls.Add(tbId);


            this.Text = "Exclusão de Veículos Pesados";
            this.Size = new Size(220, 100);
        }

        private void btnExcluiClick(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show(
                "Excluir Veículo Pesado?",
                "Exclusão de Veículo Pesado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    Controller.VeiculoPesado.ExcluirVeiculoPesado(tbId.Text);
                    MessageBox.Show("Exclusão efetuada com Sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Exclusão Cancelada!");
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