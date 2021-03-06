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
    /// Implementation of Facebook_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class Facebook_DetailViewModel : ViewModelsBase.VMBase, IViewModels.IFacebook_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly Repositories.Facebook_Facebook _facebook_Facebook;
		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="Facebook_DetailViewModel" /> class.
        /// </summary>
        /// <param name="facebook_Facebook">The Facebook_ Facebook.</param>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public Facebook_DetailViewModel(Repositories.Facebook_Facebook facebook_Facebook, IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_facebook_Facebook = facebook_Facebook;
			_dialogService = dialogService;
			_navigationService = navigationService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		
	
		private EntitiesBase.RssSearchResult _currentRssSearchResult;

        /// <summary>
        /// CurrentRssSearchResult property.
        /// </summary>		
        public EntitiesBase.RssSearchResult CurrentRssSearchResult
        {
            get
            {
				return _currentRssSearchResult;
            }
            set
            {
                SetProperty(ref _currentRssSearchResult, value);
            }
        }
	
		private bool _hasNextpanoramaFacebook_Detail0;

        /// <summary>
        /// HasNextpanoramaFacebook_Detail0 property.
        /// </summary>		
        public bool HasNextpanoramaFacebook_Detail0
        {
            get
            {
				return _hasNextpanoramaFacebook_Detail0;
            }
            set
            {
                SetProperty(ref _hasNextpanoramaFacebook_Detail0, value);
            }
        }
	
		private bool _hasPreviouspanoramaFacebook_Detail0;

        /// <summary>
        /// HasPreviouspanoramaFacebook_Detail0 property.
        /// </summary>		
        public bool HasPreviouspanoramaFacebook_Detail0
        {
            get
            {
				return _hasPreviouspanoramaFacebook_Detail0;
            }
            set
            {
                SetProperty(ref _hasPreviouspanoramaFacebook_Detail0, value);
            }
        }

        /// <summary>
        /// Delegate method for the ShareFacebook_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareFacebook_DetailStaticControlCommandDelegate() 
        {
				_shareService.Share(CurrentRssSearchResult.Title, CurrentRssSearchResult.Content, CurrentRssSearchResult.FeedUrl, CurrentRssSearchResult.ImageUrl);
        }
		

        private ICommand _shareFacebook_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareFacebook_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareFacebook_DetailStaticControlCommand
        {
            get { return _shareFacebook_DetailStaticControlCommand = _shareFacebook_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(ShareFacebook_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartFacebook_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartFacebook_DetailStaticControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.IFacebook_DetailViewModel), CreateTileInfoFacebook_DetailStaticControl());
        }
		

        private ICommand _pinToStartFacebook_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartFacebook_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartFacebook_DetailStaticControlCommand
        {
            get { return _pinToStartFacebook_DetailStaticControlCommand = _pinToStartFacebook_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartFacebook_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GoToSourceFacebook_DetailStaticControlCommand command.
        /// </summary>
        public  void GoToSourceFacebook_DetailStaticControlCommandDelegate() 
        {
				_navigationService.NavigateTo(string.IsNullOrEmpty(CurrentRssSearchResult.FeedUrl) ? null : new Uri(CurrentRssSearchResult.FeedUrl));
        }
		

        private ICommand _goToSourceFacebook_DetailStaticControlCommand;

        /// <summary>
        /// Gets the GoToSourceFacebook_DetailStaticControlCommand command.
        /// </summary>
        public ICommand GoToSourceFacebook_DetailStaticControlCommand
        {
            get { return _goToSourceFacebook_DetailStaticControlCommand = _goToSourceFacebook_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(GoToSourceFacebook_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the NextpanoramaFacebook_Detail0 command.
        /// </summary>
        public async void NextpanoramaFacebook_Detail0Delegate() 
        {
				LoadingCurrentRssSearchResult = true;
			var next = await  _facebook_Facebook.Next(CurrentRssSearchResult);

			if(next != null)
				CurrentRssSearchResult = next;

			RefreshHasPrevNext();
        }
		
		
        private bool _loadingCurrentRssSearchResult;
		
        public bool LoadingCurrentRssSearchResult
        {
            get { return _loadingCurrentRssSearchResult; }
            set { SetProperty(ref _loadingCurrentRssSearchResult, value); }
        }

        private ICommand _nextpanoramaFacebook_Detail0;

        /// <summary>
        /// Gets the NextpanoramaFacebook_Detail0 command.
        /// </summary>
        public ICommand NextpanoramaFacebook_Detail0
        {
            get { return _nextpanoramaFacebook_Detail0 = _nextpanoramaFacebook_Detail0 ?? new ViewModelsBase.DelegateCommand(NextpanoramaFacebook_Detail0Delegate); }
        }

        /// <summary>
        /// Delegate method for the PreviouspanoramaFacebook_Detail0 command.
        /// </summary>
        public async void PreviouspanoramaFacebook_Detail0Delegate() 
        {
				LoadingCurrentRssSearchResult = true;
			var prev = await  _facebook_Facebook.Previous(CurrentRssSearchResult);

			if(prev != null)
				CurrentRssSearchResult = prev;

			RefreshHasPrevNext();
        }
		

        private ICommand _previouspanoramaFacebook_Detail0;

        /// <summary>
        /// Gets the PreviouspanoramaFacebook_Detail0 command.
        /// </summary>
        public ICommand PreviouspanoramaFacebook_Detail0
        {
            get { return _previouspanoramaFacebook_Detail0 = _previouspanoramaFacebook_Detail0 ?? new ViewModelsBase.DelegateCommand(PreviouspanoramaFacebook_Detail0Delegate); }
        }

        private async void RefreshHasPrevNext()
        {
            HasPreviouspanoramaFacebook_Detail0 = await _facebook_Facebook.HasPrevious(CurrentRssSearchResult);
			HasNextpanoramaFacebook_Detail0 = await _facebook_Facebook.HasNext(CurrentRssSearchResult);
			LoadingCurrentRssSearchResult = false;
		}
		public object NavigationContext
        {
            set
            {              
                if (!(value is EntitiesBase.RssSearchResult)) { return; }
                
                CurrentRssSearchResult = value as EntitiesBase.RssSearchResult;
                RefreshHasPrevNext();
            }
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the Facebook_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoFacebook_DetailStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentRssSearchResult.Title,
                Title = CurrentRssSearchResult.Title,
                BackTitle = CurrentRssSearchResult.Title,
                BackContent = CurrentRssSearchResult.Content,
                Count = 0,
                BackgroundImagePath = CurrentRssSearchResult.ImageUrl,
                BackBackgroundImagePath = CurrentRssSearchResult.ImageUrl,
                LogoPath = "Logo-e5fdb3ff-dfbe-482b-8e55-b7902363885e.png"
            };
            return tileInfo;
        }
    }
}
