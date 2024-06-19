
using FindCommands.Factories;
using System.Reflection.Metadata;

namespace FindCommands
{
    public class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("FIND: Parameter format not correct");
                return;
            }

            var findOptions = BuildOptions(args);

            if (findOptions.HelpMode)
            {
                Console.WriteLine(@"Searches for a text string in a file or files.

FIND [/V] [/C] [/N] [/I] [/OFF[LINE]] ""string"" [[drive:][path]filename[ ...]]

  /V         Displays all lines NOT containing the specified string.
  /C         Displays only the count of lines containing the string.
  /N         Displays line numbers with the displayed lines.
  /I         Ignores the case of characters when searching for the string.
  /OFF[LINE] Do not skip files with offline attribute set.
  ""string""   Specifies the text string to find.
  [drive:][path]filename
             Specifies a file or files to search.

If a path is not specified, FIND searches the text typed at the prompt
or piped from another command.");
                return;
            }

            var sources = LineSourceFactory.CreateInstance(findOptions.Path, findOptions.SkipOfflineFiles);
            foreach(var source in sources)
            {
                ProcessOption(source, findOptions);
            }
        }

        static void ProcessOption(ILineSource source, FindOptions options)
        {
            var stringToFind = options.StringToFind;
            StringComparison comparison = options.InCaseSensitive? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;
            source = new FilteredLineSource(source, (s) => options.FindDontConstain? !s.Text.Contains(stringToFind, comparison) : s.Text.Contains(stringToFind, comparison));

            // count mode;
            int count = 0;

            try
            {
                if(options.Path != "" && !options.CountMode) Console.WriteLine($"\n---------- {source.Name().ToUpper()}");

                source.Open();
                var line = source.ReadLine();

                if(options.CountMode)
                {
                    while (line != null)
                    {
                        count++;
                        line = source.ReadLine();
                    }
                    Console.WriteLine($"\n---------- {source.Name().ToUpper()}: {count}");
                    return;
                }

                while (line != null)
                {
                    Print(line);
                    line = source.ReadLine();
                }
            }
            finally
            {
                source.Close();
            }
        }

        private static void Print(Line line)
        {
            Console.WriteLine($"[{line.LineNumber}] {line.Text}");
        }

        public static FindOptions BuildOptions(string[] args)
        {
            var options = new FindOptions();
            foreach (var arg in args)
            {
                switch (arg)
                {
                    case "/i":
                        options.InCaseSensitive = false;
                        break;
                    case "/v":
                        options.FindDontConstain = true;
                        break;
                    case "/c":
                        options.CountMode = true;
                        break;
                    case "/n":
                        options.ShowLineNumber = true;
                        break;
                    case "/off" or "/offline":
                        options.SkipOfflineFiles = false;
                        break;
                    case "/?":
                        options.HelpMode = true;
                        break;
                    default:
                        if (string.IsNullOrEmpty(options.StringToFind))
                        {
                            options.StringToFind = arg;
                        }
                        else if (string.IsNullOrEmpty(options.Path))
                        {
                            options.Path = arg;
                        }
                        else
                        {
                            throw new ArgumentException(arg);
                        }
                        break;
                }
            }
            return options;
        }
    }

}
