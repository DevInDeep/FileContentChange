using System;
using System.Collections;
using System.Collections.Generic;

namespace FileChecksum
{
    public class ConsoleReader : IEnumerable<string>
    {
        private Func<string, bool> predicate = (_) => false;
        private ConsoleReader() { }
        private ConsoleReader(Func<string, bool> predicate) => this.predicate = predicate;

        public static ConsoleReader Create() => new ConsoleReader();
        public static ConsoleReader ReadUntil(Func<string, bool> predicate) => new ConsoleReader(predicate);

        public IEnumerator<string> GetEnumerator()
        {
            while(true)
            {
                var userInput = Console.ReadLine();
                if (predicate(userInput)) break;
                yield return userInput;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
