﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarukSahin.MailService
{
    public class Model
    {
        public string Mail { get; set; }
        public string Password { get; set; }      
        public class MailContent
        {
            public string subject { get; set; }
            public string body { get; set; }
        }
        public MailContent MailList { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
    }
}
