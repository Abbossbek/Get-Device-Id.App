namespace Get_Device_Id;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        lblId.Text = Android.Provider.Settings.Secure.GetString(Android.App.Application.Context.ContentResolver, Android.Provider.Settings.Secure.AndroidId);
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Clipboard.SetTextAsync(lblId.Text);
        await DisplayAlert("Info", "Copied to clipboard", "OK");
    }
}

