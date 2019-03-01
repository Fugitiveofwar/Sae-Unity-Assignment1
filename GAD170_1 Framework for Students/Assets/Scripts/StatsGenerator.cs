using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  A <see langword="static"/> class with methods (functions) for initialising or randomising the stats class.
///  
/// TODO:
///     Initialise a stats instance with generated starting stats
///     Handle the assignment of extra points or xp into an existing stats of a character
///         - this is expected to be used by NPCs leveling up to match the player.
/// </summary>
public static class StatsGenerator
{
    public static void InitialStats(Stats stats)
    {
        //all character start at level 1
        stats.level = 1;
        
        //start at 0 experience points
        stats.xp = 0;
        //for you todo - set the stats

        int PRstats = Random.Range(1, 5);
        stats.style = Random.Range(1, 5);
        stats.rhythm = Random.Range(1, 5);
        

        int NPCRStats = Random.Range(1, 5);
        stats.style = Random.Range(1, 5);
        stats.rhythm = Random.Range(1, 5);
       


    }

    public static void AssignUnusedPoints(Stats stats, int points)
    {
        Debug.Log(stats.style += points);
        Debug.Log(stats.rhythm += points);
        Debug.Log(stats.luck += points );
        
        
    }
}
