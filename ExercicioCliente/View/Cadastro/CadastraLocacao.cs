using System;
using System.Windows.Forms;
using System.Drawing; 
using System.Collections.Generic;
using View.Biblio;

namespace TelaLocacao {
    public class MenuCadastraLocacao : Form {
        List<Model.VeiculoPesado> VeiculosPesados = new List<Model.VeiculoPesado>();
        List<Model.VeiculoLeve> VeiculosLeves = new List<Model.VeiculoLeve>();

        //Todas as Páginas
        BiblioMonthCalendar mcDataLocacao;
        BiblioTabPage tpVeiculoLeve;
        BiblioTabPage tpVeiculoPesado;
        BiblioTabPage tpCliente;
        BiblioTabControl tcVeiculos;
        BiblioButtonCadastra btnCadastra;
        BiblioButtonCancela btnCancela;

        //Página do Cliente
        BiblioLabel lbIdCLiente;
        BiblioComboBox cbIdCLiente;
        BiblioLabel lbDataLocacao;

        //Página do Veículo Leve
        BiblioLabel lbIdVeiculoLeve;
        BiblioLabel lbModeloVeiculoLeve;
        BiblioLabel lbMarcaVeiculoLeve;
        BiblioLabel lbPrecoVeiculoLeve;
        BiblioLabel lbAnoVeiculoLeve;
        BiblioTextBox tbModeloVeiculoLeve;
        BiblioTextBox tbMarcaVeiculoLeve;
        BiblioTextBox tbAnoVeiculoLeve;
        BiblioMaskedTextBox mtbPrecoVeiculoLeve;
        BiblioComboBox cbIdVeiculoLeve;

