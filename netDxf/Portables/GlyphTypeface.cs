using System;
using System.IO;
using System.Globalization;

namespace netDxf.Portables
{
    /// <summary>
    /// A dummy class to replace the unsupported <c>GlyphTypeface</c> class.
    /// </summary>
    public class GlyphTypeface
    {
        /// <summary>
        /// Enumerate the available styles of a font.
        /// </summary>
        public enum FontStyle
        {
            /// <summary>
            /// Standard style of a font.
            /// </summary>
            Normal,

            /// <summary>
            /// Right inclination style.
            /// </summary>
            Italic,

            /// <summary>
            /// Left inclination style.
            /// </summary>
            Oblique
        }

        /// <summary>
        /// Enumerate the available weights of a font.
        /// </summary>
        public enum FontWeight
        {
            /// <summary>
            /// Thin
            /// </summary>
            Thin = 100,

            /// <summary>
            /// ExtraLight
            /// </summary>
            ExtraLight = 200,

            /// <summary>
            /// Light
            /// </summary>
            Light = 300,

            /// <summary>
            /// Normal
            /// </summary>
            Normal = 400,

            /// <summary>
            /// Medium
            /// </summary>
            Medium = 500,

            /// <summary>
            /// SemiBold
            /// </summary>
            SemiBold = 600,

            /// <summary>
            /// Bold
            /// </summary>
            Bold = 700,

            /// <summary>
            /// ExtraBold
            /// </summary>
            ExtraBold = 800,

            /// <summary>
            /// Black
            /// </summary>
            Black = 900,

            /// <summary>
            /// ExtraBlack
            /// </summary>
            ExtraBlack = 950
        }

        /// <summary>
        /// Get the style of the font.
        /// </summary>
        public FontStyle Style { get; internal set; }

        /// <summary>
        /// Get the weight of the font.
        /// </summary>
        public FontWeight Weight { get; internal set; }

        /// <summary>
        /// Get a collection of the localized names of the font.
        /// </summary>
        public System.Collections.Generic.Dictionary<CultureInfo, string> FamilyNames { get; }

        private readonly FontFamily FntFam;
        private readonly string FntFamName;

        /// <summary>
        /// Initialize a new <c>GlyphTypeface</c> object from the font name.
        /// </summary>
        /// <param name="FontFamily"></param>
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

        /// <summary>
        /// Initialize a new <c>GlyphTypeface</c> object from the font file.
        /// </summary>
        /// <param name="fontFile">An <c>Uri</c> path of the font file.</param>
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