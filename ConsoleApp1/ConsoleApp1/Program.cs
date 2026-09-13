Console.WriteLine("Hello !");
string status;
Console.WriteLine("enter your name: ");
string name = Console.ReadLine();

//Console.WriteLine($"Name is {name}");
decimal exam_score;
Console.WriteLine("enter your Exam score: ");
exam_score = decimal.Parse(Console.ReadLine());
while(exam_score > 100 || 0 > exam_score)
{
    Console.WriteLine("Invalid Input: Values must be between 0 and 100.");
    Console.WriteLine("enter your Exam score: ");
    exam_score = decimal.Parse(Console.ReadLine());

}
//Console.WriteLine($"exam_score is {exam_score}");


Console.WriteLine("enter your Attendance rate: ");
decimal attendance_rate = decimal.Parse(Console.ReadLine());

//Console.WriteLine($"attendance_rate is {attendance_rate}");
if (attendance_rate < 75)
{
    status = "Failed - Reason: Low Attendance Rate";
}
else
{
   
     if (exam_score >= 90 && exam_score <= 100)
    {
        status = "A (Excellent)";
    }
    else if (exam_score >= 80 && exam_score <= 89)
    {
        status = " B (Very Good)";
    }
    else if (exam_score >= 70 && exam_score <= 79)
    {
        status = "C (Good)";
    }
    else if (exam_score >= 50 && exam_score <= 69)
    {
        status = "D (Pass)";
    }
    else
    {
        status = "F (Fail)";
    }
}


Console.WriteLine(status);
