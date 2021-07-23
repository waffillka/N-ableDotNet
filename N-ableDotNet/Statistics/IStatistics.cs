namespace N_ableDotNet.Statistics
{
    public interface IStatistics
    {
        Subject GetLowestGrade(Student student);
        double GetAverageGrade(Student student);
        Subject GetHighestGrade(Student student);
    }
}
