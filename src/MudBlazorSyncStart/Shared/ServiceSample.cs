namespace MudBlazorSyncStart.Shared
{
    public interface IServiceSample
    {
        public string Value { get; }
    }
    public class ServiceSample:IServiceSample
    {
        public string Value
        {
            get
            {
                return "!!!!!!!!!!!!AAAAAAAAAAA";
            }
        }
    }
}
