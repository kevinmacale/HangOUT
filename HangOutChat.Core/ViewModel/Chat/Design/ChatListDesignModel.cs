using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangOutChat.Word.Core
{
    /// <summary>
    /// The design time data for chatlistviewmodel
    /// </summary>
    public class ChatListDesignModel : ChatListViewModel
    {
        #region Contructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public ChatListDesignModel()
        {
            Items = new List<ChatListItemViewModel>()
            {
                new ChatListItemViewModel()
                {
                    Name = "Juan",
                    Initials = "JDC",
                    Message = "Ang probinsyano na!",
                    ProfilePictureRGB = "3099c5",
                    NewContentAvailable = true
                },

                new ChatListItemViewModel()
                {
                    Name = "Kevin",
                    Initials = "KM",
                    Message = "You are so cool!",
                    ProfilePictureRGB = "FF4D7E7B",
                    NewContentAvailable = false

                },

                new ChatListItemViewModel()
                {
                    Name = "Maria",
                    Initials = "MC",
                    Message = "Oh kay ganda!",
                    ProfilePictureRGB = "FF27A139",
                    NewContentAvailable = true,
                    IsSelected = true,
                }

            };
        }
        #endregion

        #region Singleton
        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatListDesignModel Instance => new ChatListDesignModel();
        #endregion

    }
}
