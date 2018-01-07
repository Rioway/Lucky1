using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.IO;

namespace Common
{
    public static class FileOperator
    {
        public static List<Person> ReadFile(string filePath)
        {
            List<Person> objList = new List<Person>();
            try
            {
                StreamReader sr = new StreamReader(filePath,Encoding.Default);
                string line = sr.ReadLine();
                while(line != null)
                {
                    string[] personArray = line.Split(',');
                    objList.Add
                    (
                        new Person
                        {
                            PersonID = Convert.ToInt32(personArray[0]),
                            PersonName = personArray[1],
                            PersonMobile = personArray[2],
                        }

                   );
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            
            catch(Exception ex)
            {
                throw ex;
            }
            return objList;
        }
    }
}
