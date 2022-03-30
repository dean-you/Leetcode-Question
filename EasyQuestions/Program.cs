using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class Program
    {
        delegate void Printer();
        public static Semaphore threadPool = new Semaphore(5, 5);
        static async Task Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Thread threadObject = new Thread(new ThreadStart(PerformSomeWork));
            //    threadObject.Name = "Thread Name: " + i;
            //    threadObject.Start();
            //}
            //Console.ReadLine();

            var t = SomethingUseful(new int[] { 1,2,4,3,2,4});
        }

        public static IEnumerable<T> SomethingUseful<T>(IEnumerable<T> sources)
        {
            var set = new HashSet<T>();
            foreach (var item in sources)
            {
                if (set.Add(item))
                    yield return item;
            }
        }

        private static void PerformSomeWork()
        {
            threadPool.WaitOne();
            Console.WriteLine("Thread {0} is inside the critical section...", Thread.CurrentThread.Name);
            Thread.Sleep(10000);
            threadPool.Release();
        }

        private static async Task<int> DownloadDocsMainPageAsync()
        {
            Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: About to start downloading.");

            var client = new HttpClient();
            byte[] content = await client.GetByteArrayAsync("https://docs.microsoft.com/en-us/");

            Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: Finished downloading.");
            return content.Length;
        }
    }
}
