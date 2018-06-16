namespace Denga.Pipeworks.HttpCommunication
{
    public interface IViewsEngineSettings
    {
        bool AutoFindModelFactories { get; set; }
    }

    public class BaseViewsEngineSettings: IViewsEngineSettings
    {
        public bool AutoFindModelFactories { get; set; }
    }
}