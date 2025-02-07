namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject()
            {
                SubjectId = 1,
                SubjectName="Programming"
            };
            Console.WriteLine("Enter the exam type:");
            string Type=Console.ReadLine();
            subject.CreateExam(Type);
            Console.Clear();
            subject.exam.ShowExam();
        }
    }
}
