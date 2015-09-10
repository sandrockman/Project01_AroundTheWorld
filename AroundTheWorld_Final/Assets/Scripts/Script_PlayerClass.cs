using UnityEngine;
using System;
using System.Collections;

[Serializable]
public class Script_PlayerClass
{
    string playerName;
    int score;

    public string PlayerName
    {
        get
        {
            return playerName;
        }
        set
        {
            playerName = value;
        }
    }

    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }

    public Script_PlayerClass()
    {
        PlayerName = null;
        score = 0;
    }

    public Script_PlayerClass(string name, int gameScore)
    {
        PlayerName = name;
        score = gameScore;
    }

    public string ScoreToString()
    {
        return Convert.ToString(score);
    }
}
