namespace MAUI_Grid;

public partial class MainPage_NestedGrid : ContentPage
{
	public MainPage_NestedGrid()
	{
		InitializeComponent();
	}
    void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        boxView.Color = new Color((float)redSlider.Value, (float)greenSlider.Value, (float)blueSlider.Value);
    }
}