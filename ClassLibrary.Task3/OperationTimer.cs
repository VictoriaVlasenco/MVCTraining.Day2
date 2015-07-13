using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Task3
{
    sealed class OperationTimer : IDisposable
    {
        private long startTime;
        private int collectionCount;
        private string text;

        public OperationTimer(string text)
        {
            this.text = text;
            collectionCount = GC.CollectionCount(0);
            startTime = Stopwatch.GetTimestamp();
        }

        public void Dispose()
        {
            //var a = Stopwatch.GetTimestamp() - startTime/(Double) Stopwatch.Frequency;
            Console.WriteLine("{0,6:####.000} mseconds (GCs: {1,2}) {2}", 
                (Stopwatch.GetTimestamp() - startTime )/ (Double)Stopwatch.Frequency * 1000, 
                GC.CollectionCount(0) - collectionCount, text);
        }

        private static void PrepareForOperation()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
