using UnityEngine;
using System.Collections;

/*
* This is the script that will send the user from scene to scene
* @author Mike Dobson
*/

public class Script_Transition : MonoBehaviour {

	//Transition to level 0
    public void _Level0()
    {
        Application.LoadLevel("Level0");
    }

    //Transition to Main Menu
    public void _MainMenu()
    {
        Application.LoadLevel("MainMenu");
    }

    //Transition to Credits
    public void _CreditsMenu()
    {
        Application.LoadLevel("CreditsMenu");
    }

    //Transition to Help
    public void _HelpMenu()
    {
        Application.LoadLevel("HelpMenu");
    }

    //Transition to end game
    public void _EndGame()
    {
        Application.LoadLevel("EndGame");
    }

    public void _ExitGame()
    {
        Application.Quit();
    }
}
