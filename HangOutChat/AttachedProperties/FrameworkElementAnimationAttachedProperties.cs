using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HangOutChat.Word
{
    /// <summary>
    /// a base class to run any animation method when a boolean is set to true
    /// </summary>
    /// <typeparam name="Parent"></typeparam>
    public abstract class AnimateBaseProperty<Parent> : BaseAttachedProperty<Parent, bool>
        where Parent : BaseAttachedProperty<Parent, bool>, new ()
    {
        #region Public Properties
        /// <summary>
        /// flag indicating if this is the first time this property has been loaded
        /// </summary>
        public bool FirstLoad { get; set; } = true;
        #endregion

        public override void OnValueUpdated(DependencyObject sender, object value)
        {
            // get the framework element
            if (!(sender is FrameworkElement element))
            {
                return;
            }

            if (sender.GetValue(ValueProperty) == value && !FirstLoad)
            {
                return;
            }

            if (FirstLoad)
            {
                // create single self-unhookable event
                // for the element loaded event
                RoutedEventHandler onloaded = null;
                onloaded = (ss, ee) =>
                {
                    // unhook ourselves
                    element.Loaded -= onloaded;
                    // do desired animation
                    DoAnimation(element, (bool)value);

                    FirstLoad = false;
                };

                element.Loaded += onloaded;
            }
            else
            {
                DoAnimation(element, (bool)value);
            }
        }

        /// <summary>
        /// The animation that is fired when the value is change
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        protected virtual void DoAnimation(FrameworkElement element, bool value) { }
    }

    /// <summary>
    /// Animates a framework element 
    /// </summary>
    public class AnimateSlideInFromLeftProperty : AnimateBaseProperty<AnimateSlideInFromLeftProperty>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value)
        {
            if (value)
            {
                // animate in
                await element.SlideAndFadeInFromLeftAsync(FirstLoad ? 0 : 0.3f, keepMargin: false);
            }
            else
            {
                await element.SlideAndFadeOutToLeftAsync(FirstLoad ? 0 : 0.3f, keepMargin: false);
            }
        }
    }
}
