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
    public class ChatListItemDesignModel : ChatListItemViewModel
    {
        #region Contructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public ChatListItemDesignModel()
        {
            Initials = "KM";
            Name = "Kevin";
            Message = "Hey you are so cool!";
            ProfilePictureRGB = "FF13C6BA";
        }
        #endregion

        #region Singleton
        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatListItemDesignModel Instance => new ChatListItemDesignModel();
        #endregion

    }
}
