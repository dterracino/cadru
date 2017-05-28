﻿//------------------------------------------------------------------------------
// <copyright file="RetryingEventArgs.cs"
//  company="Scott Dorman"
//  library="Cadru">
//    Copyright (C) 2001-2017 Scott Dorman.
// </copyright>
//
// <license>
//    Licensed under the Microsoft Public License (Ms-PL) (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//    http://opensource.org/licenses/Ms-PL.html
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </license>
//------------------------------------------------------------------------------

namespace Cadru.TransientFaultHandling
{
    using System;

    /// <summary>
    /// Contains information that is required for the <see cref="RetryPolicy.Retrying"/> event.
    /// </summary>
    public class RetryingEventArgs : EventArgs
    {
        #region fields
        #endregion

        #region events
        #endregion

        #region constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="RetryingEventArgs"/> class.
        /// </summary>
        /// <param name="currentRetryCount">The current retry attempt count.</param>
        /// <param name="delay">The delay that indicates how long the current thread will be suspended before the next iteration is invoked.</param>
        /// <param name="lastException">The exception that caused the retry conditions to occur.</param>
        public RetryingEventArgs(int currentRetryCount, TimeSpan delay, Exception lastException)
        {
            Contracts.Requires.NotNull(lastException, nameof(lastException));

            this.CurrentRetryCount = currentRetryCount;
            this.Delay = delay;
            this.LastException = lastException;
        }
        #endregion

        #region properties
        /// <summary>
        /// Gets the current retry count.
        /// </summary>
        public int CurrentRetryCount { get; }

        /// <summary>
        /// Gets the delay that indicates how long the current thread will be suspended before the next iteration is invoked.
        /// </summary>
        public TimeSpan Delay { get; }

        /// <summary>
        /// Gets the exception that caused the retry conditions to occur.
        /// </summary>
        public Exception LastException { get; }
        #endregion

        #region methods
        #endregion
    }
}
