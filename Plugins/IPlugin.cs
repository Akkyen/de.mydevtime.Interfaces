namespace de.mydevtime.Interfaces.Plugins;

public interface IPlugin
{
    public void Initialize();
    
    public void Run(params string[] args);
    
    public void Shutdown();
    
    public void Terminate();
}