namespace Danya
{
    interface Filter
    {
        public bool Filter(string text);
    }

    class FilterOnWordBlyadb : Filter
    {
        public bool Filter(string text)
        {
            return text.Contains("Blaydb");
        }
    }

    class FilterOnWordPrivetb : Filter
    {
        public bool Filter(string text)
        {
            return text.Contains("Privetb");
        }
    }

    class FilterOnWordPoka : Filter
    {
        public bool Filter(string text)
        {
            return text.Contains("Poka");
        }
    }
}
