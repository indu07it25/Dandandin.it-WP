// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   	IDataSource.tt
// Version:		2.0
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Entities = WPAppStudio.Entities;
using EntitiesBase = WPAppStudio.Entities.Base;
using WPAppStudio.Shared;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// Forum_Forum interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IForum_Forum
    {
        Task<ObservableCollection<EntitiesBase.RssSearchResult>> GetData();
        Task<ObservableCollection<EntitiesBase.RssSearchResult>> Refresh();
		Task<ObservableCollection<EntitiesBase.RssSearchResult>> Search(FilterSpecification filter);
		Task<EntitiesBase.RssSearchResult> Previous(EntitiesBase.RssSearchResult current);
		Task<EntitiesBase.RssSearchResult> Next(EntitiesBase.RssSearchResult current);
    }
}