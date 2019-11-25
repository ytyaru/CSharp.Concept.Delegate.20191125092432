using System;

namespace Concept.Tuple.Lesson1 {
    class Main {
        private delegate int GetIntDelegate(int i=0);
        private GetIntDelegate GetIntFunc { get; set; }
        public void Run() {
            GetIntFunc = GetInt;
            Console.WriteLine($"{GetIntFunc(10)}");
        }
        private int GetInt(int i=0) { return 100; }
    }
}
