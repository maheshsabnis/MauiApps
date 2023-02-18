namespace MAUI_SampleTextControl;

public partial class MainPage : ContentPage
{
	string name = string.Empty;
	public MainPage()
	{
		InitializeComponent();
		 
		this.BindingContext= this;
	}

	public string Name
	{ 
		get { return name; } 
		set 
		{
			name = value; 
			OnPropertyChanged("Name");
		}
	}



 }

