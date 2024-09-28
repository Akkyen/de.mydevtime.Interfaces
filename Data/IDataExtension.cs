namespace de.mydevtime.Interfaces.Data;

public interface IDataExtension
{
    public String PluginId { get; }
    
    public IDataExtension this[string key] { get; }
}