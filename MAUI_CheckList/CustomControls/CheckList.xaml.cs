using MAUI_CheckList.Models;
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;

namespace MAUI_CheckList.CustomControls;

public partial class CheckList : ListView
{
	public CheckList()
	{
		InitializeComponent();

        var data =Items;
	}

    public static readonly BindableProperty ItemsProperty = BindableProperty.Create(
    propertyName: nameof(Items),
    returnType: typeof(IEnumerable),
    declaringType: typeof(CheckList),
    defaultBindingMode: BindingMode.TwoWay);

    public IEnumerable Items
    {
        get => (IEnumerable)GetValue(ItemsProperty);
        set => SetValue(ItemsProperty, value);
    }

    public static readonly BindableProperty TextValueProperty = BindableProperty.Create(
   propertyName: nameof(TextValue),
   returnType: typeof(string),
   declaringType: typeof(CheckList),
   defaultBindingMode: BindingMode.TwoWay);

    public string TextValue
    {
        get => (string)GetValue(TextValueProperty);
        set => SetValue(TextValueProperty, value);
    }

    public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create(
  propertyName: nameof(IsChecked),
  returnType: typeof(bool),
  declaringType: typeof(CheckList),
  defaultBindingMode: BindingMode.TwoWay);

    public bool IsChecked
    {
        get => (bool)GetValue(IsCheckedProperty);
        set => SetValue(IsCheckedProperty, value);
    }

}