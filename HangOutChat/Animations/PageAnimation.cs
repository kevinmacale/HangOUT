using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangOutChat.Word
{
    /// <summary>
    /// Styles the page animations/disappearing
    /// </summary>
    public enum PageAnimation
    {
        None = 0,
        /// <summary>
        /// The page slides in and fades in from right
        /// </summary>
        SlideAndFadeFromRight = 1,
        /// <summary>
        /// the page slides in and fades to the left
        /// </summary>
        SlideAndFadeToLeft = 2,
    }
}
