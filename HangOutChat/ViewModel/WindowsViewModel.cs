using HangOutChat.Word.Core;
using System;
using System.Windows;
using System.Windows.Input;

namespace HangOutChat.Word
{
    /// <summary>
    /// This viewmodel for custom windows
    /// </summary>
    public class WindowsViewModel : BaseViewModel
    {
        #region Private Member
        /// <summary>
        /// This window is view model controls
        /// </summary>
        private Window _window;
        /// <summary>
        /// The margin around the window to allow for a drop shadow
        /// </summary>
        private int _outerMarginSize = 0;
        /// <summary>
        /// The radius edges of the windows
        /// </summary>
        private int _windowsRadius = 10;
        ///// <summary>
        ///// application pages
        ///// </summary>
        //private ApplicationPageEnum _currentPage;
        #endregion

        #region Public Properties
        ///// <summary>
        ///// the log in page
        ///// </summary>
        //public ApplicationPageEnum CurrentPage
        //{
        //    get { return _currentPage; }
        //    set
        //    {
        //        _currentPage = value;
        //        OnPropertyChanged("CurrentPage");
        //    }
        //}
        //public ApplicationPageEnum CurrentPage { get; set; } = ApplicationPageEnum.Chat;
        /// <summary>
        /// The minimum width of the windows
        /// </summary>
        public double WindowMinimumWidth { get; set; } = 800;
        /// <summary>
        /// The minimum heigh of the windows
        /// </summary>
        public double WindowMinimumHeight { get; set; } = 500;
        /// <summary>
        /// The size of the resize border around the windows
        /// </summary>
        public int ResizeBorder { get; set; } = 0;
        /// <summary>
        /// Size of the resize border around the windows
        /// </summary>
        public Thickness ResizeBorderThickness => new Thickness(ResizeBorder + OuterMarginSize);
        /// <summary>
        /// Inner content of the main window
        /// </summary>
        public Thickness InnerContentPadding => new Thickness(ResizeBorder);
        /// <summary>
        /// The margin around the window to allow for a drop shadow
        /// </summary>
        public Thickness OuterMarginSizeThickness => new Thickness(OuterMarginSize);

        /// <summary>
        /// The margin around the window to allow for a drop shadow
        /// </summary>
        public int OuterMarginSize
        {
            get => _window.WindowState == WindowState.Maximized ? 0 : _outerMarginSize;
            set => _outerMarginSize = value;
        }

        /// <summary>
        /// The radius edges of the windows
        /// </summary>
        public int WindowRadius
        {
            get => _window.WindowState == WindowState.Maximized ? 0 : _windowsRadius;
            set => _windowsRadius = value;
        }

        /// <summary>
        /// The radius edges of the windows corner radius
        /// </summary>
        public CornerRadius WindowCornerRadius => new CornerRadius(WindowRadius);

        /// <summary>
        /// The height of the title bar
        /// </summary>
        public int TitleHeight { get; set; } = 42;
        /// <summary>
        /// The GridLength of the title bar
        /// </summary>
        public GridLength TitleHeighGridLengtht => new GridLength(TitleHeight);

        #endregion

        #region Command
        /// <summary>
        /// Command for minimized window
        /// </summary>
        public ICommand MinimizeCommand { get; set; }
        /// <summary>
        /// Command for maximized window
        /// </summary>
        public ICommand MaximizeCommand { get; set; }
        /// <summary>
        /// Command for close window
        /// </summary>
        public ICommand CloseCommand { get; set; }
        /// <summary>
        /// Command to show system menu
        /// </summary>
        public ICommand MenuCommand { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for main windows view model
        /// </summary>
        public WindowsViewModel(Window window)
        {
            _window = window;
            //CurrentPage = ApplicationPageEnum.Login;
            // listen out for the window resizing
            _window.StateChanged += _window_StateChanged;
            InitializedCommands();

            //fix windows size
            //var resizer = new WindowResizer(_window);
        }
        #endregion

        #region Private Method

        private void _window_StateChanged(object sender, EventArgs e)
        {
            // Fire off the event for all properties
            OnPropertyChanged(nameof(ResizeBorderThickness));
            OnPropertyChanged(nameof(OuterMarginSize));
            OnPropertyChanged(nameof(OuterMarginSizeThickness));
            OnPropertyChanged(nameof(WindowRadius));
            OnPropertyChanged(nameof(WindowCornerRadius));
        }

        private void InitializedCommands()
        {
            MinimizeCommand = new RelayCommand(() => _window.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => _window.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => _window.Close());
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(_window, GetMousePosition()));
        }

        #endregion

        #region Private Helpers
        /// <summary>
        /// Gets the mouse position of the screen
        /// </summary>
        /// <returns></returns>
        private Point GetMousePosition()
        {
            // Position of the mouse relative to the windows
            var position = Mouse.GetPosition(_window);
            return new Point(position.X + _window.Left, position.Y + _window.Top);
        }
        #endregion
    }
}
