using Microsoft.Extensions.Logging;
using TravelAppMaui.Models;

namespace TravelAppMaui
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("boogaloo.regular.ttf", "Regular");
                });
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<MainPage>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
