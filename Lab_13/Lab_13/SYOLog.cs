﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab_13
{
    static class SYOLog
    {
        public static void AddSign(string utility, string path, string message)
        {
            using (StreamWriter sr = new StreamWriter(@"E:\ООП\Lab_13\Lab_13\SYOLog.txt", true))
            {
                sr.WriteLine($"{utility}: {path}");
                sr.WriteLine($"{message}: {DateTime.Now}");
            }
        }

    }
}
