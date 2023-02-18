using MAUI_CheckList.Models;
using System.Collections.ObjectModel;

namespace MAUI_CheckList;

public partial class CheckListMainPage : ContentPage
{
	Employees _Employees;
	ObservableCollection<Employee> _employees;

    public CheckListMainPage()
	{
		InitializeComponent();
		_Employees = new Employees();
		employees = new ObservableCollection<Employee>();
		foreach (var item in new Employees())
		{
			employees.Add(item);
		}
		this.BindingContext= this;
	}

	public ObservableCollection<Employee> employees
	{
		get { return _employees; }
		set { _employees = value;OnPropertyChanged(nameof(employees)); }
	}

	private void btn_Clicked(object sender, EventArgs e)
	{
		employees.Add(new Employee() {EmpName="Samtish",Age=77});
    }
}