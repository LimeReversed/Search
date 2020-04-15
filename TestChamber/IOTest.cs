﻿using NUnit.Framework;
using Search;
using System;
using System.IO;
using SearchLibrary;

namespace TestChamber
{
    public class IOTest
    {
        [Test]
        public void ReadFile_HappyDays()
        {
            string path = $"{AppDomain.CurrentDomain.BaseDirectory}TestFiles\\TextFile3.txt";
            Assert.AreEqual("timmy is the smartest. #admit", InputOutput.ReadFile(path));
        }

        [Test]
        public void SaveFile_HappyDays()
        {
            string fileLocation = $"{AppDomain.CurrentDomain.BaseDirectory}TestFiles\\IOTest1.txt";
            InputOutput.SaveFile(fileLocation, $"{AppDomain.CurrentDomain.BaseDirectory}TestFiles", "IOTest1");

            if (File.Exists(fileLocation))
            {
                Assert.Pass();
            }
        }

    }
}
