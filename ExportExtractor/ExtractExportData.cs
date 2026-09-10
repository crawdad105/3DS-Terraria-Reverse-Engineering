using System.Security.Cryptography;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace ExtractDumpNames
{
    internal class Program
    {
        // Util for dumping exported text data from binari ninja
        // File -> Export (set the view to Linear-Disassembly to reduse false positives)

        public class Entry {
            public int Address { get; set; }
            public string AddressString { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public string Other { get; set; }
            public bool IsFunction { get; set; }
            public bool IsCodeVariable { get; set; }
            public bool IsUserDefined { get; set; }
            public string ToStringValue { get; set; }
            public override string ToString() {
                return ToStringValue = IsFunction ? $"0x{AddressString} {Type} {Name}({Other})" : $"0x{AddressString} {Type} {Name}";
            }
        }

        static void Main(string[] args) {

            Console.WriteLine("Hello World!");

            var curDir = Directory.GetParent(Environment.GetCommandLineArgs()[0]).ToString();
            if (curDir == @"C:\Users\crawm\source\repos\ExtractDumpNames\ExtractDumpNames\bin\Debug\net8.0") {
                curDir = @"D:\Files\Terraria 3DS Binary Ninja";
            }

            Console.WriteLine("");
            Console.WriteLine("The fallowing files will be overridden, or created.");
            Console.WriteLine("  ./extracted.txt");
            Console.WriteLine("  ./data.js");
            Console.WriteLine("  ./userDefinedData.js");
            Console.WriteLine("  ./markdownFunctions.md");
            Console.WriteLine("  ./markdownVariables.md");
            Console.WriteLine("The fallowing files will be needed.");
            Console.WriteLine("  ./[UserInput].txt");
            Console.WriteLine("  ./descriptions.txt");
            Console.WriteLine("");
            Console.WriteLine("Input name of the binary ninja linear export.");

            var path = "";
            while(true){
                var userInput = Console.ReadLine().TrimStart('\"').TrimEnd('\"');
                if (File.Exists(userInput)) {
                    path = userInput;
                    curDir = Directory.GetParent(userInput).ToString();
                    break;
                }
                path = Path.Combine(curDir + userInput);
                if (File.Exists(path)) break;
                Console.WriteLine($"File at \"{path}\" does not exist.");
            }

            List<string> output = new List<string>();
            List<Entry> data = new List<Entry>();

            Console.WriteLine("Reading Lines...");
            var lines = File.ReadLines(path).ToArray();
            var len = lines.Length;

            for (int i = 0; i < len; i++) {
                var line = lines[i];
                if (line.Contains('(') && line.Contains(')')) {
                    if (Regex.IsMatch(line, "([0-9A-Fa-f]{8}) {4}([^ ]*?) (.*\\((.*)\\) )?([^ ]*?)\\((.*)\\)( (.*))?")) {
                        var m = Regex.Match(line, "([0-9A-Fa-f]{8}) {4}([^ ]*?) (.*\\((.*)\\) )?([^ ]*?)\\((.*)\\)( (.*))?");
                        var addr = Convert.ToInt32(m.Groups[1].Value, 16);
                        var name = m.Groups[5].Value;
                        data.Add(new Entry() {
                            Address = addr,
                            AddressString = m.Groups[1].Value,
                            Type = m.Groups[2].Value,
                            Name = name,
                            Other = m.Groups[6].Value,
                            IsFunction = true,
                            IsCodeVariable = addr < 0x00629000,
                            IsUserDefined = !(name.StartsWith("data_") || name.StartsWith("sub_") || name.StartsWith("j_") || name.StartsWith("jump_table_"))
                        });

                        output.Add(data[data.Count - 1].ToString());
                        Console.WriteLine(line);
                    }
                } else if (line.Contains('=')) {
                    if (Regex.IsMatch(line, "([0-9A-Fa-f]{8}) {2}([^ ]*?) ([^ ]*?) = ")) {
                        var m = Regex.Match(line, "([0-9A-Fa-f]{8}) {2}([^ ]*?) ([^ ]*?) = ");
                        var addr = Convert.ToInt32(m.Groups[1].Value, 16);
                        var name = m.Groups[3].Value;
                        data.Add(new Entry() {
                            Address = addr,
                            AddressString = m.Groups[1].Value,
                            Type = m.Groups[2].Value,
                            Name = name,
                            Other = "",
                            IsFunction = false,
                            IsCodeVariable = addr < 0x00629000,
                            IsUserDefined = !(name.StartsWith("data_") || name.StartsWith("sub_") || name.StartsWith("j_") || name.StartsWith("jump_table_"))
                        });

                        output.Add(data[data.Count - 1].ToString());
                        Console.WriteLine(line);
                    }
                }
            }

            Console.WriteLine("Saving File...");
            File.WriteAllLines(curDir + "\\extracted.txt", output);

            var options = new JsonSerializerOptions { WriteIndented = true };
            Console.WriteLine("Saving Data File...");
            List<string> strs = new List<string>();
            strs.Add("[");
            foreach (var item in data) {
                strs.Add(JsonSerializer.Serialize(item, options) + ",");
            }
            strs[strs.Count - 1] = strs[strs.Count - 1].TrimEnd(',');
            strs.Add("]");

            File.WriteAllLines(curDir + "\\data.json", strs);


            Console.WriteLine("Saving User Defined Data File...");
            strs.Clear();
            strs.Add("[");
            foreach (var item in data) {
                if (item.IsUserDefined) {
                    strs.Add(JsonSerializer.Serialize(item, options) + ",");
                }
            }
            strs[strs.Count - 1] = strs[strs.Count - 1].TrimEnd(',');
            strs.Add("]");
            File.WriteAllLines(curDir + "\\userDefinedData.json", strs);



            Console.WriteLine("Saving Markdown Files...");
            var descs = File.Exists(curDir + "\\descriptions.txt") ? File.ReadAllLines(curDir + "\\descriptions.txt") : new string[] { };
            List<string> foos = new List<string>();
            foos.Add("| Address | Function Signature | Description |");
            foos.Add("| - | - | - |");
            List<string> vars = new List<string>();
            vars.Add("| Address | Variables | Description |");
            vars.Add("| - | - | - |");
            foreach (var item in data) {
                if (item.IsUserDefined) {
                    var elms = descs.Where(x => x.StartsWith(item.AddressString)).Select(x => x.Substring(9));
                    if (item.IsFunction)
                        foos.Add($"| `0x{item.AddressString}` | `{item.Type} {item.Name}({item.Other})` | {string.Join(",", elms)} |");
                    else
                        vars.Add($"| `0x{item.AddressString}` | `{item.Type} {item.Name}` | {string.Join(",", elms)} |");
                }
            }
            File.WriteAllLines(curDir + "\\markdownFunctions.md", foos);
            File.WriteAllLines(curDir + "\\markdownVariables.md", vars);

            Console.WriteLine("Done.");


        }
    }
}
