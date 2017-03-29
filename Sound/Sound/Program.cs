using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sound
{
    class Program
    {
        static void Main(string[] args)
        { }
            [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool Beep(int frequency, int duration);

        private void button8_Click(object sender, EventArgs e)
        {
            Beep(255, 333);
        }
    }
}
