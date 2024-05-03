namespace ProyectoP6App.Views;

public partial class OptionPage : ContentPage
{
	public OptionPage()
	{
		InitializeComponent();
	}

    private async void BtnCitas(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Citas());
    }

    private async void BtnDoctores(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Doctores());
    }

    private async void BtnHistoriales(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Historiales());
    }

    private async void BtnPacientes(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pacientes());
    }

    private async void BtnSalir(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

    private async void BtnSistemaDeCitas(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SistemaDeCitas());
    }
}