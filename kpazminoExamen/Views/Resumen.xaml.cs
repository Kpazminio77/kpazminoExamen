using static System.Runtime.InteropServices.JavaScript.JSType;

namespace kpazminoExamen.Views;

public partial class Resumen : ContentPage
{
	public Resumen(string usuario, string nombre, string apellido, int edad, DateTime fecha, string pais, string ciudad, double montoInicial, double pagoMensual)
	{
		InitializeComponent();
        lblnombre.Text = $"Usuario conectado: {usuario}";
        lblnombre1.Text = nombre;
        lblapellido.Text = apellido;
        lbledad.Text = edad.ToString();
        lblfecha.Text = fecha.ToShortDateString();
        lblciudad.Text = ciudad;
        lblpais.Text = pais;
        lblmontoinicial.Text = montoInicial.ToString("F2");
        lblpagomensual.Text = pagoMensual.ToString("F2");
        lblpagototal.Text = (montoInicial + pagoMensual * 4).ToString("F2");
    }
}