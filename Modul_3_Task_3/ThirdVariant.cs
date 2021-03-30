using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3_Task_3
{
    public class ThirdVariant
    {
        public async Task<string> WaitResult()
        {
            var hello = Task.Run(async () => await Task.FromResult(File.ReadAllText("hello.txt")));
            var world = Task.Run(async () => await Task.FromResult("World"));
            await Task.WhenAll(hello, world);
            return $"{hello.Result} {world.Result}";
        }
    }
}
