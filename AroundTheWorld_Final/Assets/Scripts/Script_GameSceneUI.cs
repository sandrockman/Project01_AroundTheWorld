using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Script_GameSceneUI : MonoBehaviour 
{
    public Text score;
    public Text gameText;
    public InputField nameInput;
    public Button nameSubmit;

	// Initialize the game interface.
	void Start () 
    {
        score.text = "Score: 0";
        gameText.text = "";
        nameInput.enabled = false;
        nameSubmit.enabled = false;
	}
	
	// Update the player score so long as the player is alive.
	void Update () 
    {
        while (GameObject.FindGameObjectWithTag("Player"))
        {
            Script_Director.score += (int)Time.timeSinceLevelLoad * 5;
            score.text = "Score: " + Script_Director.score.ToString();
        }
	}
}
