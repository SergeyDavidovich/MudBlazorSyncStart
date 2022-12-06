using Blazor.IndexedDB.WebAssembly;
using Microsoft.JSInterop;


namespace MudBlazorSyncStart.IndexedDbStorage.Data
{
    public class IndexedDBStorage : IndexedDb
    {
        public IndexedDBStorage(IJSRuntime jSRuntime, string name, int version) : base(jSRuntime, name, version)
        {
        }
    }
}