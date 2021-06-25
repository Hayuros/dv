using System;
using System.Windows.Forms;
using System.Drawing; 

namespace View
{
    namespace Biblio {
        class BiblioButton : Button{
            public BiblioButton(
                string Text,
                Point Location,
                Size Size,
                Font Font
            ) {
                this.Text = Text;
                this.Location = Location;
                this.Size = Size;
                this.Font = new Font(FontFamily.GenericSansSerif, 08.5F, FontStyle.Bold);
            }
        }
        class BiblioButtonCadastra : Button{
            public BiblioButtonCadastra(
                string Text,
                Point Location,
                Color BackColor,
                Font Font
            ) {
                this.Text = "Cadastrar!";
                this.Location = Location;
                this.BackColor = Color.Green;
                this.ForeColor = Color.White;
                this.Font = new Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold);
            }
        }

        class BiblioButtonCancela : Button {
            public BiblioButtonCancela(
                string Text,
                Point Location,
                Color BackColor,
                Font Font
            ) {
                this.Text = "Cancelar!";
                this.Location = Location;
                this.BackColor = Color.Red;
                this.ForeColor = Color.White;
                this.Font = new Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold);

            }
        }

        class BiblioButtonEdita : Button {
            public BiblioButtonEdita(
                string Text,
                Point Location,
                Color BackColor,
                Font Font
            ){
                this.Text = "Editar!";
                this.Location = Location;
                this.BackColor = Color.Green;
                this.ForeColor = Color.White;
                this.Font = new Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold);
            }
        }

        class BiblioButtonAtualiza : Button {
            public BiblioButtonAtualiza(
                string Text,
                Point Location,
                Color BackColor,
                Font Font
            ){
                this.Text = "Atualizar!";
                this.Location = Location;
                this.BackColor = Color.Green;
                this.ForeColor = Color.White;
                this.Font = new Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold);
            }
        }

        class BiblioButtonExclui : Button {
            public BiblioButtonExclui(
                string Text,
                Point Location,
                Color BackColor,
                Font Font
            ){
                this.Text = "Excluir!";
                this.Location = Location;
                this.BackColor = Color.Green;
                this.ForeColor = Color.White;
                this.Font = new Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold);
            }
        }
    }
}