using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HangOutChat.Word
{ 
    /// <summary>
    /// the monitor attached property for password box
    /// </summary>
    public class MonitorPasswordProperty : BaseAttachedProperty<MonitorPasswordProperty, bool>
    { 
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // gets the caller
            var password = sender as PasswordBox;
            if (password == null)
            {
                return;
            }
            // remove any previous events
            password.PasswordChanged += Password_PasswordChanged;

            if ((bool)e.NewValue)
            {
                // sets default value
                HasTextProperty.SetValue(password);

                password.PasswordChanged += Password_PasswordChanged;
            }
        }

        /// <summary>
        /// Fire when the password box value changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            HasTextProperty.SetValue(sender as PasswordBox);
        }
    }

    /// <summary>
    /// Hastext atached property for a password box
    /// </summary>
    public class HasTextProperty : BaseAttachedProperty<HasTextProperty, bool>
    {
        /// <summary>
        /// Sets the hastex property for a passowrd box
        /// </summary>
        /// <param name="sender"></param>
        public static void SetValue(DependencyObject sender)
        {
            SetValue(sender, (sender as PasswordBox).SecurePassword.Length > 0);
        }
    }
}
