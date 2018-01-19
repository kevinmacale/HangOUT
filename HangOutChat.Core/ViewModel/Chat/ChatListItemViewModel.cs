using HangOutChat.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangOutChat.Word.Core
{
    /// <summary>
    /// View Model for each chatlist item
    /// </summary>
    public class ChatListItemViewModel : BaseViewModel
    {
        /// <summary>
        /// the display name of this chat list
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the latest message from this chat
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// initials of the chat user
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// The RGB values in hex for the BG Color
        /// </summary>
        public string ProfilePictureRGB { get; set; }

        /// <summary>
        /// True when the msg does not read yet
        /// </summary>
        public bool NewContentAvailable { get; set; }

        /// <summary>
        /// True if the item is selected
        /// </summary>
        public bool IsSelected { get; set; }
    }
}
