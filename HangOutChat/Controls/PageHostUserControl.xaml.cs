using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HangOutChat.Word
{
    /// <summary>
    /// Interaction logic for PageHostUserControl.xaml
    /// </summary>
    public partial class PageHostUserControl : UserControl
    {
        #region Dependency properies

        /// <summary>
        /// The current page to show in page host
        /// </summary>
        public BasePage CurrentPage
        {
            get => (BasePage)GetValue(CurrentPageProperty);
            set => SetValue(CurrentPageProperty, value);
        }

        /// <summary>
        /// Registers <see cref="CurrentPage"/> as a depedency Property
        /// </summary>
        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register(nameof(CurrentPage), typeof(BasePage), typeof(PageHostUserControl),
                new UIPropertyMetadata(CurrentPagePropertyChanged));

        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public PageHostUserControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Property Changed Event
        /// <summary>
        /// Property change when the page has changed
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void CurrentPagePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // get the frames
            var newPageFrame = (d as PageHostUserControl).NewPage;
            var oldPageFrame = (d as PageHostUserControl).OldPage;

            // store the current page
            var oldPageContent = newPageFrame.Content;
            // remove the current page
            newPageFrame.Content = null;
            // move the previous page into the old page frame
            oldPageFrame.Content = oldPageContent;

            // animate out previous page when the loaded event fires
            if (oldPageContent is BasePage oldPage)
            {
                oldPage.ShouldAnimateOut = true;
            }

            // sets the new page content
            newPageFrame.Content = e.NewValue;
        }
        #endregion
    }
}
