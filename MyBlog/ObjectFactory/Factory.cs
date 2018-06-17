using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProj.ObjectFactory
{
    public static class Factory<T> where T : new()
    {
        public static T GetObject() 
        {
            return new T();
        }

        public static T GetObject<Tm>() where Tm : new()
        {
            return new T();
        }
    }
}