using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3_Task_3
{
    public class FirstVariant
    {
        public async Task<string> WaitResult()
        {
            var hello = ReadHelloAsync();
            var world = GetWordAsync();
            await Task.WhenAll(hello, world);
            return $"{hello.Result} {world.Result}";
        }

        private async Task<string> ReadHelloAsync()
        {
            var t = Task.Factory.StartNew(() =>
            {
                Task.Delay(100);
                return File.ReadAllText("hello.txt");
            });
            await t;
            return t.Result;
        }

        private async Task<string> GetWordAsync()
        {
            var t = Task.Factory.StartNew(() =>
            {
                Task.Delay(50);
                return "World";
            });
            await t;
            return t.Result;
        }
    }
}
