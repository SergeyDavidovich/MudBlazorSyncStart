﻿using MudBlazor;

namespace MudBlazorSyncStart.Shared
{
    public interface IThemeProvider
    {
        MudTheme FirstTheme { get; }
    }

    public class ThemeProvider : IThemeProvider
    {
        private MudTheme? theme;

        public MudTheme FirstTheme
        {
            get
            {
                return theme = new MudTheme()
                {
                    Palette = new Palette()
                    {
                        Primary = Colors.Blue.Default,
                        Secondary = Colors.Green.Accent4,
                        AppbarBackground = Colors.BlueGrey.Lighten1,
                        AppbarText = Colors.Shades.White,
                        DrawerBackground = Colors.BlueGrey.Darken1,
                        DrawerText = Colors.Shades.White
                    },
                    PaletteDark = new PaletteDark()
                    {
                        Primary = Colors.Blue.Lighten1,
                        DrawerText = Colors.Grey.Default,
                        AppbarText = Colors.Grey.Default
                    },
                    LayoutProperties = new LayoutProperties()
                    {
                        DrawerWidthLeft = "260px",
                        DrawerWidthRight = "300px"
                    },
                    Shadows = new Shadow() { },
                    Typography = new Typography() { },
                    ZIndex = new ZIndex() { }
                };
            }
        }
    }
}
