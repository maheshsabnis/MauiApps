﻿using App_MVVM.ViewModel;
namespace App_MVVM;

public partial class MainPage : ContentPage
{
	
	// The Comment
	public MainPage(EmployeeViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	 
}


