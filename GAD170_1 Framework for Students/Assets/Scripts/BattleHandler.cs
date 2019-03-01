using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Static class with method (function) to determine the outcome of a dance battle based on the player and NPC that are 
///     dancing off against each other.
///     
/// TODO:
///     Battle needs to use stats and random to determine the winner of the dance off
///       - outcome value to be a float value between 1 and negative 1. 1 being the biggest possible player win over NPC, 
///         through to -1 being the most decimating defeat of the player possible.
/// </summary>
public static class BattleHandler
{
    public static void Battle(BattleEventData data)
    {
        //This needs to be replaced with some actual battle logic, at present 
        // we just award the maximum possible win to the player
        float outcome = 1;
        // Your code between here
        data.player.luck = Random.Range(0, 7);
        data.npc.luck = Random.Range(0, 7);
        Debug.Log("Enemy Rhythm " + data.npc.rhythm);
        Debug.Log("Player Rhythm " + data.player.rhythm);
        Debug.Log("Enemy Style " + data.npc.style);
        Debug.Log("Player Style " + data.player.style);
        Debug.Log("Enemy Luck " + data.npc.luck);
        Debug.Log("Player Luck " + data.player.luck);
        int playerpower = data.player.rhythm + data.player.style + data.player.luck;

        int npcpower = data.npc.rhythm + data.npc.style + data.npc.luck;

        if (playerpower + Random.Range(0,7) <= npcpower + Random.Range(0,7))
        {
            Debug.Log("You have Lost the dance battle");
        }
        else if (playerpower + Random.Range(0,7) >= npcpower + Random.Range(0,7))
        {
            Debug.Log("You have Won the dance battle");
        }
       else
        {
            Debug.Log("Its a draw");
        }
        // Set outcome to 0 if the player lost
        // Set outcome to 1 if the player won
        
        // and here

        var results = new BattleResultEventData(data.player, data.npc, outcome);

        GameEvents.FinishedBattle(results);
    }
}
