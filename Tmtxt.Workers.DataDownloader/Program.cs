using System;
using System.Threading.Tasks;

namespace Tmtxt.Workers.DataDownloader
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var worker = new Worker();
            await worker.StartAsync();
        }
    }
}