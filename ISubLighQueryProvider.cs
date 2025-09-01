namespace SubLight
{
    public interface ISubLighQueryProvider
        : IQueryProvider
    {
        // Provider-specific query translation
        string Translate(IQueryTranslator translator);
    }
}
