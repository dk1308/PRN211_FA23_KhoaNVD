using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCommands
{
    public class FindOptions
    {
        public string StringToFind { get; set; } = string.Empty;
        public bool InCaseSensitive { get; set; } = true;
        public bool FindDontConstain { get; set; } = false;
        public bool CountMode { get; set; } = false;
        public bool ShowLineNumber { get; set; } = false;
        public bool SkipOfflineFiles { get; set; } = true;
        public string Path { get; set; } = string.Empty;
        public bool HelpMode { get; set; } = false;
    }
}
