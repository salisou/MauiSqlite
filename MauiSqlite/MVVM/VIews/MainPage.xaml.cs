using MauiSqlite.MVVM.ViewModels;

namespace MauiSqlite.MVVM.VIews;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageViewmodel();
	}
}