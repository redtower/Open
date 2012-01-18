using System;               // Console
using System.IO;            // File,Directory
using System.Diagnostics;   // Process
using System.ComponentModel;// Win32Exception

class Open {
    public static void Main(string[] args) {
        if (args.Length != 0) {
            foreach (string arg in args) {
                if (File.Exists(arg)) { // �t�@�C���̎�
                    try {
                        Process.Start(arg);
                    } catch (Win32Exception e) {
                        Console.WriteLine("[ERROR] " + arg + " : " +  e.Message);
                    }
                } else if (Directory.Exists(arg)) { // �f�B���N�g���̎�
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
