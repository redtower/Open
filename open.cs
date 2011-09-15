using System;
using System.IO;
using System.Diagnostics;

class Open {
    public static void Main(string[] args) {
        if (args.Length != 0) {
            foreach (string arg in args) {
                if (File.Exists(arg)) {
                    try {
                        Process.Start(arg);
                    } catch (System.ComponentModel.Win32Exception e) {
                        Console.WriteLine("[ERROR] " + arg + " : " +  e.Message);
                    }
                } else {
                    Console.WriteLine("[ERROR] File Not Found : " + arg);
                }
            }
        }
    }
}
