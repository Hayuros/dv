using System;
using System.Windows.Forms;
using System.Drawing;
using TelaCliente;
using TelaLocacao;
using TelaVeiculoLeve;
using TelaVeiculoPesado;
using View.Biblio;

namespace ExercicioCliente
{
    public class Program : Form
    {
        string id;     
        BiblioButton btnCadastraCliente;
        BiblioButton btnCadastraLocacao;
        BiblioButton btnCadastraVeiculoLeve;
        BiblioButton btnCadastraVeiculoPesado;
        BiblioButton btnListaCliente;
        BiblioButton btnListaLocacao;
        BiblioButton btnListaVeiculoLeve;
        BiblioButton btnListaVeiculoPesado;
        BiblioButton btnExcluiCliente;
        BiblioButton btnExcluiLocacao;
        BiblioButton btnExcluiVeiculoLeve;
        BiblioButton btnExcluiVeiculoPesado;
        BiblioButton btnAtualizaCliente;
        BiblioButton btnAtualizaVeiculoLeve;
        BiblioButton btnAtualizaVeiculoPesado;

        BiblioLabel lbTextoCLiente;
        BiblioLabel lbTextoLocacao;
        BiblioLabel lbTextoVeiculoLeve;
        BiblioLabel lbTextoVeiculoPesado;
       
