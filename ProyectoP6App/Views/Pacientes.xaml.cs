namespace ProyectoP6App.Views;

public partial class Pacientes : ContentPage
{
	public Pacientes()
	{
		InitializeComponent();
	}

    private async void BtnSalir_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OptionPage());
    }
}