using Course.Devices;
using System;
using System.Collections.Generic;

namespace heranca_multipla_problema_do_diamante.Devices
{
    class Scanner : Device, IScanner
    {

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
