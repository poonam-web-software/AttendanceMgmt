﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AttendenceMgmt.Models
{
    public class Signup
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public string Mobile_No { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public string Confirm_Password { set; get; }
    }
}