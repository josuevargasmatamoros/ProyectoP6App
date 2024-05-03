namespace ProyectoP6App.Views;

public partial class Historiales : ContentPage
{
	public Historiales()
	{
		InitializeComponent();
	}

    private async void BtnSalir_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OptionPage());
    }
}