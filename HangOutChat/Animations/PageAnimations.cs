using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace HangOutChat.Word
{
    /// <summary>
    /// helpers to animate pages
    /// </summary>
    public static class PageAnimations
    {
        /// <summary>
        /// Slides  a page in from the right
        /// </summary>
        /// <param name="page"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRightAsync(this Page page, float seconds)
        {
            // create the storyboard
            var sb = new Storyboard();
            // add slide from right animation
            sb.AddSlideFromRight(seconds, page.WindowWidth);
            // add fade in animation
            sb.AddFadeIn(seconds);
            // start animating
            sb.Begin(page);
            // make papge visible
            page.Visibility = Visibility.Visible;
            // wait for it to finish
            await Task.Delay((int)(seconds * 500));
        }

        /// <summary>
        /// Slides  a page out from the left
        /// </summary>
        /// <param name="page"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeftAsync(this Page page, float seconds)
        {
            // create the storyboard
            var sb = new Storyboard();
            // add slide from right animation
            sb.AddSlideToLeft(seconds, page.WindowWidth);
            // add fade in animation
            sb.AddFadeOut(seconds);
            // start animating
            sb.Begin(page);
            // make papge visible
            page.Visibility = Visibility.Visible;
            // wait for it to finish
            await Task.Delay((int)(seconds * 500));
        }
    }
}
