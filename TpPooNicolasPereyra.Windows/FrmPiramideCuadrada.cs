using System.ComponentModel.DataAnnotations;
using System.Text;
using TpPooNicolasPereyra.Entidades;

namespace TpPooNicolasPereyra.Windows
{
    public partial class FrmPiramideCuadrada : Form
    {
        public FrmPiramideCuadrada()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void InicializarControles()
        {
            txtLado.Clear();
            txtAltura.Clear();
            txtLado.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var lado = int.Parse(txtLado.Text);
                var altura = int.Parse(txtAltura.Text);
                PiramideCuadrada p = new PiramideCuadrada(lado, altura);

                var context = new ValidationContext(p);
                var errors = new List<ValidationResult>();

                var isValid = Validator.TryValidateObject(p, context, errors, true);
                if (isValid)
                {
                    MessageBox.Show(p.ToString(), "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    AgregarPiramideCuadrada(p);
                    InicializarControles();
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var error in errors)
                    {
                        sb.AppendLine($"{error.ErrorMessage}");
                    }
                    MessageBox.Show(sb.ToString(), "Errores", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    txtLado.SelectAll();
                    txtLado.Focus();
                }
            }
        }

        private void AgregarPiramideCuadrada(PiramideCuadrada p)
        {
            LstPiramideCuadrada.Items.Add(p.MostrarDatos());
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtLado.Text, out _))
            {
                valido = false;
                errorProvider1.SetError(txtLado, "Lado mal ingresado");
            }
            if (!int.TryParse(txtAltura.Text, out _))
            {
                valido = false;
                errorProvider1.SetError(txtAltura, "Altura mal ingresado");
            }
            return valido;
        }
    }
}