        public static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new Program());
        }
        public Program()
        {
            btnCadastraCliente = new BiblioButton(
                Text = "Cadastrar Cliente",
                Location = new Point(5, 26),
                Size = new Size(75, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCadastraCliente.Click += new EventHandler(this.btnCadastraClienteClick);

            btnListaCliente = new BiblioButton(
                Text = "Listar Cliente",
                Location = new Point(80, 26),
                Size = new Size(75, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnListaCliente.Click += new EventHandler(this.btnListaClienteClick);

            btnExcluiCliente = new BiblioButton(
                Text = "Excluir Cliente",
                Location = new Point(155, 26),
                Size = new Size(75, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnExcluiCliente.Click += new EventHandler(this.btnExcluiClienteClick);

            btnAtualizaCliente = new BiblioButton(
                Text = "Atualizar Cliente",
                Location = new Point(230, 26),
                Size = new Size(75, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnAtualizaCliente.Click += new EventHandler(this.btnAtualizaClienteClick);
        
            btnCadastraLocacao = new BiblioButton(
                Text = "Cadastrar Locação",
                Location = new Point(5, 76),
                Size = new Size(75, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCadastraLocacao.Click += new EventHandler(this.btnCadastraLocacaoClick);

            btnListaLocacao = new BiblioButton(
                Text = "Listar Locação",
                Location = new Point(80, 76),
                Size = new Size(75, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnListaLocacao.Click += new EventHandler(this.btnListaLocacaoClick);

            btnExcluiLocacao = new BiblioButton(
                Text = "Excluir Locação",
                Location = new Point(155, 76),
                Size = new Size(75, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnExcluiLocacao.Click += new EventHandler(this.btnExcluiLocacaoClick);
            
            btnCadastraVeiculoLeve = new BiblioButton(
                Text = "Cadastrar Veículo Leve",
                Location = new Point(5, 126),
                Size = new Size(100, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCadastraVeiculoLeve.Click += new EventHandler(this.btnCadastraVeiculoLeveCLick);

            btnListaVeiculoLeve = new BiblioButton(
                Text = "Listar Veículo Leve",
                Location = new Point(105, 126),
                Size = new Size(100, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnListaVeiculoLeve.Click += new EventHandler(this.btnListaVeiculoLeveClick);

            btnExcluiVeiculoLeve = new BiblioButton(
                Text = "Excluir Veículo Leve",
                Location = new Point(205, 126),
                Size = new Size(100, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnExcluiVeiculoLeve.Click += new EventHandler(this.btnExcluiVeiculoLeveClick);

            btnAtualizaVeiculoLeve = new BiblioButton(
                Text = "Atualizar Veículo Leve",
                Location = new Point(305, 126),
                Size = new Size(100, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnAtualizaVeiculoLeve.Click += new EventHandler(this.btnAtualizaVeiculoLeveClick);

            btnCadastraVeiculoPesado = new BiblioButton(
                Text = "Cadastrar Veículo Pesado",
                Location = new Point(5, 176),
                Size = new Size(105, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCadastraVeiculoPesado.Click += new EventHandler(this.btnCadastraVeiculoPesadoClick);

            btnListaVeiculoPesado = new BiblioButton(
                Text = "Listar Veículo Pesado",
                Location = new Point(105, 176),
                Size = new Size(105, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnListaVeiculoPesado.Click += new EventHandler(this.btnListaVeiculoPesadoClick);

            btnExcluiVeiculoPesado = new BiblioButton(
                Text = "Excluir Veículo Pesado",
                Location = new Point(205, 176),
                Size = new Size(105, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnExcluiVeiculoPesado.Click += new EventHandler(this.btnExcluiVeiculoPesadoClick);

            btnAtualizaVeiculoPesado = new BiblioButton(
                Text = "Atualizar Veículo Pesado",
                Location = new Point(305, 176),
                Size = new Size(105, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnAtualizaVeiculoPesado.Click += new EventHandler(this.btnAtualizaVeiculoPesadoClick);
            

            lbTextoCLiente = new BiblioLabel(
                Text = "----------Cliente----------",
                Location = new Point(80, 5),
                Font = new Font(this.Font, FontStyle.Bold)
            ) {
                Size = new Size(200, 30)
            };

            lbTextoLocacao = new BiblioLabel(
                Text = "----------Locação----------",
                Location = new Point(80, 57),
                Font = new Font(this.Font, FontStyle.Bold)
            ) {
                Size = new Size(200, 30)
            };

            lbTextoVeiculoLeve = new BiblioLabel(
                Text = "----------Veículo Leve----------",
                Location = new Point(110, 107),
                Font = new Font(this.Font, FontStyle.Bold)
            ) {
                Size = new Size(200, 30)
            };

            lbTextoVeiculoPesado = new BiblioLabel(
                Text = "----------Veículo Pesado----------",
                Location = new Point(110, 157),
                Font = new Font(this.Font, FontStyle.Bold)
            ) {
                Size = new Size(200, 30)
            };


            this.Controls.Add(btnCadastraCliente);
            this.Controls.Add(btnCadastraLocacao);
            this.Controls.Add(btnCadastraVeiculoLeve);
            this.Controls.Add(btnCadastraVeiculoPesado);
            this.Controls.Add(btnListaCliente);
            this.Controls.Add(btnListaLocacao);
            this.Controls.Add(btnListaVeiculoLeve);
            this.Controls.Add(btnListaVeiculoPesado);
            this.Controls.Add(btnExcluiCliente);
            this.Controls.Add(btnExcluiLocacao);
            this.Controls.Add(btnExcluiVeiculoLeve);
            this.Controls.Add(btnExcluiVeiculoPesado);
            this.Controls.Add(btnAtualizaCliente);
            this.Controls.Add(btnAtualizaVeiculoLeve);
            this.Controls.Add(btnAtualizaVeiculoPesado);
            this.Controls.Add(lbTextoCLiente);
            this.Controls.Add(lbTextoLocacao);
            this.Controls.Add(lbTextoVeiculoLeve);
            this.Controls.Add(lbTextoVeiculoPesado);

            this.Text = "Programa de Locação de Veículos";
            this.Size = new Size(430, 247);
            Application.Run(this);
            
        }

        private void btnCadastraClienteClick(object sender, EventArgs e) {
            MenuCadastraCliente menuCadastraCliente = new MenuCadastraCliente();
            menuCadastraCliente.Show();
        }
        private void btnCadastraLocacaoClick(object sender, EventArgs e) {
            MenuCadastraLocacao menuCadastraLocacao = new MenuCadastraLocacao();
            menuCadastraLocacao.Show();
        }
        private void btnCadastraVeiculoLeveCLick(object sender, EventArgs e) {
            MenuCadastraVeiculoLeve menuCadastraVeiculoLeve = new MenuCadastraVeiculoLeve();
            menuCadastraVeiculoLeve.Show();
        }
        private void btnCadastraVeiculoPesadoClick(object sender, EventArgs e) {
            MenuCadastraVeiculoPesado menuCadastraVeiculoPesado = new MenuCadastraVeiculoPesado();
            menuCadastraVeiculoPesado.Show(); 
        }
        private void btnListaClienteClick(object sender, EventArgs e) {
            string id = "";
            InputBox input = new InputBox(
                "Listagem de Clientes",
                "Informe o ID do Cliente",
                ref id
            );
            MenuListaCliente menuListaCliente = new MenuListaCliente(id);
            menuListaCliente.Show();
        }
        private void btnListaLocacaoClick(object sender, EventArgs e) {
            string id = "";
            InputBox input = new InputBox(
                "Listagem de Locações",
                "Informe o ID da Locação",
                ref id
            );
            MenuListaLocacao menuListaLocacao = new MenuListaLocacao(id);
            menuListaLocacao.Show();
        }
        private void btnListaVeiculoLeveClick(object sender, EventArgs e) {
            string id = "";
            InputBox input = new InputBox(
                "Listagem de Veículo Leve",
                "Informe o ID do Veículo Leve",
                ref id
            );
            MenuListaVeiculoLeve menuListaVeiculoLeve = new MenuListaVeiculoLeve(id);
            menuListaVeiculoLeve.Show();
        }
        private void btnListaVeiculoPesadoClick(object sender, EventArgs e) {
            string id = "";
            InputBox input = new InputBox(
                "Listagem de Veículo Pesado",
                "Informe o ID do Veículo Pesado",
                ref id
            );
            MenuListaVeiculoPesado menuListaVeiculoPesado = new MenuListaVeiculoPesado(id);
            menuListaVeiculoPesado.Show();
        }
        private void btnExcluiClienteClick(object sender, EventArgs e) {
            string id = "";
            InputBox input = new InputBox(
                "Exclusão de Cliente",
                "Informe o ID do Cliente",
                ref id
            );
            MenuExcluiCliente menuExcluiCliente = new MenuExcluiCliente();
            menuExcluiCliente.Show();
        }
        private void btnExcluiLocacaoClick(object sender, EventArgs e) {
            string id = "";
            InputBox input = new InputBox(
                "Exclusão de Locações",
                "Informe o ID da Locação",
                ref id
            );
            MenuExcluiLocacao menuExcluiLocacao = new MenuExcluiLocacao();
            menuExcluiLocacao.Show();
        }
        private void btnExcluiVeiculoLeveClick(object sender, EventArgs e) {
            string id = "";
            InputBox input = new InputBox(
                "Exclusão de Veículo Leve",
                "Informe o ID do Veículo Leve",
                ref id
            );
            MenuExcluiVeiculoLeve menuExcluiVeiculoLeve = new MenuExcluiVeiculoLeve();
            menuExcluiVeiculoLeve.Show();
        }
        private void btnExcluiVeiculoPesadoClick(object sender, EventArgs e) {
            string id = "";
            InputBox input = new InputBox(
                "Exclusão de Veículo Pesado",
                "Informe o ID do Veículo Pesado",
                ref id
            );
            MenuExcluiVeiculoPesado menuExcluiVeiculoPesado = new MenuExcluiVeiculoPesado();
            menuExcluiVeiculoPesado.Show();
        }
        private void btnAtualizaClienteClick(object sender, EventArgs e) {
            string id = "";
            InputBox input = new InputBox(
                "Listar o Cliente",
                "Informe o ID do Cliente",
                ref id
            );
            MenuAtualizaCliente menuAtualizaCliente = new MenuAtualizaCliente(id);
            menuAtualizaCliente.Show();
        }
        private void btnAtualizaVeiculoLeveClick(object sender, EventArgs e) {
            string id = "";
            InputBox input = new InputBox(
                "Alterar o Veículo Leve",
                "Informe o ID do Veículo Leve",
                ref id
            );
            MenuAtualizaVeiculoLeve menuAtualizaVeiculoLeve = new MenuAtualizaVeiculoLeve(id);
            menuAtualizaVeiculoLeve.Show();
        }
        private void btnAtualizaVeiculoPesadoClick(object sender, EventArgs e) {
                        string id = "";
            InputBox input = new InputBox(
                "Alterar o Veículo Leve",
                "Informe o ID do Veículo Leve",
                ref id
            );
            MenuAtualizaVeiculoPesado menuAtualizaVeiculoPesado = new MenuAtualizaVeiculoPesado();
            menuAtualizaVeiculoPesado.Show();
        }
    }
}