namespace ProyectoP6App.Views;

public partial class SistemaDeCitas : ContentPage
{
	public SistemaDeCitas()
	{
		InitializeComponent();
	}

    private async void BtnSalir_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OptionPage());
    }
}