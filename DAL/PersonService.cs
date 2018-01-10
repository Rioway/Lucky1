using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class PersonService
    {
        public List<Person> GetAllPersonByName(string name,List<Person> objListPerson)
        {
            List<Person> objListQuery = new List<Person>();
            foreach(Person item in objListPerson)
            {
                if (item.PersonName.StartsWith(name))
                {
                    objListQuery.Add(item);
                }
            }
            return objListQuery;
        }
        public List<Person> GetAllPersonByMobile(string mobile, List<Person> objListPerson)
        {
            List<Person> objListQuery = new List<Person>();
            foreach (Person item in objListPerson)
            {
                if (item.PersonMobile.StartsWith(mobile))
                {
                    objListQuery.Add(item);
                }
            }
            return objListQuery;
        }
        public string GetNewPerson(List<Person> objListPerson)
        {
            if (objListPerson == null) return "1";
            else
            {
                return (objListPerson[objListPerson.Count - 1].PersonID + 1).ToString();
            }
        }//自动添加编号
        public void AddPerson(Person objPerson,List<Person> objListPerson)
        {
            objListPerson.Add(objPerson);
        }
        public void UpdatePerson(Person objPerson, List<Person> objListPerson)
        {
            for (int i = 0; i < objListPerson.Count; i++)
            {
                if(objListPerson[i].PersonID == objPerson.PersonID)
                {
                    objListPerson.RemoveAt(i);
                    objListPerson.Insert(i,objPerson);
                    break;
                }
            }
        }
        public void DeletePerson(string personID,List<Person> objListPerson)
        {
            foreach (Person item in objListPerson)
            {
                if(item.PersonID == int.Parse(personID))
                {
                    objListPerson.Remove(item);
                    break;
                }
            }
        }
        public string GetOnePerson(List<Person> objListPerson)
        {
            Random objRandom = new Random();
            int number = objRandom.Next(0, objListPerson.Count);
            return objListPerson[number].PersonName + "   " + objListPerson[number].PersonMobile;
        }
        //把中奖人员从Person中删除
        public void RemovePersonfromList(string person,List<Person> objList)
        {
            string[] personArray = person.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (Person item in objList)
            {
                if(item.PersonName == personArray[0] && item.PersonMobile == personArray[1])
                {
                    objList.Remove(item);
                    break;
                }
            }
        }
    }
}
