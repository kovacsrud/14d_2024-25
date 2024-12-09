using MauiBlazorViewModel.mvvm.viewmodel;
using Microsoft.Extensions.Logging;

namespace MauiBlazorViewModel
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
            builder.Services.AddSingleton<MintaVM2>();
            builder.Services.AddScoped(sp=>new HttpClient());
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
