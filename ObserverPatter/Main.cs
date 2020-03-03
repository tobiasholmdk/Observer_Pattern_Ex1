using System;

namespace ObserverPatter
{
    public class MainApp
    {
        static void Main()
        {
            // Configure Observer pattern
            BigTelephone Stortelf = new BigTelephone();
 
            Stortelf.Attach(new Teletubbies(Stortelf,"Teletub1"));
            Stortelf.Attach(new Teletubbies(Stortelf, "Teletub2"));
            Stortelf.Attach(new Teletubbies(Stortelf, "Teletub3"));
 
            // Change subject and notify observers
            
            Stortelf.SubjectState = "Time for dinner";
            Stortelf.Notify();
        }
    }
}