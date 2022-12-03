namespace MAUI_CC.Controls;

public partial class CardControl : ContentView
{
    // USed only when the ControlTemplate and Freme is not added
    //public static readonly BindableProperty TitleProperty 
    //	 = BindableProperty.Create(nameof(Title), typeof(string), typeof(CardControl), propertyChanged: (bindable,  oldvalue, newValue) => 
    //	 {
    //		 // this is declared t access the property from the otrol for databinding
    //	    var control = (CardControl)bindable;
    //		 control.TitleLabel.Text = newValue as string;
    //	 });

    public static readonly BindableProperty TitleProperty
     = BindableProperty.Create(nameof(Title), typeof(string), typeof(CardControl));

    public CardControl()
	{
		InitializeComponent();
	}

	public string Title
	{
		get => GetValue(TitleProperty) as string;	
		set => SetValue(TitleProperty, value);
	}
}