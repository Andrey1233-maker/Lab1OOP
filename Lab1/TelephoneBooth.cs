using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class TelephoneBooth
    {
        // список номеров 
        static private List<TelephoneNumber> telephoneNumbers = new List<TelephoneNumber>();
        // список соединений между номерами 
        static private List<Connection> connections = new List<Connection>();

        // ПУБЛИЧНЫЕ МЕТОДЫ

        // добавление существующего номера в список
        static public void push(TelephoneNumber telephoneNumber)
        {
            telephoneNumbers.Add(telephoneNumber);
        }

        // создание нового номера в список
        static public void createNew(string owner, string number)
        {   
            telephoneNumbers.Add(new TelephoneNumber(owner, number));
        }

        // удаление номера по индексу
        static public void remove(int index)
        {
            if (index >= 0 && index < telephoneNumbers.Count)
            {
                telephoneNumbers.Remove(telephoneNumbers[index]);
            }
        }

        // создание соединения между двумя номерами
        // один номер может быть только в одно соединении OneToOne
        static public void createConnection(string requster, string responser)
        {
            if(isExist(requster) >= 0 && isExist(responser) >= 0 && isInConnection(requster) && isInConnection(responser)
            {
                connections.Add(new Connection(telephoneNumbers[isExist(requster)], telephoneNumbers[isExist(responser)]));
            }
        }

        // удаление соединения между номерами
        static public void dropConnection(string oneFromConnection)
        {   
            for(int i = 0; i < connections.Count; i++)
            {
                if(connections[i].responser.number == oneFromConnection || connections[i].requester.number == oneFromConnection)
                {
                    connections.Remove(connections[i]);
                    return;
                }
            }
        }

        // ПРИВАТНЫЕ МЕТОДЫ

        // проверка на чуществование номера с указанным номером
        static private int isExist(string number)
        {
            for(int i = 0; i < telephoneNumbers.Count; i++)
            {
                if (telephoneNumbers[i].number == number)
                {
                    return i;
                }
            }
            return -1;
        }

        // проверка на существование связи с указанным номером
        static private bool isInConnection(string number)
        {
            for(int i = 0; i < connections.Count; i++)
            {
                if(connections[i].responser.number == number || connections[i].requester.number == number)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
