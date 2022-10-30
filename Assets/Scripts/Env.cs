using System.Collections;
using System.Collections.Generic;

public class Env 
{

    public static string playerName;
    public static int bestScore;
    public static List<HighScoreEntry> bestScores = new List<HighScoreEntry>(10);
    public static bool tipShownOnce = false;
}
