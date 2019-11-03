using System;
using System.Collections.Generic;
using System.Text;

namespace newVersionCSharp._7._0
{
    public class throwExpression : TestMain
    {
        private string _name;
        private int id;
        public override void Test()
        {
            base.Test();

            throwWithExpression(null);
        }

        private void throwWithExpression(string name)
        {
            Console.WriteLine("> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            // old
            //if (name == null)
            //{
            //    throw new ArgumentException();
            //}
            //this._name = name;

            // new
            this._name = name ?? throw new ArgumentException();
        }

        // with Expression-bodied
        public int Id
        {
            get => this.id;
            set => this.id = value > 0 ? value : throw new ArgumentException();
        }
    }
}
