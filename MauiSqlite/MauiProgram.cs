using MauiSqlite.Data.Repositories;
using MauiSqlite.MVVM.Models;
using Microsoft.Extensions.Logging;

namespace MauiSqlite;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//builder.Services.AddSingleton<CustomerRepository>();
		builder.Services.AddSingleton<BaseRepository<Customer>>();
		builder.Services.AddSingleton<BaseRepository<Order>>();
		builder.Services.AddSingleton<BaseRepository<Passport>>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
