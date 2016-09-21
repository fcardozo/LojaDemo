using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Infrastructure.CustomException
{
    internal static class FactoryExceptionMessage
    {
        static ListTextException listTextEceptionMessages ;

        /// <summary>
        /// Method selects the message by key.
        /// </summary>
        /// <param name="key">Key to select</param>
        /// <returns>Return message from key.</returns>
        internal static string GetMessageByKey(string key)
        {
            if (listTextEceptionMessages == null)
                listTextEceptionMessages = ListTextException.Load();

            var messageObj = listTextEceptionMessages.ListOfException.Where(p => p.Key.Equals(key)).FirstOrDefault();

            if (messageObj != null)
                return messageObj.value;
            else
                throw new ArgumentException(string.Format("Error on load the message for key {0}", key));
        }
    }
}
