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
    public class ChatListViewModel : BaseViewModel
    {
        /// <summary>
        /// the chat list items
        /// </summary>
        public List<ChatListItemViewModel> Items { get; set; }
    }
}
