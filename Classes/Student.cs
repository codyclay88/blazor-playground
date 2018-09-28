using System;

namespace Classes
{
    public class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Status { get; private set; }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Status = "waiting";
        }

        public void SetStatus(string newStatus)
        {
            Status = newStatus;
        }
    }
}
