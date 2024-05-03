namespace ProyectoP6App.Views;

public partial class Citas : ContentPage
{
	public Citas()
	{
		InitializeComponent();
	}

    private async void BtnSalir_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OptionPage());
    }
}