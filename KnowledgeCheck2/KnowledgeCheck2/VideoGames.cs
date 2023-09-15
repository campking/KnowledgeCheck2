using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KnowledgeCheck2
{
    internal class VideoGames
    {
        public string Console { get; set;}
        public string? Rating { get; set; }
        public string? Title { get; set; }

        public override string ToString()
        {
            return "Person: " + Title + " " + Rating + " " + Console;
        }

    }
   


}
