using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApiServBox.Models.Answers
{
    public class Answer
    {
        public Data data { get; set; }
        public bool success { get; set; }
        public int code { get; set; }
        public string name { get; set; }
        public string message { get; set; }
        public string time { get; set; } // не стал заморачиваться DateTime "yyyy-MM-dd'T'HH:mm:ss'Z'"
    }
}
