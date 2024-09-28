namespace de.mydevtime.Interfaces.Data;

public interface IData : IDataExtension
{
    public HashSet<IDataExtension> Extensions { get; }
    
    public IDataExtension this[string key] { get; }
}