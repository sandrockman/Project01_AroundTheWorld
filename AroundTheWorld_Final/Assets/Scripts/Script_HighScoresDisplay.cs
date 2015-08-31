using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Script_HighScoresDisplay : MonoBehaviour 
{
    public Text highScores;
    
    void Start()
    {
        highScores.text = "High Scores\n";
        for (int i = 0; i < 10; i++)
        {
            highScores.text += Script_Director.director.HighScores[i].PlayerName + "/t" + 
                               Script_Director.director.HighScores[i].Score + "\n";
        }
    }
}
