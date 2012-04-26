using System;               // Console
using System.IO;            // File,Directory
using System.Diagnostics;   // Process
using System.ComponentModel;// Win32Exception
using System.Text.RegularExpressions;// Regex

class Open {
    public static void Main(string[] args) {
        if (args.Length != 0) {
            foreach (string arg in args) {
                if (Regex.IsMatch(arg, @"^s?https?://[-_.!~*'()a-zA-Z0-9;/?:@&=+$,%#]+$")) {
                    try {
                        Process.Start(arg);
                    } catch (Win32Exception e) {
                        Console.WriteLine("[ERROR] " + arg + " : " +  e.Message);
                    }
                } else if (File.Exists(arg)) { // ファイルの時
                    try {
                        Process.Start(arg);
                    } catch (Win32Exception e) {
                        Console.WriteLine("[ERROR] " + arg + " : " +  e.Message);
                    }
                } else if (Directory.Exists(arg)) { // ディレクトリの時
                    try {
                        Process.Start("EXPLORER.EXE", "/n, " + arg);
                    } catch (Win32Exception e) {
                        Console.WriteLine("[ERROR] " + arg + " : " +  e.Message);
                    }
                } else {
                    Console.WriteLine("[ERROR] File Not Found : " + arg);
                }
            }
        }
    }
}
