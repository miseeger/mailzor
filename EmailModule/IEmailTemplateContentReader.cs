namespace EmailModule
{
    public interface IEmailTemplateContentReader
    {
        string Read(string templateName, string suffix);
    }
}