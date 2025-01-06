using MauiHybridMeroOra.mvvm.model;
using MauiHybridMeroOra.mvvm.viewmodel;
using MauiHybridMeroOra.repository;
using Microsoft.Extensions.Logging;

namespace MauiHybridMeroOra
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
            builder.Services.AddSingleton<MeroRepository<MeroOra>>();
            builder.Services.AddSingleton<MeroViewModel>();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
