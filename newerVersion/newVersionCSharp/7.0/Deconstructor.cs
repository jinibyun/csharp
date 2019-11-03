using System;
using System.Collections.Generic;
using System.Text;

namespace newVersionCSharp._7._0
{
   
    public class DeconstructorTest : TestMain
    {
        public override void Test()
        {
            base.Test();

            // Contructor
            BasicInfo person = new BasicInfo(1, "Lee", 10);

            // NOTE: calling "Deconstruct", just class name without parenthesis
            // Deconstruct
            var (id, name, age) = person;

            Console.WriteLine($"{id} - {name} - {age}");
        }
    }

    // NOTE: "Desconstructor" is different from "destructor"
    // Constructor: Class intialization with or without field initialization
    // Deconstructor: Return all initialized field value to caller (object instance) 

    class BasicInfo
    {
        private int _id;
        private string _name;
        private int _age;

        // Constructor
        public BasicInfo(int id, string name, int age)
        {
            this._id = id;
            this._name = name;
            this._age = age;
        }

        // Deconstructor: This is "reseverd" method name
        // All parameter should defined with "out" 
        // Although it is void, it is similar to return to caller
        // Advantage:
        // Instead of returning all members using multiple properties, it will return all at once
        public void Deconstruct(out int id, out string name, out int age)
        {
            Console.WriteLine("> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            id = this._id;
            name = this._name;
            age = this._age;
        }
    }
}
