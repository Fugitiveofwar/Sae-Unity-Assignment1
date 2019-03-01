using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is responsible for converting a battle result into xp to be awarded to the player.
/// 
/// TODO:
///     Respond to battle outcome with xp calculation based on;
///         player win 
///         how strong the win was
///         stats/levels of the dancers involved
///     Award the calculated XP to the player stats
///     Raise the player level up event if needed
/// </summary>
public class XPHandler : MonoBehaviour
{
    private void OnEnable()
    {
        GameEvents.OnBattleConclude += GainXP;
    }

    private void OnDisable()
    {
        GameEvents.OnBattleConclude -= GainXP;
    }

    public void GainXP(BattleResultEventData data)
    {
        Debug.Log(data.outcome);
        Debug.Log(data.player.xp);
        Debug.Log(data.npc.xp);
        Debug.Log(data.player.level);
        // Dont use this code - makes player level 500
        // data.player.level = 500;
        int someAmount = 36;
        data.player.xp += 3 + Mathf.RoundToInt (someAmount * 0.1f); // add 1 xp to the player

        // check if player level up
        // if they leveled up run this code - it makes NPCs level up
        int XPneeded = data.player.level * 30;
        
        Debug.Log(XPneeded);
        if (data.player.xp >= XPneeded)
            {
            data.player.level += 1;
            GameEvents.PlayerLevelUp(data.player.level);
            int numPoints = 4;
            StatsGenerator.AssignUnusedPoints(data.player, numPoints);
        }
        
        // when player levels up, call this line to add points to stats
      
    }
}
