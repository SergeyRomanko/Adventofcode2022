﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Adventofcode2022.Common
{
    public static class Inputs
    {
        private static readonly FileInfo[] Files;

        static Inputs()
        {
            var d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            Files = d.GetFiles("*.txt", SearchOption.AllDirectories);
        }
        
        public static IEnumerable<string> ReadText(string fileName)
        {
            var file = Files.FirstOrDefault(x => x.Name.EndsWith($"{fileName}.txt"));

            var result = Enumerable.Empty<string>();

            try
            {
                result = File.ReadLines(file.FullName);
            }
            catch (Exception e)
            {
                throw new Exception($"File read error {fileName}");
            }

            return result;
        }
    }
}
