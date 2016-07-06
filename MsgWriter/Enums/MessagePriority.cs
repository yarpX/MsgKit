// ReSharper disable InconsistentNaming

/*
   Copyright 2015 - 2016 Kees van Spelde

   Licensed under The Code Project Open License (CPOL) 1.02;
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

     http://www.codeproject.com/info/cpol10.aspx

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

namespace MsgWriter.Enums
{
    /// <summary>
    ///     Contains a value that indicates the message sender's opinion of the importance of a message. 
    /// </summary>
    /// <remarks>
    ///     See https://msdn.microsoft.com/en-us/library/cc765646(v=office.15).aspx
    /// </remarks>
    public enum MessagePriority
    {
        /// <summary>
        ///     The message is not urgent.
        /// </summary>
        PRIO_NONURGENT = 0,

        /// <summary>
        ///     The message has normal priority.
        /// </summary>
        PRIO_NORMAL = 1,

        /// <summary>
        ///     The message is urgent.
        /// </summary>
        PRIO_URGENT = 2
    }
}