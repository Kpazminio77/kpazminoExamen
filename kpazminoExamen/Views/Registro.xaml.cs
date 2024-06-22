namespace kpazminoExamen.Views;

public partial class Registro : ContentPage
{
    private string usuario;
    private const double ValorBase = 1500;

    public Registro(string usuario)

	{
		InitializeComponent();
        this.usuario = usuario;
        lblnombre.Text = $"Usuario conectado: {usuario}";

    }


   

    //calcular pago mensual
    private void Button_Clicked_1(object sender, EventArgs e)
    {
        if (double.TryParse(txtmontoinicial.Text, out double montoInicial))
        {
            if (montoInicial < 1 || montoInicial > 1500)
            {
                DisplayAlert("Error", "El monto inicial debe estar entre 1 y 1500.", "OK");
                return;
            }

            double montoPendiente = ValorBase - montoInicial;
            double pagoMensual = (montoPendiente / 4) + (ValorBase * 0.04);
            txtpagomensual.Text = pagoMensual.ToString("F2");
        }
        else
        {
            DisplayAlert("Error", "Por favor, ingrese un monto inicial válido.", "OK");
        }
    }

    //resumen
    private void Button_Clicked(object sender, EventArgs e)
    {
        
        if (string.IsNullOrWhiteSpace(txtnombre.Text) ||
            string.IsNullOrWhiteSpace(txtapellido.Text) ||
            !int.TryParse(txtedad.Text, out int edad) ||
            fechaPicker.Date == null ||
            paisPicker.SelectedItem == null ||
            ciudadPicker.SelectedItem == null ||
            !double.TryParse(txtmontoinicial.Text, out double montoInicial) ||
            string.IsNullOrWhiteSpace(txtpagomensual.Text))
        {
            DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
            return;
        }

        double pagoMensual = double.Parse(txtpagomensual.Text);

        Navigation.PushAsync(new Resumen(
            lblnombre.Text,
            txtnombre.Text,
            txtapellido.Text,
            edad,
            fechaPicker.Date,
            paisPicker.SelectedItem.ToString(),
            ciudadPicker.SelectedItem.ToString(),
            montoInicial,
            pagoMensual));
    }

}
