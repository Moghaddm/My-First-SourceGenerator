namespace Project.Generators.Templates;

public class DefaultTemplateParameters
{
    public DefaultTemplateParameters(string typeName, string typeNamespace, string rootNamespace)
    {
        ClassName = typeName ?? throw new ArgumentNullException();
        Namespace = typeNamespace ?? throw new ArgumentNullException();
        PrefferredNamespace = rootNamespace ?? throw new ArgumentNullException();
    }

    public string ClassName { get; set; }
    public string Namespace { get; set; }
    public string PrefferredNamespace { get; set; }
}
