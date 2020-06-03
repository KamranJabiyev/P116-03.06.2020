using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    class Student
    {
        public string Name { get; set; }
        public int Result { get; set; }

        public event Action<bool> Notify;
        public Student(string name,int result)
        {
            Name = name;
            Result = result;
        }

        public void MakeNotification()
        {
            if (Result < 65)
            {
                Notify(false);
                return;
            }

            Notify(true);
        }
    }
}
