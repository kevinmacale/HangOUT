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
    /// helpers to animate FrameWorkElement
    /// </summary>
    public static class FrameWorkElementAnimations
    {
        /// <summary>
        /// Slides  a element in from the right
        /// </summary>
        /// <param name="element"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRightAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true)
        {
            // create the storyboard
            var sb = new Storyboard();
            // add slide from right animation
            sb.AddSlideFromRight(seconds, element.ActualWidth, keepMargin: keepMargin);
            // add fade in animation
            sb.AddFadeIn(seconds);
            // start animating
            sb.Begin(element);
            // make papge visible
            element.Visibility = Visibility.Visible;
            // wait for it to finish
            await Task.Delay((int)(seconds * 500));
        }

        /// <summary>
        /// Slides  a element in from the left
        /// </summary>
        /// <param name="element"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromLeftAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true)
        {
            // create the storyboard
            var sb = new Storyboard();
            // add slide from right animation
            sb.AddSlideFromLeft(seconds, element.ActualWidth, keepMargin: keepMargin);
            // add fade in animation
            sb.AddFadeIn(seconds);
            // start animating
            sb.Begin(element);
            // make papge visible
            element.Visibility = Visibility.Visible;
            // wait for it to finish
            await Task.Delay((int)(seconds));
        }

        /// <summary>
        /// Slides  a element in to the left
        /// </summary>
        /// <param name="element"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeftAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true)
        {
            // create the storyboard
            var sb = new Storyboard();
            // add slide from right animation
            sb.AddSlideToLeft(seconds, element.ActualWidth, keepMargin: keepMargin);
            // add fade in animation
            sb.AddFadeOut(seconds);
            // start animating
            sb.Begin(element);
            // make papge visible
            element.Visibility = Visibility.Visible;
            // wait for it to finish
            await Task.Delay((int)(seconds));
        }

        /// <summary>
        /// Slides  a element in to the Right
        /// </summary>
        /// <param name="element"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToRightAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true)
        {
            // create the storyboard
            var sb = new Storyboard();
            // add slide from right animation
            sb.AddSlideToRight(seconds, element.ActualWidth, keepMargin: keepMargin);
            // add fade in animation
            sb.AddFadeOut(seconds);
            // start animating
            sb.Begin(element);
            // make papge visible
            element.Visibility = Visibility.Visible;
            // wait for it to finish
            await Task.Delay((int)(seconds));
        }
    }
}
