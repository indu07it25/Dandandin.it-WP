// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   	ServiceLocator.tt
// Version:		2.0
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using IIoc = WPAppStudio.Ioc.Interfaces;
using Ioc = WPAppStudio.Ioc;
using IViewModels = WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.Services
{
    /// <summary>
    /// Implementation of the ViewModel locator service based on IoC.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public class ViewModelLocatorService
    {
        // IoC container
        private readonly IIoc.IContainer _container;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelLocatorService" /> class.
        /// </summary>
        public ViewModelLocatorService()
        {
            _container = new Ioc.Container();
        }
		
		/// <summary>
        /// Resolve a service of type T
        /// </summary>
        /// <typeparam name="T">Type of the service.</typeparam>
        /// <returns></returns>
        public T ResolveService<T>()
        {
            return _container.Resolve<T>();
        }

        /// <summary>
        /// Gets the reference to a Web_NewsViewModel.
        /// </summary>
		public IViewModels.IWeb_NewsViewModel Web_NewsViewModel
        {
            get { return _container.Resolve<IViewModels.IWeb_NewsViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a Facebook_DetailViewModel.
        /// </summary>
		public IViewModels.IFacebook_DetailViewModel Facebook_DetailViewModel
        {
            get { return _container.Resolve<IViewModels.IFacebook_DetailViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a YouTube_DetailVideosViewModel.
        /// </summary>
		public IViewModels.IYouTube_DetailVideosViewModel YouTube_DetailVideosViewModel
        {
            get { return _container.Resolve<IViewModels.IYouTube_DetailVideosViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a Web_DetailViewModel.
        /// </summary>
		public IViewModels.IWeb_DetailViewModel Web_DetailViewModel
        {
            get { return _container.Resolve<IViewModels.IWeb_DetailViewModel>(); }
        }
		/// <summary>
        /// Gets the reference to a AboutViewModel.
        /// </summary>
		public IViewModels.IAboutViewModel AboutViewModel
        {
            get { return _container.Resolve<IViewModels.IAboutViewModel>(); }
        }
		
		/// <summary>
        /// Gets the reference to a LicenseViewModel.
        /// </summary>
		public IViewModels.ILicenseViewModel LicenseViewModel
        {
            get { return _container.Resolve<IViewModels.ILicenseViewModel>(); }
        }
    }
}
