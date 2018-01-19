using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media.Animation;
using HangOutChat.Word;
using HangOutChat.Word.Core;

namespace HangOutChat.Word
{
    /// <summary>
    ///  A base page for all to gain funcitionality
    /// </summary>
    public class BasePage : Page
    {
        #region Public properties
        /// <summary>
        /// The animation the play when the page is first loaded
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeFromRight;
        /// <summary>
        /// The animation the play when the page is first unloaded
        /// </summary>
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeToLeft;

        /// <summary>
        /// the time any slide animation completes
        /// </summary>
        public float SlideSeconds { get; set; } = 0.5f;

        /// <summary>
        /// A flag if the page should be animate out
        /// </summary>
        public bool ShouldAnimateOut { get; set; }
        #endregion

        #region Constructor
        public BasePage()
        {
            if (PageLoadAnimation != PageAnimation.None)
            {
                Visibility = Visibility.Collapsed;
            }
            Loaded += BasePage_LoadedAysnc;
        }
        #endregion

        #region Animation load/unload
        /// <summary>
        /// Once the page is loaded perform any animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasePage_LoadedAysnc(object sender, System.Windows.RoutedEventArgs e)
        {
            if (ShouldAnimateOut)
                await AnimateOutAsync();
            else
                await AnimateInAsync();
        }

        /// <summary>
        /// Animates this page
        /// </summary>
        /// <returns></returns>
        public async Task AnimateInAsync()
        {
            switch (PageLoadAnimation)
            {
                case PageAnimation.None:
                    return;
                case PageAnimation.SlideAndFadeFromRight:
                    {
                        // start the animation
                        await this.SlideAndFadeInFromRightAsync(SlideSeconds);
                        break;
                    }
                case PageAnimation.SlideAndFadeToLeft:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// animates pages to left
        /// </summary>
        /// <returns></returns>
        public async Task AnimateOutAsync()
        {
            switch (PageUnloadAnimation)
            {
                case PageAnimation.None:
                    return;
                case PageAnimation.SlideAndFadeFromRight:
                    break;
                case PageAnimation.SlideAndFadeToLeft:
                    {
                        // start the animation
                        await this.SlideAndFadeOutToLeftAsync(SlideSeconds);
                        break;
                    }
                default:
                    break;
            }
        }
        #endregion

    }

    /// <summary>
    /// A base page with added viewmodel support
    /// </summary>
    public class BasePage<VM> : BasePage
        where VM : BaseViewModel, new ()
    {
        #region Private member
        /// <summary>
        /// The viewmodel associated with this page
        /// </summary>
        private VM _viewmodel;
        #endregion

        #region Public Properties
        /// <summary>
        /// The viewmodel associated with this page
        /// </summary>
        public VM ViewModel
        {
            get => _viewmodel;
            set
            {
                if (_viewmodel == (value))
                {
                    return;
                }

                _viewmodel = value;
                DataContext = _viewmodel;
            }
        }
        #endregion

        #region Constructor
        public BasePage() : base()
        {
            // create a default viewmodel
            ViewModel = new VM();
        } 
        #endregion
    }
}
