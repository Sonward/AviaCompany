using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaProject.DAL
{
    public static class FileWorker
    {
        public static void WriteToFile(string path, List<string> text)
        {
            StreamWriter writer = new StreamWriter(path, false);

            foreach (string row in text) { writer.WriteLine(row); }

            writer.Close();
        }
        public static void AddToFile(string path, List<string> text)
        {
            using (StreamWriter writer = File.AppendText(path))
            {
                foreach (string row in text){ writer.WriteLine(row); }
            }
        }
        public static void CleanFile(string path)
        {
            using (StreamWriter writer = File.CreateText(path))
            {
                writer.Write("");
            }
        }

        public static List<string> ReadFromFile(string path)
        {
            List<string> toRet = new List<string>();
            StreamReader reader = new StreamReader(path);

            while (!reader.EndOfStream)
            {
                toRet.Add(reader.ReadLine());
            }
            reader.Close();

            return toRet;
        }
        public static List<string> ReadBlock(string path, string start, int nRows)
        {
            List<string> item = new List<string>();

            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    string temp = reader.ReadLine();
                    if (temp == start) 
                    { 
                        item.Add(start); 
                        for (int i = 1; i < nRows; i++)
                        {
                            item.Add(reader.ReadLine());
                        }
                        return item;
                    }
                }
            }

            return item;
        }
        public static List<string> ReadBlock(string path, string start, string end)
        {
            // returns text betweeen start and end without exactly start and end
            List<string> item = new List<string>();
            bool aded = false;

            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    string temp = reader.ReadLine();
                    if (temp == end) { return item; }
                    if (aded) { item.Add(temp); }
                    if (temp == start) { aded = true; }
                }
            }

            return item;
        }

        public static int FindRow(string path, string row)
        {
            int numOfRow = 0;
            using (StreamReader reader = File.OpenText(path))
            {
                while(!reader.EndOfStream)
                {
                    numOfRow++;
                    if (reader.ReadLine() == row) { break; }
                }
            }

            return numOfRow;
        }
    }
}
