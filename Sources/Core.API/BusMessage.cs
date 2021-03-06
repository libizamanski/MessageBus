﻿using System;
using System.Collections.Generic;

namespace MessageBus.Core.API
{
    /// <summary>
    /// 
    /// </summary>
    public class BusHeader
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Value { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class BusMessage
    {
        internal BusMessage()
        {
            Headers = new List<BusHeader>();
        }

        /// <summary>
        /// 
        /// </summary>
        public string BusId { get; internal set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Sent { get; internal set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<BusHeader> Headers { get; private set; }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BusMessage<T> : BusMessage
    {
        /// <summary>
        /// 
        /// </summary>
        public T Data { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class RawBusMessage : BusMessage
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// 
        /// </summary>
        public string Namespace { get; internal set; }

        /// <summary>
        /// 
        /// </summary>
        public object Data { get; internal set; }
    }
}