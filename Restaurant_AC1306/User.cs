﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MohammedTbakhi_Ac1306
{
    class User
    {
        public string username { get; set; }
        public string password { get; set; }

        public User(string Username, string Password)
        {
            username = Username;
            password = Password;
        }
    }
}
