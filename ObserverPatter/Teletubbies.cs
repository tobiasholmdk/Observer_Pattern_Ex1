using System;

namespace ObserverPatter
{
    public class Teletubbies : IObserver
    {    
        private string _name;
        private BigTelephone _subject;
        public Teletubbies(BigTelephone Subject, string name)
        {
            this._subject = Subject;
            this._name = name;
        }
        public void update()
        {
            Console.WriteLine(_subject.SubjectState);
        }
    }
}