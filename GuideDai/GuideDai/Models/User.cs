﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideDai.Models
{
    [Serializable]
    public abstract class User// абстрактний клас юзер з спільними полями юзера та адміна
    {
        public User() { }  
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
        public string Name { set; get; }
        public string Password { set; get; }

    }
}
