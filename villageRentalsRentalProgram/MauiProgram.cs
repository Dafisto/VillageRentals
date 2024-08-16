using Microsoft.Extensions.Logging;
using villageRentalsRentalProgram.Persistence;

namespace villageRentalsRentalProgram
{
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
            var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../..", "resources", "data", "alexandriaDB.db");
            builder.Services.AddSingleton<ClientManager>(s => ActivatorUtilities.CreateInstance<ClientManager>(s, dbPath));
            builder.Services.AddSingleton<ClientManager>(s => ActivatorUtilities.CreateInstance<ClientManager>(s, dbPath));
            builder.Services.AddSingleton<ClientManager>(s => ActivatorUtilities.CreateInstance<ClientManager>(s, dbPath));
            
            return builder.Build();
        }
    }
}
