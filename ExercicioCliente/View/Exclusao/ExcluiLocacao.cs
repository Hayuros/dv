using System;
using System.Windows.Forms;
using System.Drawing; 
using View.Biblio;

namespace TelaLocacao {
    public class MenuExcluiLocacao : Form {
        BiblioButtonExclui btnExclui;
        BiblioButtonCancela btnCancela;


        BiblioLabel lbIdLocacao;
        BiblioLabel lbIdCLiente;
        BiblioLabel lbDataLocacao;
        BiblioLabel lbIdVeiculoLeve;
        BiblioLabel lbIdVeiculoPesado;

        BiblioTextBox tbIdLocacao;

        BiblioMonthCalendar mcDataLocacao;

        BiblioComboBox cbIdCLiente;
        BiblioComboBox cbIdVeiculoLeve;
        BiblioComboBox cbIdVeiculoPesado;

        public MenuExcluiLocacao() {
            btnExclui = new BiblioButtonExclui(
                Text = this.Text,
                Location = new Point(25, 45),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnExclui.Click += new EventHandler(btnExcluiClick);
            
            btnCancela = new BiblioButtonCancela(
                Text = this.Text,
                Location = new Point(110, 45),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCancela.Click += new EventHandler(btnCancelaClick);

            lbIdLocacao = new BiblioLabel(
                Text = "Id Locação",
                Location = new Point(5, 15),
                Font = new Font(this.Font, FontStyle.Bold)
            );

            tbIdLocacao = new BiblioTextBox(
                Location = new Point(110, 15),
                Size = new Size(100, 10)
            );


            this.Controls.Add(btnExclui);  
            this.Controls.Add(btnCancela);  
            this.Controls.Add(tbIdLocacao);
            this.Controls.Add(lbIdLocacao); 

            this.Text = "Exclusão de Locações";
            this.Size = new Size(220, 100);
        }

        private void btnCancelaClick(object sender, EventArgs e) {
            this.Close();
        }
        private void btnExcluiClick(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show(
                "Excluir Locação?",
                "Exclusão de Locações",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == DialogResult.Yes)
            {
                int Id = Convert.ToInt32(tbIdLocacao.Text);
                try
                {
                    Model.Locacao.ExcluirLocacao(Id);
                    MessageBox.Show("Exclusão efetuada com Sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Está exclusão não foi permitida/Id Inválido.");
                }

            } else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Exclusão Cancelada!");
            } else {
                MessageBox.Show("Opção Inválida");
            }
            this.Close();
        }
    }
}