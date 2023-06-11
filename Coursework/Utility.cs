using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace Coursework
{
public class Utility
    {

        private static string _filePath = "visitors.txt";

        public static string WriteToText(string data)
        {
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath);
            }

            using (StreamWriter outputFile = new StreamWriter(_filePath))
            {
                outputFile.WriteLine(data);
            }


            return "victory";
            Console.WriteLine("Nabin");
        }

        public static string ReadToText()
        {
            if (File.Exists(_filePath))
            {
                //  File.Create(_filePath);
                string data1 = File.ReadAllText(_filePath);
                return data1;
            }



            return null;
        }

        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            if (data != null)
            {
                foreach (T item in data)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    table.Rows.Add(row);
                }
            }
            return table;
        }
    }
}
