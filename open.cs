using System;
using System.IO;

class Open {
    public static void Main(string[] args) {
        if (args.Length != 0) {
            foreach (string arg in args) {
                if (File.Exists(arg)) {
                    System.Diagnostics.Process.Start(arg);
                } else {
                    Console.WriteLine("[ERROR] File Not Found : " + arg);
                }
            }
        }
    }
}
