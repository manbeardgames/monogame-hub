using MonoGame.Wpf.Events;
using Prism.Commands;
using Prism.Events;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGame.Wpf.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IEventAggregator _eventAggregator;
        private System.Timers.Timer _statusTimer;

        /// <summary>
        ///     Gets or Sets the status message
        /// </summary>
        public string StatusMessage
        {
            get { return _statusMessage; }
            set { SetProperty(ref _statusMessage, value); }
        }
        private string _statusMessage;


        /// <summary>
        ///     Gets or Sets if the status flyout is open
        /// </summary>
        public bool IsStatusOpen
        {
            get { return _isStatusOpen; }
            set { SetProperty(ref _isStatusOpen, value); }
        }
        private bool _isStatusOpen;

        public DelegateCommand<string> NavigateCommand { get; set; }


        public ShellViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<PushStatusMessageEvent>().Subscribe(ShowStatusMessage);
            _regionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string uri)
        {
            _regionManager.RequestNavigate("ContentRegion", uri);
        }

        private void ShowStatusMessage(string message)
        {
            StatusMessage = message;
            IsStatusOpen = true;
            _statusTimer.Start();
        }
    }
}
