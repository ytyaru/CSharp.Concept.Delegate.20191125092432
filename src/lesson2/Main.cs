using System;

namespace Concept.Tuple.Lesson2 {
    class Main {
//        private delegate void ShowDelegate();
//        private ShowDelegate ShowAction { get; set; }
        private Action ShowAction { get; set; }
        private Action<string> ShowMessageAction { get; set; }

        public void Run() {
            ShowAction = HelloShow;
            ShowMessageAction = HelloShowMessage;
            ShowAction();
            ShowMessageAction("Lesson 2.");
        }
        private void HelloShow() => Console.WriteLine("Hello world !!");
        private void HelloShowMessage(string message) => Console.WriteLine($"Hello world !! {message}");
    }
}
