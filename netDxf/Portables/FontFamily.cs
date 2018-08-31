namespace netDxf.Portables
{
    /// <summary>
    /// A dummy class to replace the unsupported <c>FontFamily</c> class.
    /// </summary>
    public class FontFamily
    {
        /// <summary>
        /// Get the name of the FontFamily.
        /// </summary>
        public string FamilyName { get; }

        /// <summary>
        /// Initialize a new <c>FontFamily</c> object from the given <c>string</c>
        /// </summary>
        /// <param name="value">Name of the font family.</param>
        public FontFamily(string value)
        {
            this.FamilyName = value;
        }
    }
}