using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2.Functions
{
    public class FindNextSearch
    {
        string searchString;
        string direction;
        bool matchCase;
        string content;
        int position;
        bool success;

        public string SearchString { get => searchString; set => searchString = value; }
        public string Direction { get => direction; set => direction = value; }
        public bool MatchCase { get => matchCase; set => matchCase = value; }
        public string Content { get => content; set => content = value; }
        public int Position { get => position; set => position = value; }
        public bool Success { get => success; set => success = value; }
    }
}
