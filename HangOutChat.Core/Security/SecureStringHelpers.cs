﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace HangOutChat.Word.Core
{
    /// <summary>
    /// helpers for the secured string class
    /// </summary>
    public static class SecureStringHelpers
    {
        /// <summary>
        /// unsecures the secured string
        /// </summary>
        /// <param name="secureString"></param>
        /// <returns></returns>
        public static string Unsecure(this SecureString secureString)
        {
            if (secureString == null)
            {
                return string.Empty;
            }

            // get a pointer for an unsecure string in memory
            var unmanagedString = IntPtr.Zero;

            try
            {
                // unsecures the password
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                // clean up any memory allocation
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}
