using System;
using System.Collections.Generic;
using System.Text;

namespace NewsCore.Interceptors
{
    public class CachingAttribute : Attribute
    {
        public int Duration { get; }
        /// <summary>
        /// Its provide Cashing
        /// </summary>
        /// <param name="duration">time type is minutes</param>
        public CachingAttribute(int duration)
        {
            Duration = duration;
        }

        

    }
}
