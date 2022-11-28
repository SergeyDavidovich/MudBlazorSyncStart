using MudBlazor.Utilities;
using MudBlazor;

namespace MudBlazorSyncStart.Shared.Themes
{
    public class Palette
    {
        private MudColor _primaryDarken;

        private MudColor _primaryLighten;

        private MudColor _secondaryDarken;

        private MudColor _secondaryLighten;

        private MudColor _tertiaryDarken;

        private MudColor _tertiaryLighten;

        private MudColor _infoDarken;

        private MudColor _infoLighten;

        private MudColor _successDarken;

        private MudColor _successLighten;

        private MudColor _warningDarken;

        private MudColor _warningLighten;

        private MudColor _errorDarken;

        private MudColor _errorLighten;

        private MudColor _darkDarken;

        private MudColor _darkLighten;

        public virtual MudColor Black { get; set; } = "#272c34";


        public MudColor White { get; set; } = Colors.Shades.White;


        public virtual MudColor Primary { get; set; } = "#594AE2";


        public MudColor PrimaryContrastText { get; set; } = Colors.Shades.White;


        public MudColor Secondary { get; set; } = Colors.Pink.Accent2;


        public MudColor SecondaryContrastText { get; set; } = Colors.Shades.White;


        public MudColor Tertiary { get; set; } = "#1EC8A5";


        public MudColor TertiaryContrastText { get; set; } = Colors.Shades.White;


        public virtual MudColor Info { get; set; } = Colors.Blue.Default;


        public MudColor InfoContrastText { get; set; } = Colors.Shades.White;


        public virtual MudColor Success { get; set; } = Colors.Green.Accent4;


        public MudColor SuccessContrastText { get; set; } = Colors.Shades.White;


        public virtual MudColor Warning { get; set; } = Colors.Orange.Default;


        public MudColor WarningContrastText { get; set; } = Colors.Shades.White;


        public virtual MudColor Error { get; set; } = Colors.Red.Default;


        public MudColor ErrorContrastText { get; set; } = Colors.Shades.White;


        public virtual MudColor Dark { get; set; } = Colors.Grey.Darken3;


        public MudColor DarkContrastText { get; set; } = Colors.Shades.White;


        public virtual MudColor TextPrimary { get; set; } = Colors.Grey.Darken3;


        public virtual MudColor TextSecondary { get; set; } = new MudColor(Colors.Shades.Black).SetAlpha(0.54).ToString(MudColorOutputFormats.RGBA);


        public virtual MudColor TextDisabled { get; set; } = new MudColor(Colors.Shades.Black).SetAlpha(0.38).ToString(MudColorOutputFormats.RGBA);


        public virtual MudColor ActionDefault { get; set; } = new MudColor(Colors.Shades.Black).SetAlpha(0.54).ToString(MudColorOutputFormats.RGBA);


        public virtual MudColor ActionDisabled { get; set; } = new MudColor(Colors.Shades.Black).SetAlpha(0.26).ToString(MudColorOutputFormats.RGBA);


        public virtual MudColor ActionDisabledBackground { get; set; } = new MudColor(Colors.Shades.Black).SetAlpha(0.12).ToString(MudColorOutputFormats.RGBA);


        public virtual MudColor Background { get; set; } = Colors.Shades.White;


        public virtual MudColor BackgroundGrey { get; set; } = Colors.Grey.Lighten4;


        public virtual MudColor Surface { get; set; } = Colors.Shades.White;


        public virtual MudColor DrawerBackground { get; set; } = Colors.Shades.White;


        public virtual MudColor DrawerText { get; set; } = Colors.Grey.Darken3;


        public virtual MudColor DrawerIcon { get; set; } = Colors.Grey.Darken2;


        public virtual MudColor AppbarBackground { get; set; } = "#594AE2";


        public virtual MudColor AppbarText { get; set; } = Colors.Shades.White;


        public virtual MudColor LinesDefault { get; set; } = new MudColor(Colors.Shades.Black).SetAlpha(0.12).ToString(MudColorOutputFormats.RGBA);


        public virtual MudColor LinesInputs { get; set; } = Colors.Grey.Lighten1;


        public virtual MudColor TableLines { get; set; } = new MudColor(Colors.Grey.Lighten2).SetAlpha(1.0).ToString(MudColorOutputFormats.RGBA);


        public virtual MudColor TableStriped { get; set; } = new MudColor(Colors.Shades.Black).SetAlpha(0.02).ToString(MudColorOutputFormats.RGBA);


        public MudColor TableHover { get; set; } = new MudColor(Colors.Shades.Black).SetAlpha(0.04).ToString(MudColorOutputFormats.RGBA);


        public virtual MudColor Divider { get; set; } = Colors.Grey.Lighten2;


        public virtual MudColor DividerLight { get; set; } = new MudColor(Colors.Shades.Black).SetAlpha(0.8).ToString(MudColorOutputFormats.RGBA);


