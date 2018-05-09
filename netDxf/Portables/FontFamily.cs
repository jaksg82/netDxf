namespace netDxf.Portables
{
    public class FontFamily
    {
        public string FamilyName { get; internal set; }
        private string fFamily;

        public FontFamily(string value)
        {
            this.fFamily = value;
            this.FamilyName = value;
        }
    }
}