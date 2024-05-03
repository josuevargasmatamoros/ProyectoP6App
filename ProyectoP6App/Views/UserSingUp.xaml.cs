using ProyectoP6App.ViewModels;
using ProyectoP6App.Models;

namespace ProyectoP6App.Views;

public partial class UserSingUp : ContentPage
{
	//PARA PODER COMUNICARSE CON LA BASE DE DATOS DEBEMOS PASAR LAS OPERACIONES
	//POR MEDIO DEL VIEWMODEL, QUE SE ENCARGA DE INTERMEDIAR DICHAS OPERACIONES

	UsuarioViewModel? vm;


	public UserSingUp()
	{
		InitializeComponent();

		BindingContext = vm = new UsuarioViewModel();

		//Y ahora llamamos a la funcion que se encarga de llenar el picker
		//con los datos de los roles de Usuario

		LoadUserRoles();
	}

	private async void LoadUserRoles() 
	{

        CboxUsuarioRolId.ItemsSource = await vm.GetAllUserRolesAsync();
	
	}

    private async void BtnCancel_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}