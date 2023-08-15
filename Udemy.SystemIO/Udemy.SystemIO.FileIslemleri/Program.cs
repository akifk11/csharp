﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.SystemIO.FileIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool kontrol = FileExists("c:\\udemy\\merhaba.txt");
            //if (kontrol)
            //{
            //    Console.WriteLine("Belirtmis oldugunuz dosya sistem icerisinde bulunmaktadir");
            //}
            //else
            //{
            //    FileCreate("c:\\udemy\\merhaba.txt");
            //}

            // FileAppendText("c:\\udemy\\merhaba.txt","merhaba TXT");

            //FileCopy("c:\\udemyII\\merhaba.txt", "c:\\udemy\\merhaba.txt");

            //FileMove("c:\\udemy\\merhaba.txt", "c:\\udemyII\\merhaba.txt");

            //FileDelete("c:\\udemy\\merhaba.txt");

            string metinDegeri = FileReadAllText("c:\\udemy\\merhaba.txt");
            Console.WriteLine("METIN:"+metinDegeri);

        }
        static void FileCreate(string path)
        {
            FileStream fs = File.Create(path);
            fs.Close();
        }

        static bool FileExists(string path)
        {
            return File.Exists(path);
        }

        static void FileDelete(string path)
        {
            File.Delete(path);
        }

        static void FileMove(string kaynak, string hedef)
        {
            File.Move(kaynak, hedef);
        }

        static void FileCopy(string kaynak, string hedef)
        {
            File.Copy(kaynak, hedef);
        }

        static void FileAppendText(string path, string deger)
        {
            File.AppendAllText(path, deger);
        }

        static string FileReadAllText(string path)
        {
            string metinDegeri = File.ReadAllText(path);
            return metinDegeri;
        }
    }
}
