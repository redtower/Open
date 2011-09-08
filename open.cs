using System;
using System.IO;
using System.Diagnostics;

class Open {
    public static void Main(string[] args) {
        if (args.Length != 0) {
            foreach (string arg in args) {
                if (File.Exists(arg)) {
                    Process.Start(arg);
                } else {
                    Console.WriteLine("[ERROR] File Not Found : " + arg);
                }
            }
        }
    }
}
