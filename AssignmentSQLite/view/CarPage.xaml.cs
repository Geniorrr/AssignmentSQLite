using AssignmentSQLite.MVVM.ViewModels;

namespace AssignmentSQLite.view;

public partial class CarPage : ContentPage
{
	public CarPage()
	{
		InitializeComponent();
        this.BindingContext = new CarPageViewModel();
    }
}