        public string PrimaryDarken
        {
            get
            {
                return (_primaryDarken ?? (_primaryDarken = Primary.ColorRgbDarken())).ToString(MudColorOutputFormats.RGB);
            }
            set
            {
                _primaryDarken = value;
            }
        }

        public string PrimaryLighten
        {
            get
            {
                return (_primaryLighten ?? (_primaryLighten = Primary.ColorRgbLighten())).ToString(MudColorOutputFormats.RGB);
            }
            set
            {
                _primaryLighten = value;
            }
        }

        public string SecondaryDarken
        {
            get
            {
                return (_secondaryDarken ?? (_secondaryDarken = Secondary.ColorRgbDarken())).ToString(MudColorOutputFormats.RGB);
            }
            set
            {
                _secondaryDarken = value;
            }
        }

        public string SecondaryLighten
        {
            get
            {
                return (_secondaryLighten ?? (_secondaryLighten = Secondary.ColorRgbLighten())).ToString(MudColorOutputFormats.RGB);
            }
            set
            {
                _secondaryLighten = value;
            }
        }

        public string TertiaryDarken
        {
            get
            {
                return (_tertiaryDarken ?? (_tertiaryDarken = Tertiary.ColorRgbDarken())).ToString(MudColorOutputFormats.RGB);
            }
            set
            {
                _tertiaryDarken = value;
            }
        }

        public string TertiaryLighten
        {
            get
            {
                return (_tertiaryLighten ?? (_tertiaryLighten = Tertiary.ColorRgbLighten())).ToString(MudColorOutputFormats.RGB);
            }
            set
            {
                _tertiaryLighten = value;
            }
        }

        public string InfoDarken
        {
            get
            {
                return (_infoDarken ?? (_infoDarken = Info.ColorRgbDarken())).ToString(MudColorOutputFormats.RGB);
            }
            set
            {
                _infoDarken = value;
            }
        }

        public string InfoLighten
        {
            get
            {
                return (_infoLighten ?? (_infoLighten = Info.ColorRgbLighten())).ToString(MudColorOutputFormats.RGB);
            }
            set
            {
                _infoLighten = value;
            }
        }

        public string SuccessDarken
        {
            get
            {
                return (_successDarken ?? (_successDarken = Success.ColorRgbDarken())).ToString(MudColorOutputFormats.RGB);
            }
            set
            {
                _successDarken = value;
            }
        }

        public string SuccessLighten
        {
            get
            {
                return (_successLighten ?? (_successLighten = Success.ColorRgbLighten())).ToString(MudColorOutputFormats.RGB);
            }
            set
            {
                _successLighten = value;
            }
        }

        public string WarningDarken
        {
            get
            {
                return (_warningDarken ?? (_warningDarken = Warning.ColorRgbDarken())).ToString(MudColorOutputFormats.RGB);
            }
            set
            {
                _warningDarken = value;
            }
        }

        public string WarningLighten
        {
            get
            {
                return (_warningLighten ?? (_warningLighten = Warning.ColorRgbLighten())).ToString(MudColorOutputFormats.RGB);
            }
            set
            {
                _warningLighten = value;
            }
        }

        public string ErrorDarken
        {
            get
            {
                return (_errorDarken ?? (_errorDarken = Error.ColorRgbDarken())).ToString(MudColorOutputFormats.RGB);
            }
            set
            {
                _errorDarken = value;
            }
        }

        public string ErrorLighten
        {
            get
            {
                return (_errorLighten ?? (_errorLighten = Error.ColorRgbLighten())).ToString(MudColorOutputFormats.RGB);
            }
            set
            {
                _errorLighten = value;
            }
        }

        public string DarkDarken
        {
            get
            {
                return (_darkDarken ?? (_darkDarken = Dark.ColorRgbDarken())).ToString(MudColorOutputFormats.RGB);
            }
            set
            {
                _darkDarken = value;
            }
        }

        public string DarkLighten
        {
            get
            {
                return (_darkLighten ?? (_darkLighten = Dark.ColorRgbLighten())).ToString(MudColorOutputFormats.RGB);
            }
            set
            {
                _darkLighten = value;
            }
        }

        public double HoverOpacity { get; set; } = 0.06;


        public string GrayDefault { get; set; } = Colors.Grey.Default;


        public string GrayLight { get; set; } = Colors.Grey.Lighten1;


        public string GrayLighter { get; set; } = Colors.Grey.Lighten2;


        public string GrayDark { get; set; } = Colors.Grey.Darken1;


        public string GrayDarker { get; set; } = Colors.Grey.Darken2;


        public string OverlayDark { get; set; } = new MudColor("#212121").SetAlpha(0.5).ToString(MudColorOutputFormats.RGBA);


        public string OverlayLight { get; set; } = new MudColor(Colors.Shades.White).SetAlpha(0.5).ToString(MudColorOutputFormats.RGBA);

    }

}
