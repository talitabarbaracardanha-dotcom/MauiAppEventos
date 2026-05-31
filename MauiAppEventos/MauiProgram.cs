using Microsoft.Extensions.Logging;

namespace MauiAppEventos
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
                    fonts.AddFont("Kalam-Bold.ttf", "KalamBold");
                    fonts.AddFont("Kalam-Light.ttf", "KalamLight");
                    fonts.AddFont("Kalam-Regular.ttf", "Kalam");
                    fonts.AddFont("Outfit-Bold.ttf", "OutfitBold");
                    fonts.AddFont("Outfit-ExtraBold.ttf", "OutfitExtrabold");
                    fonts.AddFont("Outfit-ExtraLight.ttf", "OutfitExtraLight");
                    fonts.AddFont("Outfit-Light.ttf", "OutfitLight");
                    fonts.AddFont("Outfit-Medium.ttf", "OutfitMedium");
                    fonts.AddFont("Outfit-Regular.ttf", "Outfit");
                    fonts.AddFont("Outfit-SemiBold.ttf", "OutfitSemibold");
                    fonts.AddFont("Outfit-Thin.ttf", "OutfitThin");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
