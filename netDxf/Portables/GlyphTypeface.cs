using System;
using System.IO;
using System.Globalization;

namespace netDxf.Portables
{
    public class GlyphTypeface
    {
        public enum FontStyle
        {
            Normal,
            Italic,
            Oblique
        }

        public enum FontWeight
        {
            Thin = 100,
            ExtraLight = 200,
            Light = 300,
            Normal = 400,
            Medium = 500,
            SemiBold = 600,
            Bold = 700,
            ExtraBold = 800,
            Black = 900,
            ExtraBlack = 950
        }

        public FontStyle Style { get; internal set; }
        public FontWeight Weight { get; internal set; }
        public System.Collections.Generic.Dictionary<CultureInfo, string> FamilyNames { get; }

        private FontFamily FntFam;
        private string FntFamName;

        public GlyphTypeface(FontFamily FontFamily)
        {
            this.FntFam = FontFamily;
            this.FntFamName = this.FntFam.FamilyName;
            //this.FamilyNames.Add(CultureInfo.GetCultureInfo(1033), this.fFamilyName);
            this.FamilyNames = new System.Collections.Generic.Dictionary<CultureInfo, string>()
            {
                {CultureInfo.GetCultureInfo(1033), this.FntFamName}
            };
        }

        public GlyphTypeface(Uri fontFile)
        {
            if (fontFile != null)
            {
                if (fontFile.IsFile)
                {
                    this.FntFamName = Path.GetFileNameWithoutExtension(fontFile.LocalPath);
                    this.FntFam = new FontFamily(this.FntFamName);
                    //this.FamilyNames.Add(CultureInfo.GetCultureInfo(1033), this.fFamilyName);
                    this.FamilyNames = new System.Collections.Generic.Dictionary<CultureInfo, string>()
                    {
                        {CultureInfo.GetCultureInfo(1033), this.FntFamName}
                    };
                }
            }
        }
    }
}