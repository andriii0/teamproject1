using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp1
{
    public class Note
    {
        public string Author { get; set; }
        public string Content { get; set; }

        public Note(string author, string content)
        {
            Author = author;
            Content = content;
        }
    }
}
