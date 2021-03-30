using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3_Task_3
{
    public class SecondVariant
    {
        public async Task<string> WaitResult()
        {
            var hello = await Task.Run(async () =>
            {
                var t = Task.Factory.StartNew(() =>
                {
                    Task.Delay(100);
                    return File.ReadAllText("hello.txt");
                });
                await t;

                return t.Result;
            });

            var world = await Task.Run(async () =>
            {
                var t = Task.Factory.StartNew(() =>
                {
                    Task.Delay(50);
                    return "World";
                });
                await t;
                return t.Result;
            });
            return $"{hello} {world}";
        }
    }
}
