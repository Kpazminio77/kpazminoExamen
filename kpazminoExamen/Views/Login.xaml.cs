namespace kpazminoExamen.Views;

public partial class Login : ContentPage
{
    private readonly string[,] usuarios = new string[,]
        {
            { "estudiante", "moviles" },
            { "uisrael", "2024" }
        };
    public Login()
	{
		InitializeComponent();
	}

    private void btninicio_Clicked(object sender, EventArgs e)
    {
        string username = txtusuario.Text;
        string password = txtcontrasena.Text;
        bool isAuthenticated = ValidateCredentials(username, password);

        if (isAuthenticated)
        {
            Navigation.PushAsync(new Registro(username));
        }
        else
        {
            DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }

    private bool ValidateCredentials(string username, string password)
    {
        for (int i = 0; i < usuarios.GetLength(0); i++)
        {
            if (usuarios[i, 0] == username && usuarios[i, 1] == password)
            {
                return true;
            }
        }
        return false;
    }
}