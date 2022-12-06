using MudBlazor;

namespace MudBlazorSyncStart.AppThemes
{
    public interface IThemeProvider
    {
        MudTheme ThemeA { get; }
        MudTheme ThemeB { get; }

    }

    public class ThemeProvider : IThemeProvider
    {
        public MudTheme ThemeA
        {
            get
            {
                var theme = new MudTheme()
                {
                    Palette = new Palette()
                    {
                        Primary = Colors.Blue.Default,
                        PrimaryLighten= Colors.Blue.Lighten2,
                        PrimaryDarken= Colors.Blue.Darken2,
                        
                        Secondary = Colors.Green.Accent4,
                        AppbarBackground = Colors.Purple.Accent4,
                        AppbarText = Colors.Shades.White,
                        DrawerBackground = Colors.DeepPurple.Lighten1,
                        DrawerText = Colors.Shades.White,
                        BackgroundGrey= Colors.Green.Accent4,
                    },
                    PaletteDark = new PaletteDark()
                    {
                        Primary = Colors.Blue.Lighten1,
                        DrawerText = Colors.Grey.Default,
                        AppbarText = Colors.Grey.Default,
                    },
                    LayoutProperties = new LayoutProperties()
                    {
                        DrawerWidthLeft = "260px",
                        DrawerWidthRight = "300px"
                    },
                    //Shadows = new Shadow() {},
                    //Typography = new Typography() {},
                    //ZIndex = new ZIndex() { }
                };
                return theme;
            }
        }
        public MudTheme ThemeB
        {
            get
            {
                var theme = new MudTheme()
                {
                    Palette = new Palette()
                    {
                        Primary = Colors.Blue.Default,
                        Secondary = Colors.Green.Accent4,
                        AppbarBackground = Colors.Purple.Accent4,
                        AppbarText = Colors.Shades.White,
                        DrawerBackground = Colors.DeepPurple.Lighten1,
                        DrawerText = Colors.Shades.White,
                        InfoContrastText = Colors.Red.Default,
                    },
                    PaletteDark = new PaletteDark()
                    {
                        Primary = Colors.Blue.Lighten1,
                        DrawerText = Colors.Grey.Default,
                        AppbarText = Colors.Grey.Default,
                        DarkContrastText=Colors.Blue.Lighten3,
                    },
                    LayoutProperties = new LayoutProperties()
                    {
                        DrawerWidthLeft = "260px",
                        DrawerWidthRight = "300px"
                    },
                    //Shadows = new Shadow() {},
                    //Typography = new Typography() {},
                    //ZIndex = new ZIndex() { }
                };
                return theme;
            }
        }

    }
}
