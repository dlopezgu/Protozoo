﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Backend
{
    [DataContract]
    public class Message
    {
        public Message()
        {

        }

        public Message(string text, string type)
        {
            Text = text;
            Type = type;
        }

        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public string Type { get; set; }
    }
}
