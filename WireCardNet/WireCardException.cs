﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WireCardNet
{
    /// <summary>
    /// Exception thrown by the WireCardNet library if a WireCard-specific error occurs
    /// </summary>
    [Serializable]
    public class WireCardException : ApplicationException
    {
        /// <summary>
        /// Creates a new instance of WireCardException
        /// </summary>
        public WireCardException() : base() { }

        /// <summary>
        /// Creates a new instance of WireCardException with error message
        /// </summary>
        public WireCardException(string message) : base(message) { }

        /// <summary>
        /// Creates a new instance of WireCardException with error message and inner exception
        /// </summary>
        public WireCardException(string message, Exception innerException) : base(message, innerException) { }
    }
}
