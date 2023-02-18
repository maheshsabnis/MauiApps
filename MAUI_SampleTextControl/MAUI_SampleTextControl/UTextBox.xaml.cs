namespace MAUI_SampleTextControl;

public partial class UTextBox : Entry
{
	public UTextBox()
	{
		InitializeComponent();
	}


    public static readonly BindableProperty MessageProperty = BindableProperty.Create(
propertyName: nameof(Message),
returnType: typeof(string),
declaringType: typeof(UTextBox),
defaultBindingMode: BindingMode.TwoWay);

    public string Message
    {
        get => (string)GetValue(MessageProperty);
        set => SetValue(MessageProperty, value.ToUpper());
    }
}