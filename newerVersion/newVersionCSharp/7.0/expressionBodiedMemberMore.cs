using System;
using System.Collections.Generic;
using System.Text;

namespace newVersionCSharp._7._0
{
    public class expressionBodiedMemberMore : TestMain
    {
        public override void Test()
        {
            base.Test();

        }

    }
    // 6.0 : It can be used with method, property, indexer, operator
    // 7.0: It will be more as below
    class Employee
    {
        private int id;
        private string[] tags = new string[10];

        // contructor
        public Employee(int id) => this.id = id;

        // Finalizer (destructor)
        ~Employee() => Console.WriteLine("~Employee()");

        // property
        public int Id
        {
            get => this.id;   // getter
            set => this.id = value > 0 ? value : 0;  // setter
        }

        // indexer
        public string this[int index]
        {
            get => tags[index];
            set => tags[index] = value;
        }

        // event
        private EventHandler notified;
        public event EventHandler Notified
        {
            add => this.notified += value;
            remove => this.notified -= value;
        }
    }
}
