using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    internal class MicrosoftGames : VideoGames
    {
        public string? GamePass { get; set; }
        public override string ToString()
        {
            return "Game: " + Title + " " + Rating + " " + Console + " " + GamePass;
        }
    }
}
