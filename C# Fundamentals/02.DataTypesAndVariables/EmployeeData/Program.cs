namespace EmployeeData
{
    using System;
    using System.Text;
    public class Program
    {
        public static void Main()
        {
            string firstName = "Gosho";
            string lastName = "Georgiev";
            int age = 20;
            bool isFemale = false;
            long personalId = 8306112507;
            long uniqueNumber = 27560000;

            StringBuilder info = new StringBuilder();
            info.Append(string.Format("First name: {0}", firstName));
            info.AppendLine();
            info.Append(string.Format("Last name: {0}", lastName));
            info.AppendLine();
            info.Append(string.Format("Age: {0}", age));
            info.AppendLine();
            info.Append(string.Format("Female: {0}", isFemale));
            info.AppendLine();
            info.Append(string.Format("Personal ID: {0}", personalId));
            info.AppendLine();
            info.Append(string.Format("Unique number: {0}", uniqueNumber));

            Console.WriteLine(info.ToString());
        }
    }
}
