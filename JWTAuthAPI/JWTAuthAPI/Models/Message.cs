﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JWTAuthAPI.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageBody { get; set; }
        public bool IsRead { get; set; }
        public string ReceiverId { get; set; }
        public string SenderId { get; set; }

    }
}