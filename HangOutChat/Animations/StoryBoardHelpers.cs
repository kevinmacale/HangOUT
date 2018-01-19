using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace HangOutChat.Word
{
    /// <summary>
    /// Animations helpers for storyboard
    /// </summary>
    public static class StoryBoardHelpers
    {
        /// <summary>
        /// add a slide from  right animation to the story board
        /// </summary>
        /// <param name="storyBoard">the storyboard to add the animation</param>
        /// <param name="seconds">the time animation will take</param>
        /// <param name="offset">the distance to the right to start from</param>
        /// <param name="decelartion">the rate of decelaration</param>
        public static void AddSlideFromRight(this Storyboard storyBoard, float seconds, double offset, float decelartion = 0.9f, bool keepMargin = true)
        {
            var slideanimation = new ThicknessAnimation()
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(keepMargin ? offset : 0, 0, -offset, 0),
                To = new Thickness(0),
                DecelerationRatio = decelartion
            };

            Storyboard.SetTargetProperty(slideanimation, new PropertyPath("Margin"));
            storyBoard.Children.Add(slideanimation);
        }
        /// <summary>
        /// add a slide from left animation to the story board
        /// </summary>
        /// <param name="storyBoard">the storyboard to add the animation</param>
        /// <param name="seconds">the time animation will take</param>
        /// <param name="offset">the distance to the left to start from</param>
        /// <param name="decelartion">the rate of decelaration</param>
        public static void AddSlideFromLeft(this Storyboard storyBoard, float seconds, double offset, float decelartion = 0.9f, bool keepMargin = true)
        {
            var slideanimation = new ThicknessAnimation()
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(-offset, 0, keepMargin ? offset : 0, 0),
                To = new Thickness(0),
                DecelerationRatio = decelartion
            };

            Storyboard.SetTargetProperty(slideanimation, new PropertyPath("Margin"));
            storyBoard.Children.Add(slideanimation);
        }

        /// <summary>
        /// add a slide from right animation to the story board
        /// </summary>
        /// <param name="storyBoard">the storyboard to add the animation</param>
        /// <param name="seconds">the time animation will take</param>
        /// <param name="offset">the distance to the right to start from</param>
        /// <param name="decelartion">the rate of decelaration</param>
        public static void AddSlideToRight(this Storyboard storyBoard, float seconds, double offset, float decelartion = 0.9f, bool keepMargin = true)
        {
            var slideanimation = new ThicknessAnimation()
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(keepMargin ? offset : 0, 0, -offset, 0),
                DecelerationRatio = decelartion
            };

            Storyboard.SetTargetProperty(slideanimation, new PropertyPath("Margin"));
            storyBoard.Children.Add(slideanimation);
        }


        /// <summary>
        /// add a slide from left animation to the story board
        /// </summary>
        /// <param name="storyBoard">the storyboard to add the animation</param>
        /// <param name="seconds">the time animation will take</param>
        /// <param name="offset">the distance to the left to start from</param>
        /// <param name="decelartion">the rate of decelaration</param>
        public static void AddSlideToLeft(this Storyboard storyBoard, float seconds, double offset, float decelartion = 0.9f, bool keepMargin = true)
        {
            var slideanimation = new ThicknessAnimation()
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(-offset, 0, keepMargin ? offset : 0, 0),
                DecelerationRatio = decelartion
            };

            Storyboard.SetTargetProperty(slideanimation, new PropertyPath("Margin"));
            storyBoard.Children.Add(slideanimation);
        }

        /// <summary>
        /// add a fade in animation to the story board
        /// </summary>
        /// <param name="storyBoard">the storyboard to add the animation</param>
        /// <param name="seconds">the time animation will take</param>
        /// <param name="offset">the distance to the right to start from</param>
        /// <param name="decelartion">the rate of decelaration</param>
        public static void AddFadeIn(this Storyboard storyBoard, float seconds)
        {
            var slideanimation = new DoubleAnimation()
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 0,
                To = 1
            };

            Storyboard.SetTargetProperty(slideanimation, new PropertyPath("Opacity"));
            storyBoard.Children.Add(slideanimation);
        }

        /// <summary>
        /// add a fade out animation to the story board
        /// </summary>
        /// <param name="storyBoard">the storyboard to add the animation</param>
        /// <param name="seconds">the time animation will take</param>
        /// <param name="offset">the distance to the right to start from</param>
        /// <param name="decelartion">the rate of decelaration</param>
        public static void AddFadeOut(this Storyboard storyBoard, float seconds)
        {
            var slideanimation = new DoubleAnimation()
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 1,
                To = -10,
            };

            Storyboard.SetTargetProperty(slideanimation, new PropertyPath("Opacity"));
            storyBoard.Children.Add(slideanimation);
        }
    }
}
