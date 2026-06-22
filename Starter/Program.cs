
int examAssignments = 5;


string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];
// test comment
string currentStudentLetterGrade = "";


// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\t\tExtra Credit\n");


//this foreach loop iterates through each student name in the studentNames array, calculates their exam score, overall grade, letter grade, extra credit, and more points, and then prints the results in a formatted manner.
foreach (string name in studentNames)
{
    string currentStudent = name;
     decimal studentExamScores = 0;
     //string studentExtraCredit = "0";
     decimal studentExtraCredit = 0;
    //decimal studentsMorePoints = 0;
     
     
     
   

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;
    int gradedAssignments = 0;
    //string pts = " (0 pts)";
    //string ptsl = "  pts";
    //string studentsAdditionalPoints = "";
    decimal studentExamScore = 0;
    decimal studentsMorePoints = 0;
    
    

    
//if (studentExamScores <= examAssignments)
       // studentExamScores += 0;

    

    //if (studentExtraCredit == "0" )
       // studentExtraCredit = studentExtraCredit + pts;

   
   

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

       // if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;
       // else
            sumAssignmentScores += score / 10;

            if (gradedAssignments <= (gradedAssignments - examAssignments))
            sumAssignmentScores += score;

            
        if (gradedAssignments <= examAssignments)
            studentExamScores += score;

            if (gradedAssignments > examAssignments)
            studentExtraCredit += score;

          // if (gradedAssignments > examAssignments)
            //studentExtraCredit = (studentExtraCredit/10)/examAssignments;
            
           // if (studentsMorePoints == studentExtraCredit/10)
           // studentExtraCredit =  studentExtraCredit + studentsMorePoints/examAssignments;

           if (gradedAssignments > examAssignments)
            studentsMorePoints += (decimal)score/10;

            //if (studentsAdditionalPoints == "studentsMorePoints")

        //studentsAdditionalPoints = studentsMorePoints + ptsl;
 
        
            
          
         


        



       
    }

   

    studentExamScore = (decimal)(studentExamScores) / examAssignments;

    currentStudentGrade = (decimal)(studentExamScores + (studentExtraCredit/10)) / examAssignments;

    //currentStudentGrade = (decimal)(studentExamScores + studentExtraCredit/10)/ examAssignments;

   // studentsMorePoints = (decimal)(studentsMorePoints) /  examAssignments;


     studentExtraCredit = (decimal)(studentExtraCredit) / (gradedAssignments - examAssignments);

     studentsMorePoints = (decimal)(studentsMorePoints) /  examAssignments;

    

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

        

        
         
            

        
        

    
    Console.WriteLine($"{currentStudent}\t\t{studentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t\t{studentExtraCredit} ({studentsMorePoints} pts)");
    
}

Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
