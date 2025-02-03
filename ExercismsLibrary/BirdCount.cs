namespace ExercismsLibrary;

public class BirdCount(int[] birdsPerDay)
{
    private static readonly int[] BirdsLastWeek = new int[]{0, 2, 5, 3, 7, 8, 4};

    public static int[] LastWeek() => BirdsLastWeek;
    
    public int Today() => birdsPerDay.LastOrDefault(0);
    public void IncrementTodaysCount() => birdsPerDay[6]++;
    public bool HasDayWithoutBirds() => birdsPerDay.Any(x => x == 0);
    public int CountForFirstDays(int numberOfDays) => birdsPerDay.Take(numberOfDays).Sum();
    public int BusyDays() => birdsPerDay.Count(x => x >= 5);
}
