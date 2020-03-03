using System;
using System.Collections.Generic;

namespace ObserverPatter
{
    public class BigTelephone : Subject
    {
        private string _subjectState;
        public string SubjectState
        {
            get { return _subjectState; }
            set { _subjectState = value; }
        }
    }
}