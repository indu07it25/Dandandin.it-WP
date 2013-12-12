// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   	ViewModel.tt
// Version:		2.0
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Controls = WPAppStudio.Controls;
using Entities = WPAppStudio.Entities;
using EntitiesBase = WPAppStudio.Entities.Base;
using IServices = WPAppStudio.Services.Interfaces;
using IViewModels = WPAppStudio.ViewModel.Interfaces;
using Localization = WPAppStudio.Localization;
using Repositories = WPAppStudio.Repositories;
using Services = WPAppStudio.Services;
using ViewModelsBase = WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of Web_News ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class Web_NewsViewModel : ViewModelsBase.VMBase, IViewModels.IWeb_NewsViewModel
    {       

		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ILockScreenService _lockScreenService;
		private readonly Repositories.IWeb_RSS _web_RSS;
		private readonly Repositories.IYouTube_YouTube _youTube_YouTube;
		private readonly Repositories.IFacebook_Facebook _facebook_Facebook;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="Web_NewsViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="lockScreenService">The Lock Screen Service.</param>
        /// <param name="web_RSS">The Web_ R S S.</param>
        /// <param name="youTube_YouTube">The You Tube_ You Tube.</param>
        /// <param name="facebook_Facebook">The Facebook_ Facebook.</param>
        public Web_NewsViewModel(IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ILockScreenService lockScreenService, Repositories.IWeb_RSS web_RSS, Repositories.IYouTube_YouTube youTube_YouTube, Repositories.IFacebook_Facebook facebook_Facebook)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_lockScreenService = lockScreenService;
			_web_RSS = web_RSS;
			_youTube_YouTube = youTube_YouTube;
			_facebook_Facebook = facebook_Facebook;
        }
		
	
		private ObservableCollection<EntitiesBase.RssSearchResult> _web_NewsListControlCollection;

        /// <summary>
        /// Web_NewsListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.RssSearchResult> Web_NewsListControlCollection
        {
            get
            {
				
                if(_web_NewsListControlCollection == null)
					GetWeb_NewsListControlCollectionData();
				return _web_NewsListControlCollection;     
            }
            set
            {
                SetProperty(ref _web_NewsListControlCollection, value);
            }
        }
	
		private EntitiesBase.RssSearchResult _selectedWeb_NewsListControlCollection;

        /// <summary>
        /// SelectedWeb_NewsListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult SelectedWeb_NewsListControlCollection
        {
            get
            {
				return _selectedWeb_NewsListControlCollection;
            }
            set
            {
                _selectedWeb_NewsListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IWeb_DetailViewModel>(_selectedWeb_NewsListControlCollection);
            }
        }
	
		private ObservableCollection<EntitiesBase.YouTubeVideo> _youTube_VideosListControlCollection;

        /// <summary>
        /// YouTube_VideosListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.YouTubeVideo> YouTube_VideosListControlCollection
        {
            get
            {
				
                if(_youTube_VideosListControlCollection == null)
					GetYouTube_VideosListControlCollectionData();
				return _youTube_VideosListControlCollection;     
            }
            set
            {
                SetProperty(ref _youTube_VideosListControlCollection, value);
            }
        }
	
		private int _youTube_VideosListControlCollectionPageNumber;

        /// <summary>
        /// YouTube_VideosListControlCollectionPageNumber property.
        /// </summary>		
        public int YouTube_VideosListControlCollectionPageNumber
        {
            get
            {
				return _youTube_VideosListControlCollectionPageNumber;
            }
            set
            {
                SetProperty(ref _youTube_VideosListControlCollectionPageNumber, value);
            }
        }
	
		private EntitiesBase.YouTubeVideo _selectedYouTube_VideosListControlCollection;

        /// <summary>
        /// SelectedYouTube_VideosListControlCollection property.
        /// </summary>		
        public EntitiesBase.YouTubeVideo SelectedYouTube_VideosListControlCollection
        {
            get
            {
				return _selectedYouTube_VideosListControlCollection;
            }
            set
            {
                _selectedYouTube_VideosListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IYouTube_DetailVideosViewModel>(_selectedYouTube_VideosListControlCollection);
            }
        }
	
		private ObservableCollection<EntitiesBase.RssSearchResult> _facebook_NewsListControlCollection;

        /// <summary>
        /// Facebook_NewsListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.RssSearchResult> Facebook_NewsListControlCollection
        {
            get
            {
				
                if(_facebook_NewsListControlCollection == null)
					GetFacebook_NewsListControlCollectionData();
				return _facebook_NewsListControlCollection;     
            }
            set
            {
                SetProperty(ref _facebook_NewsListControlCollection, value);
            }
        }
	
		private EntitiesBase.RssSearchResult _selectedFacebook_NewsListControlCollection;

        /// <summary>
        /// SelectedFacebook_NewsListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult SelectedFacebook_NewsListControlCollection
        {
            get
            {
				return _selectedFacebook_NewsListControlCollection;
            }
            set
            {
                _selectedFacebook_NewsListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IFacebook_DetailViewModel>(_selectedFacebook_NewsListControlCollection);
            }
        }

        /// <summary>
        /// Delegate method for the RefreshWeb_NewsListControlCollectionCommand command.
        /// </summary>
        public async void RefreshWeb_NewsListControlCollectionCommandDelegate() 
        {
			try
			{
				LoadingWeb_NewsListControlCollection = true;
				var items = await  _web_RSS.Refresh();
				Web_NewsListControlCollection = items;
			}
            catch (Exception ex)
            {
				Web_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingWeb_NewsListControlCollection = false;
			}
        }
		
		
        private bool _loadingWeb_NewsListControlCollection;
		
        public bool LoadingWeb_NewsListControlCollection
        {
            get { return _loadingWeb_NewsListControlCollection; }
            set { SetProperty(ref _loadingWeb_NewsListControlCollection, value); }
        }

        private ICommand _refreshWeb_NewsListControlCollectionCommand;

        /// <summary>
        /// Gets the RefreshWeb_NewsListControlCollectionCommand command.
        /// </summary>
        public ICommand RefreshWeb_NewsListControlCollectionCommand
        {
            get { return _refreshWeb_NewsListControlCollectionCommand = _refreshWeb_NewsListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand(RefreshWeb_NewsListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GetWeb_NewsListControlCollectionCommand command.
        /// </summary>
        public  void GetWeb_NewsListControlCollectionCommandDelegate(int pageNumber= 0) 
        {
				GetWeb_NewsListControlCollectionData(pageNumber);
        }
		

        private ICommand _getWeb_NewsListControlCollectionCommand;

        /// <summary>
        /// Gets the GetWeb_NewsListControlCollectionCommand command.
        /// </summary>
        public ICommand GetWeb_NewsListControlCollectionCommand
        {
            get { return _getWeb_NewsListControlCollectionCommand = _getWeb_NewsListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(GetWeb_NewsListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the RefreshYouTube_VideosListControlCollectionCommand command.
        /// </summary>
        public async void RefreshYouTube_VideosListControlCollectionCommandDelegate() 
        {
			try
			{
				LoadingYouTube_VideosListControlCollection = true;
				var items = await  _youTube_YouTube.Refresh();
				YouTube_VideosListControlCollection = items;
				YouTube_VideosListControlCollectionPageNumber = 0;
			}
            catch (Exception ex)
            {
				YouTube_VideosListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.youtubeError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingYouTube_VideosListControlCollection = false;
			}
        }
		
		
        private bool _loadingYouTube_VideosListControlCollection;
		
        public bool LoadingYouTube_VideosListControlCollection
        {
            get { return _loadingYouTube_VideosListControlCollection; }
            set { SetProperty(ref _loadingYouTube_VideosListControlCollection, value); }
        }

        private ICommand _refreshYouTube_VideosListControlCollectionCommand;

        /// <summary>
        /// Gets the RefreshYouTube_VideosListControlCollectionCommand command.
        /// </summary>
        public ICommand RefreshYouTube_VideosListControlCollectionCommand
        {
            get { return _refreshYouTube_VideosListControlCollectionCommand = _refreshYouTube_VideosListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand(RefreshYouTube_VideosListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GetYouTube_VideosListControlCollectionCommand command.
        /// </summary>
        public  void GetYouTube_VideosListControlCollectionCommandDelegate(int pageNumber= 0) 
        {
				GetYouTube_VideosListControlCollectionData(pageNumber);
        }
		

        private ICommand _getYouTube_VideosListControlCollectionCommand;

        /// <summary>
        /// Gets the GetYouTube_VideosListControlCollectionCommand command.
        /// </summary>
        public ICommand GetYouTube_VideosListControlCollectionCommand
        {
            get { return _getYouTube_VideosListControlCollectionCommand = _getYouTube_VideosListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(GetYouTube_VideosListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the RefreshFacebook_NewsListControlCollectionCommand command.
        /// </summary>
        public async void RefreshFacebook_NewsListControlCollectionCommandDelegate() 
        {
			try
			{
				LoadingFacebook_NewsListControlCollection = true;
				var items = await  _facebook_Facebook.Refresh();
				Facebook_NewsListControlCollection = items;
			}
            catch (Exception ex)
            {
				Facebook_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingFacebook_NewsListControlCollection = false;
			}
        }
		
		
        private bool _loadingFacebook_NewsListControlCollection;
		
        public bool LoadingFacebook_NewsListControlCollection
        {
            get { return _loadingFacebook_NewsListControlCollection; }
            set { SetProperty(ref _loadingFacebook_NewsListControlCollection, value); }
        }

        private ICommand _refreshFacebook_NewsListControlCollectionCommand;

        /// <summary>
        /// Gets the RefreshFacebook_NewsListControlCollectionCommand command.
        /// </summary>
        public ICommand RefreshFacebook_NewsListControlCollectionCommand
        {
            get { return _refreshFacebook_NewsListControlCollectionCommand = _refreshFacebook_NewsListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand(RefreshFacebook_NewsListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GetFacebook_NewsListControlCollectionCommand command.
        /// </summary>
        public  void GetFacebook_NewsListControlCollectionCommandDelegate(int pageNumber= 0) 
        {
				GetFacebook_NewsListControlCollectionData(pageNumber);
        }
		

        private ICommand _getFacebook_NewsListControlCollectionCommand;

        /// <summary>
        /// Gets the GetFacebook_NewsListControlCollectionCommand command.
        /// </summary>
        public ICommand GetFacebook_NewsListControlCollectionCommand
        {
            get { return _getFacebook_NewsListControlCollectionCommand = _getFacebook_NewsListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(GetFacebook_NewsListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the SetLockScreenCommand command.
        /// </summary>
        public  void SetLockScreenCommandDelegate() 
        {
				_lockScreenService.SetLockScreen("DoWapp-Splashscreen-WXGA-black.png");
        }
		

        private ICommand _setLockScreenCommand;

        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
        public ICommand SetLockScreenCommand
        {
            get { return _setLockScreenCommand = _setLockScreenCommand ?? new ViewModelsBase.DelegateCommand(SetLockScreenCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the AboutCommand command.
        /// </summary>
        public  void AboutCommandDelegate() 
        {
				_navigationService.NavigateTo<IViewModels.IAboutViewModel>();
        }
		

        private ICommand _aboutCommand;

        /// <summary>
        /// Gets the AboutCommand command.
        /// </summary>
        public ICommand AboutCommand
        {
            get { return _aboutCommand = _aboutCommand ?? new ViewModelsBase.DelegateCommand(AboutCommandDelegate); }
        }

        private async void GetWeb_NewsListControlCollectionData(int pageNumber = 0)
        {
	
			try
			{
				LoadingWeb_NewsListControlCollection = true;
			
				var items = await _web_RSS.GetData();
                Web_NewsListControlCollection = items;
			}
            catch (Exception ex)
            {
				Web_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingWeb_NewsListControlCollection = false;
			}
		}

        private async void GetYouTube_VideosListControlCollectionData(int pageNumber = 0)
        {
	
			try
			{
				LoadingYouTube_VideosListControlCollection = true;
				YouTube_VideosListControlCollectionPageNumber = pageNumber;

                if (pageNumber == 0)
				{
					var items = await _youTube_YouTube.GetData(pageNumber);
                    YouTube_VideosListControlCollection = items;
				}
                else   
				{
					var items = await _youTube_YouTube.GetData(pageNumber);
                    foreach (var item in items)                    
                        YouTube_VideosListControlCollection.Add(item);
				}
			}
            catch (Exception ex)
            {
				YouTube_VideosListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.youtubeError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingYouTube_VideosListControlCollection = false;
			}
		}

        private async void GetFacebook_NewsListControlCollectionData(int pageNumber = 0)
        {
	
			try
			{
				LoadingFacebook_NewsListControlCollection = true;
			
				var items = await _facebook_Facebook.GetData();
                Facebook_NewsListControlCollection = items;
			}
            catch (Exception ex)
            {
				Facebook_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingFacebook_NewsListControlCollection = false;
			}
		}
    }
}
