namespace ClinixQueue
{
    public class Patient
    {
        public int TokenNumber { get; set; }
        public string Name { get; set; } = string.Empty;

        public string FormattedToken => $"# {TokenNumber:D3}";
        public string DisplayTokenNumber => TokenNumber.ToString("D2");
    }
}