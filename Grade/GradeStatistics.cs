namespace Grade
{
    public class GradeStatistics
    {

        public GradeStatistics()
        {
            highestGrade = 0;
            lowestGrade = float.MaxValue;
        }
       public float averageGrade;
       public float highestGrade;
       public float lowestGrade;

        public string LetterGrade
        {
            get
            {
                string result;
                if(averageGrade >= 90)
                {
                    result = "A";
                }
                else if(averageGrade >= 80)
                {
                    result = "B";
                }
                else if(averageGrade >= 70)
                {
                    result = "C";
                }
                else if(averageGrade >= 60)
                {
                    result = "D";
                }
                
                else
                {
                    result = "E";
                }
                return result;
            }
        }
    }
}