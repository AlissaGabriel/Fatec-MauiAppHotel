using System.Threading.Tasks;

namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			await Navigation.PopAsync();
		}
		catch (Exception ex)
		{
			await DisplayAlertAsync("Ops", ex.Message, "OK"); 
		}
    }

    private async void Button_Clicked_Avancar(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Views.Login());
    }
}