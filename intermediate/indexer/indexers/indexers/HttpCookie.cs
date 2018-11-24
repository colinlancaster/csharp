using System;
using System.Collections.Generic;

namespace indexers
{
    public class HttpCookie
    {

        // Auto implemented parameters 

        // a generic class, with generic parameters
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        // Constructor
        public HttpCookie()
        {
            // Must initialize
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}