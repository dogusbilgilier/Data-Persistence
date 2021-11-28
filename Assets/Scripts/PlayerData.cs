using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PlayerData 
{
    public string playerName;
    public int score;

    PlayerData(string playerName,int score)
    {
        playerName = this.playerName;
        score = this.score;
    }
}
