namespace MauiAppHotel.Views;

public partial class SobreHotelHospedagem : ContentPage
{
	public SobreHotelHospedagem()
	{
		InitializeComponent();

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("Erro", ex.Message, "OK");
        }
    }
}