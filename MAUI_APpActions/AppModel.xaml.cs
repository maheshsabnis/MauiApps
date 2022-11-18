namespace MAUI_APpActions;

public partial class AppModel : ContentPage
{
	public AppModel(string appTitle)
	{
		InitializeComponent();
        lbl.Text = $"Hay!! You have requeted to open the {appTitle} app action!";
    }
}