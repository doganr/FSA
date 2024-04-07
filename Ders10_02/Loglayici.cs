using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ders10_02
{
    internal class Loglayici
    {
        public string Path { get; }
        public List<Log> Logs { get; }

        public Loglayici(string path) 
        {
            Path = path;
            Logs = new List<Log>();
        }

        public void SaveToFile() 
        {
            string yazilacak = JsonSerializer.Serialize(Logs);
            File.WriteAllText(Path, yazilacak);
        }

    }
}