        //Página do Veículo Pesado
        BiblioLabel lbIdVeiculoPesado;
        BiblioLabel lbModeloVeiculoPesado;
        BiblioLabel lbMarcaVeiculoPesado;
        BiblioLabel lbPrecoVeiculoPesado;
        BiblioLabel lbAnoVeiculoPesado;
        BiblioTextBox tbModeloVeiculoPesado;
        BiblioTextBox tbMarcaVeiculoPesado;
        BiblioTextBox tbAnoVeiculoPesado;
        BiblioMaskedTextBox mtbPrecoVeiculoPesado;
        BiblioComboBox cbIdVeiculoPesado;

       
        public MenuCadastraLocacao() {
            //Todas as Páginas
            btnCadastra = new BiblioButtonCadastra(
                Text = this.Text,
                Location = new Point(25, 200),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCadastra.Click += new EventHandler(btnCadastraClick);
            
            btnCancela = new BiblioButtonCancela(
                Text = this.Text,
                Location = new Point(110, 200),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCancela.Click += new EventHandler(btnCancelaClick);

            tcVeiculos = new BiblioTabControl(
                Text = "Veículos",
                Location = new Point(1, 1),
                Size = new Size(250, 350)
            );
            
            //Página do CLiente
            lbIdCLiente = new BiblioLabel(
                Text = "Id Cliente", 
                Location = new Point(5, 5),
                Font = new Font(this.Font, FontStyle.Bold)
            );

            cbIdCLiente = new BiblioComboBox(
                Location = new Point(110, 5),
                Size = new Size(100, 10)
            );
            cbIdCLiente.Items.AddRange(new string[]{"1", "2", "3", "4"});

            lbDataLocacao = new BiblioLabel(
                Text = "Data de Locação",
                Location = new Point(5, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            ) {
                Size = new Size(200, 15)
            };

            mcDataLocacao = new BiblioMonthCalendar(
                Location = new Point(5, 40)
            ) {
                MaxDate = new DateTime(2022, 12, 31),
                MinDate = DateTime.Today,
                ShowToday = true
            };

            tpCliente = new BiblioTabPage(
                Text = "Cliente",
                Size = new Size(250, 350)
            );

            //Página do Veículo Leve
            lbIdVeiculoLeve = new BiblioLabel(
                Text = "Id Veículo Leve",
                Location = new Point(5, 5),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbModeloVeiculoLeve = new BiblioLabel(
                Text = "Modelo Veículo Leve",
                Location = new Point(5, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbMarcaVeiculoLeve = new BiblioLabel(
                Text = "Marca Veículo Leve",
                Location = new Point(5, 55),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbPrecoVeiculoLeve = new BiblioLabel(
                Text = "Preco Veículo Leve",
                Location = new Point(5, 80),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbAnoVeiculoLeve = new BiblioLabel(
                Text = "Ano Veículo Leve",
                Location = new Point(5, 105),
                Font = new Font(this.Font, FontStyle.Bold)
            );

            tbModeloVeiculoLeve = new BiblioTextBox(
                Location = new Point(110, 30),
                Size = new Size(100, 5)
            );
            tbMarcaVeiculoLeve = new BiblioTextBox(
                Location = new Point(110, 55),
                Size = new Size(100, 5)
            );
            tbAnoVeiculoLeve = new BiblioTextBox(
                Location = new Point(110, 105),
                Size = new Size(100, 5)
            );
            mtbPrecoVeiculoLeve = new BiblioMaskedTextBox(
                Location = new Point(110, 80),
                Size = new Size(100, 5)
            ) {
                Mask = "$: "
            };

            tpVeiculoLeve = new BiblioTabPage(
                Text = "Veículo Leve",
                Size = new Size(250, 350)
            );
            cbIdVeiculoLeve = new BiblioComboBox(
                Location = new Point(110, 5),
                Size = new Size(100, 10)
            );
            cbIdVeiculoLeve.Items.AddRange(new string[]{"1", "2", "3", "4"});

            //Página do Veículo Pesado
            lbIdVeiculoPesado = new BiblioLabel(
                Text = "Veículo Pesado",
                Location = new Point(5, 5),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbModeloVeiculoPesado = new BiblioLabel(
                Text = "Modelo Veículo Pesado",
                Location = new Point(5, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbMarcaVeiculoPesado = new BiblioLabel(
                Text = "Marca Veículo Pesado",
                Location = new Point(5, 55),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbPrecoVeiculoPesado = new BiblioLabel(
                Text = "Preco Veículo Pesado",
                Location = new Point(5, 80),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbAnoVeiculoPesado = new BiblioLabel(
                Text = "Ano Veículo Pesado",
                Location = new Point(5, 105),
                Font = new Font(this.Font, FontStyle.Bold)
            );

            tbModeloVeiculoPesado = new BiblioTextBox(
                Location = new Point(110, 30),
                Size = new Size(100, 5)
            );
            tbMarcaVeiculoPesado = new BiblioTextBox(
                Location = new Point(110, 55),
                Size = new Size(100, 5)
            );
            tbAnoVeiculoPesado = new BiblioTextBox(
                Location = new Point(110, 105),
                Size = new Size(100, 5)
            );
            mtbPrecoVeiculoPesado = new BiblioMaskedTextBox(
                Location = new Point(110, 80),
                Size = new Size(100, 5)
            ) {
                Mask = "$: "
            };
            
            cbIdVeiculoPesado = new BiblioComboBox(
                Location = new Point(110, 5),
                Size = new Size(100, 10)
            );
            int IVP = Convert.ToInt32(cbIdVeiculoPesado.SelectedValue);
            string IdVeiculoPesado = Convert.ToString(Model.VeiculoPesado.GetVeiculoPesado(IVP));
            cbIdVeiculoPesado.Items.AddRange(new string[]{IdVeiculoPesado});

            tpVeiculoPesado = new BiblioTabPage(
                Text = "Veículo Pesado",
                Size = new Size(250, 350)
            );

            //Configurações da Página
            tcVeiculos.Controls.Add(this.tpCliente);
            tcVeiculos.Controls.Add(this.tpVeiculoLeve);
            tcVeiculos.Controls.Add(this.tpVeiculoPesado);

            tpCliente.Controls.Add(this.lbIdCLiente);
            tpCliente.Controls.Add(this.lbDataLocacao);
            tpCliente.Controls.Add(this.cbIdCLiente);  
            tpCliente.Controls.Add(this.mcDataLocacao); 

            tpVeiculoLeve.Controls.Add(this.lbIdVeiculoLeve);
            tpVeiculoLeve.Controls.Add(this.lbModeloVeiculoLeve);
            tpVeiculoLeve.Controls.Add(this.lbMarcaVeiculoLeve);
            tpVeiculoLeve.Controls.Add(this.lbPrecoVeiculoLeve);
            tpVeiculoLeve.Controls.Add(this.lbAnoVeiculoLeve);
            tpVeiculoLeve.Controls.Add(this.tbModeloVeiculoLeve);
            tpVeiculoLeve.Controls.Add(this.tbMarcaVeiculoLeve);
            tpVeiculoLeve.Controls.Add(this.mtbPrecoVeiculoLeve);
            tpVeiculoLeve.Controls.Add(this.tbAnoVeiculoLeve);
            tpVeiculoLeve.Controls.Add(this.cbIdVeiculoLeve);  

            tpVeiculoPesado.Controls.Add(this.lbIdVeiculoPesado);
            tpVeiculoPesado.Controls.Add(this.lbModeloVeiculoPesado);
            tpVeiculoPesado.Controls.Add(this.lbMarcaVeiculoPesado);
            tpVeiculoPesado.Controls.Add(this.lbPrecoVeiculoPesado);
            tpVeiculoPesado.Controls.Add(this.lbAnoVeiculoPesado);
            tpVeiculoPesado.Controls.Add(this.tbModeloVeiculoPesado);
            tpVeiculoPesado.Controls.Add(this.tbMarcaVeiculoPesado);
            tpVeiculoPesado.Controls.Add(this.tbAnoVeiculoPesado);
            tpVeiculoPesado.Controls.Add(this.mtbPrecoVeiculoPesado);
            tpVeiculoPesado.Controls.Add(this.cbIdVeiculoPesado); 

            this.Controls.Add(btnCadastra);  
            this.Controls.Add(btnCancela);  
            this.Controls.Add(tcVeiculos);

            this.Text = "Cadastro de Locações";
            this.Size = new Size(250, 350);
        }

        private void btnCancelaClick(object sender, EventArgs e) {
            // Application.Run(new Program());
            this.Close();
        }
        private void btnCadastraClick(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show(
                "Cadastrar Locação?",
                "Cadastro de Locações",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == DialogResult.Yes)
            {

                string stIdCliente = Convert.ToString(cbIdCLiente.SelectedValue);
                string stDataLocacao = Convert.ToString(mcDataLocacao.SelectionStart);
                int stVeiculoLeve = Convert.ToInt32(cbIdVeiculoLeve.SelectedValue);
                int stVeiculoPesado = Convert.ToInt32(cbIdVeiculoPesado.SelectedValue);

                Model.VeiculoPesado veiculoPesado = Controller.VeiculoPesado.GetVeiculoPesado(stVeiculoPesado);
                VeiculosPesados.Add(veiculoPesado);
                Model.VeiculoLeve veiculoLeve = Controller.VeiculoLeve.GetVeiculoLeve(stVeiculoLeve);
                VeiculosLeves.Add(veiculoLeve);
                try
                {
                    Controller.Locacao.CriarLocacao(stIdCliente, stDataLocacao,VeiculosLeves, VeiculosPesados);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Cadastro efetuado com Sucesso!");
            } else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Cadastro Cancelado!");
            } else {
                MessageBox.Show("Opção Inválida");
            }
            this.Close();
        }
    }
}