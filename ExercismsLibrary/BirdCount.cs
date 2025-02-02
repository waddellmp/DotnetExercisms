namespace ExercismsLibrary;

public class BirdCount
{
    private readonly int[] _birdsPerDay;
    
    private static readonly int[] BirdsLastWeek = new int[]{0, 2, 5, 3, 7, 8, 4};
    
    public BirdCount(int[] birdsPerDay) => this._birdsPerDay = birdsPerDay;
    public static int[] LastWeek() => BirdsLastWeek;
    
    public int Today() => this._birdsPerDay.LastOrDefault(0);
    public void IncrementTodaysCount() => this._birdsPerDay[6]++;
    public bool HasDayWithoutBirds() => this._birdsPerDay.Any(x => x == 0);
    public int CountForFirstDays(int numberOfDays) => this._birdsPerDay.Take(numberOfDays).Sum();
    public int BusyDays() => this._birdsPerDay.Count(x => x >= 5);
}
