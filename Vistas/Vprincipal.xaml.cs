namespace JJAENT1.Vistas;

public partial class Vprincipal : ContentPage
{
	public Vprincipal()
	{
		InitializeComponent();
	}
    private async void btnCalcularAporteClicked(object sender, EventArgs e)
    {
        // extraccion de valores ingresados
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        int edad = Convert.ToInt32(txtEdad.Text);
        double salario = Convert.ToDouble(txtSalario.Text);

        // Calculo del aporte al IESS
        double aporteIESS = salario * 0.0945;

        // Mostrar de recuadro con los detalles de ingreso
        await DisplayAlert("Aportacion al IESS",
                           $"Bienvenido {nombre} {apellido}!\n\n" +
                           $"Tienes {edad} años.\n\n" +
                           $"Tu aporte mensual al IESS es: ${aporteIESS.ToString("0.00")}",
                           "Aceptar");
    }

}