/* @author Mike Dobson & Darrick Hilburn
 * This is the script that will send the user from scene to scene
 */
using UnityEngine;
using System.Collections;

public class Script_Transition : MonoBehaviour 
{
    //Transition to Main Menu
    public void _StartUp()
    {
        Application.LoadLevel(0);
    }

	// Transition to game
    public void _StartGame()
    {
        Application.LoadLevel(1);
    }

    //Transition to help menu
    public void _HowToPlay()
    {
        Application.LoadLevel(2);
    }

    //Transition to Credits
    public void _Credits()
    {
        Application.LoadLevel(3);
    }

    //Transition to High Scores table
    public void _HighScores()
    {
        Application.LoadLevel(4);
    }

    public void _ExitGame()
    {
        Application.Quit();
    }
}
