using System;

namespace Concept.Tuple.Lesson0 {
    class Main {
        private delegate void ShowDelegate();
        private ShowDelegate ShowAction { get; set; }
        public void Run() {
            ShowAction = HelloShow;
            ShowAction();
        }
        private void HelloShow() => Console.WriteLine("Hello world !!");
    }
}
