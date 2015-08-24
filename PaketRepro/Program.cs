using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaketRepro
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private async Task DoAsync()
        {
            await TaskEx.FromResult(1);
        }
    }
}
