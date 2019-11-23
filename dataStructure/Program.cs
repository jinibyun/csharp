using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace dataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // testSortedTest();
            testLinkedList();
            // testQueue();
            // testConcurrentQueue();
            // testStack();
            // testConcurrentStack();
            // testDictionary();
            // testConcurrentDictionary();
            // testBinaryTree();            
        }        

        private static void testBinaryTree()
        {
            BinaryTree<int> btree = new BinaryTree<int>();
            btree.Root = new BinaryTreeNode<int>(1);
            btree.Root.Left = new BinaryTreeNode<int>(2);
            btree.Root.Right = new BinaryTreeNode<int>(3);
            btree.Root.Left.Left = new BinaryTreeNode<int>(4);

            btree.PreOrderTraversal(btree.Root);
        }        

        private static void testConcurrentDictionary()
        {
            // multithread
            var dict = new ConcurrentDictionary<int, string>();

            // thread 1
            // thread to input data to dictionary
            Task t1 = Task.Factory.StartNew(() =>
            {
                int key = 1;                
                while (key <= 100)
                {
                    if (dict.TryAdd(key, "D" + key))
                    {
                        key++;
                    }
                    Thread.Sleep(100);
                }
            });

            // thread 2
            // thread to read data from dictionary
            Task t2 = Task.Factory.StartNew(() =>
            {
                int key = 1;
                string val;
                while (key <= 100)
                {
                    if (dict.TryGetValue(key, out val))
                    {
                        Console.WriteLine("{0},{1}", key, val);
                        key++;
                    }
                    Thread.Sleep(100);
                }
            });

            Task.WaitAll(t1, t2);

        }

        private static void testDictionary()
        {
            Dictionary<int, string> emp = new Dictionary<int, string>();
            emp.Add(1001, "Jane");
            emp.Add(1002, "Tom");
            emp.Add(1003, "Cindy");

            string name = emp[1002];
            Console.WriteLine(name);
        }

        private static void testConcurrentStack()
        {
            // it is for multithread environment
            var s = new ConcurrentStack<int>();

            // thread 1
            // thread to input data to stack
            Task tPush = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    s.Push(i);
                    Thread.Sleep(100);
                }
            });

            // thread 2
            // thread to read data from queue
            Task tPop = Task.Factory.StartNew(() =>
            {
                int n = 0;
                int result;
                while (n < 100)
                {
                    if (s.TryPop(out result))
                    {
                        Console.WriteLine(result);
                        n++;
                    }
                    Thread.Sleep(150); // time set to different than above
                }
            });

            // wait for all thread to be finished
            Task.WaitAll(tPush, tPop);
        }

        private static void testConcurrentQueue()
        {
            // it is for multithread environment
            var q = new ConcurrentQueue<int>();

            // thread 1
            // thread to input data to queue
            Task tEnq = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    q.Enqueue(i);
                    Thread.Sleep(100);
                }
            });

            // thread 2
            // thread to read data from queue
            Task tDeq = Task.Factory.StartNew(() =>
            {
                int n = 0;
                int result;
                while (n < 100)
                {
                    if (q.TryDequeue(out result))
                    {
                        Console.WriteLine(result);
                        n++;
                    }
                    Thread.Sleep(100);
                }
            });

            // wait for all thread to be finished
            Task.WaitAll(tEnq, tDeq);
        }

        private static void testStack()
        {
            // LIFO
            Stack<double> s = new Stack<double>();
            s.Push(10.5);
            s.Push(3.54);
            s.Push(4.22);

            double val = s.Pop(); //4.22
            Console.WriteLine(val);
        }

        private static void testQueue()
        {
            // FIFO
            Queue<int> q = new Queue<int>();
            q.Enqueue(120);
            q.Enqueue(130);
            q.Enqueue(150);

            int next = q.Dequeue(); // 120
            Console.WriteLine(next);
            next = q.Dequeue(); // 130
            Console.WriteLine(next);
        }

        private static void testSortedTest()
        {
            // dynamic array: automatic expand
            // sorted array
            SortedList<int, string> list = new SortedList<int, string>();
            list.Add(1001, "Tim");
            list.Add(1020, "Ted");
            list.Add(1010, "Kim");

            string name = list[1001];

            foreach (KeyValuePair<int, string> kv in list)
            {
                Console.WriteLine("{0}:{1}", kv.Key, kv.Value);
            }
        }

        private static void testLinkedList()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("Apple");
            list.AddLast("Banana");
            list.AddLast("Lemon");

            LinkedListNode<string> node = list.Find("Banana");
            LinkedListNode<string> newNode = new LinkedListNode<string>("Grape");

            // Grape node is added after Banana node
            list.AddAfter(node, newNode);

            list.ToList().ForEach(p => Console.WriteLine(p));

            // different way
            foreach (var m in list)
            {
                Console.WriteLine(m);
            }
        }
    }
}
