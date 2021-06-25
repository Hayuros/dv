using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing; 
using View.Biblio;

namespace TelaCliente
{
    public class MenuExcluiCliente : Form{

        BiblioButtonExclui btnExclui;
        BiblioButtonCancela btnCancela;

        BiblioLabel lbId;

        BiblioTextBox tbId;

        public MenuExcluiCliente() {
            btnExclui = new BiblioButtonExclui(
                Text = this.Text,
                Location = new Point(20, 50),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnExclui.Click += new EventHandler(this.btnExcluiClick);
            
            btnCancela = new BiblioButtonCancela(
                Text = this.Text,
                Location = new Point(110, 50),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCancela.Click += new EventHandler(this.btnCancelaClick);

            lbId = new BiblioLabel(
                Text = "Id Cliente",
                Location = new Point(5, 15),
                Font = new Font(this.Font, FontStyle.Bold)
            );

            tbId = new BiblioTextBox(
                Location = new Point(105, 15),
                Size = new Size(100, 10)
            );


            this.Controls.Add(btnExclui);
            this.Controls.Add(btnCancela);
            this.Controls.Add(lbId);
            this.Controls.Add(tbId);

            this.Text = "Exclusão de Clientes";
            this.Size = new Size(220, 115);
        }
        private void btnCancelaClick(object sender, EventArgs e) {
            this.Close();
        }
        private void btnExcluiClick(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show(
                "Excluir Cliente?",
                "Exclusão do Cliente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == DialogResult.Yes)
            {
                int Id = Convert.ToInt32(tbId.Text);
                try
                {
                    Model.Cliente.ExcluirCliente(Id);
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