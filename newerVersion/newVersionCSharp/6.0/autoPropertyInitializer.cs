using System;
using System.Collections.Generic;
using System.Text;

namespace newVersionCSharp._6._0
{
    public class autoPropertyInitializer : TestMain
    {
        public string Name { get; set; } = "Some of Name";

        // before: it requires private set;
        public string Nickname { get; }
        public int Age { get; }
        public bool Enabled { get; } = true; // it is possible to initialize read-only property  
        public int Level { get; }

        public autoPropertyInitializer()
        {
            this.Level = 1; // it is possible to initialize read-only property 
        }

        public override void Test()
        {
            base.Test();

            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("NickName " + this.Nickname);
            Console.WriteLine("Age " + this.Age);
            Console.WriteLine("Enabled " + this.Enabled);
            Console.WriteLine("Level " + this.Level);
        }
    }
}
