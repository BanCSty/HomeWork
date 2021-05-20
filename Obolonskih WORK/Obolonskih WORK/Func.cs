using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace Obolonskih_WORK
{
    class Func
    {
        public void ShowData(string fileName)
        {
            StreamReader sr = new StreamReader(fileName, Encoding.Default);
            string text = sr.ReadToEnd();
            string[] main = text.Split(';');
            //Array.Sort(main);
            foreach (var item in main)
            {
                Console.Write(item);
                Console.WriteLine();
            }
            Console.ReadLine();
            Array.Sort(main);
            foreach (var item in main)
            {
                Console.Write(item);
                Console.WriteLine();
            }
            Console.ReadLine();          

            //DataTable table = new DataTable("Orders");
            //table.Columns.Add("Номер", typeof(string));
            //table.Columns.Add("Марка", typeof(string));
            //table.Columns.Add("Поломка", typeof(string));

            //DataRow newRow = table.NewRow();
            //for (int i = 0; i < main.Length; i++)
            //{
            //    string[] test = new string[3];
            //    test = main[i].Split('.');
            //    newRow["Номер"] = test[0];
            //    //newRow["Марка"] = test[1];
            //    if (test.Length < 3) 
            //    {
            //        newRow["Поломка"] ="";
            //    }
            //    else
            //    newRow["Поломка"] = test[2];
            //}
            //table.Rows.Add(newRow);
            //Console.WriteLine(table);
        }
    }
}
