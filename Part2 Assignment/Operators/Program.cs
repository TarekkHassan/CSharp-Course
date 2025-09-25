using System;

namespace EmployeeEqualityApp
{
    class Worker
    {
        public int Id { get; set; }

        public static bool operator ==(Worker a, Worker b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;
            return a.Id == b.Id;
        }

        public static bool operator !=(Worker a, Worker b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            var other = obj as Worker;
            return other != null && this.Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }

    class Program3
    {
        static void Main()
        {
            var a = new Worker { Id = 99 };
            var b = new Worker { Id = 99 };

            Console.WriteLine(a == b ? "Same worker" : "Different workers");
            Console.ReadLine();
        }
    }
}
