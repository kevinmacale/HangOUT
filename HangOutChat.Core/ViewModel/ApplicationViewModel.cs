using HangOutChat.Word.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangOutChat.Core
{
    /// <summary>
    /// The applciation state of viewmodel
    /// </summary>
    public class ApplicationViewModel : BaseViewModel
    {
        #region Private member
        /// <summary>
        /// application pages
        /// </summary>
        private ApplicationPageEnum _currentPage = ApplicationPageEnum.Login;
        /// <summary>
        /// True if the slide menu should be shown
        /// </summary>
        private bool _slideMenuVisible = false;
        #endregion

        #region Public properties
        /// <summary>
        /// the log in page
        /// </summary>
        public ApplicationPageEnum CurrentPage
        {
            get { return _currentPage; }
            private set
            {
                _currentPage = value;
                OnPropertyChanged("CurrentPage");
            }
        }

        /// <summary>
        /// True if the slide menu should be shown
        /// </summary>
        public bool SlideMenuVisible
        {
            get { return _slideMenuVisible; }
            set { _slideMenuVisible = value; OnPropertyChanged("SlideMenuVisible"); }
        }

        /// <summary>
        /// Navigate to specified page
        /// </summary>
        /// <param name="chat"></param>
        public void GoToPage(ApplicationPageEnum pageEnum)
        {
            CurrentPage = pageEnum;

            if (pageEnum == ApplicationPageEnum.Chat)
            {
                SlideMenuVisible = true;
            }
        }
        #endregion

    }
}
