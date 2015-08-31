using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Script_Director : MonoBehaviour 
{
    public static Script_Director director = null;
    public static int score = 0;

    //public Text gameScore;
    //public Text gameText;

    public Script_PlayerClass[] highScores;

    int[] presetScores = new int[10];
    string[] presetNames = {"Overclock", "Victor", "Mike", "Todd", "Darrick", "Scott", "Amelia", "Hayley", "Tiffany", "Eric"};

    public Script_PlayerClass[] HighScores
    {
        get
        {
            return highScores;
        }
    }

    // Creates the director as a singleton present in all scenes
    void Awake()
    {
        if (director == null)
        {
            director = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

	// Initialize the High Score table at start
	void Start () 
    {
        highScores = new Script_PlayerClass[10];
        if (!File.Exists(Application.persistentDataPath + "/HighScores.dat"))
        {
            int presetScore = 10000;
            for (int i = 0; i < 10; i++)
            {
                presetScores[i] = presetScore;
                presetScore -= 1000;
            }
            CreateHighScores(presetNames, presetScores);
        }
        else
            LoadHighScores();
        ResetScore();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Application.loadedLevel == 1)
        {
            if(!GameObject.FindGameObjectWithTag("Player"))
            {
                //EndGame();
            }
        }
	}

    public static void ResetScore()
    {
        score = 0;
    }

    void GameOver()
    {
        // gameText.text = "GAME OVER";
    }

    void InputHighScore()
    {
        
    }

    void EndGame()
    {
        // gameText.text = "Continue? Press space!\nQuit? Press esc!";
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ResetScore();
            Application.LoadLevel(1);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel(0);
        }
    }

    void CreateHighScores(string[] initiatedNames, int[] initiatedScores)
    {
        for (int i = 0; i < 10; i++)
        {
            highScores[i] = new Script_PlayerClass();
            highScores[i].PlayerName = initiatedNames[i];
            highScores[i].Score = initiatedScores[i];
        }
        BinaryFormatter oFormatter = new BinaryFormatter();
        FileStream oFile = File.Create(Application.persistentDataPath + "/HighScores.dat");
        HighScoreData oData = new HighScoreData();
        oData.registeredHighScores = highScores;
        oFormatter.Serialize(oFile, oData);
        oFile.Close();
    }

    public void SaveHighScores()
    {
        BinaryFormatter oFormatter = new BinaryFormatter();
        FileStream oFile = File.Create(Application.persistentDataPath + "/HighScores.dat");
        HighScoreData oData = new HighScoreData();
        oData.registeredHighScores = highScores;
        oFormatter.Serialize(oFile, oData);
        oFile.Close();
    }

    public void LoadHighScores()
    {
        BinaryFormatter oFormatter = new BinaryFormatter();
        FileStream oFile = File.Open(Application.persistentDataPath + "/HighScores.dat", FileMode.Open);
        HighScoreData data = oFormatter.Deserialize(oFile) as HighScoreData;
        highScores = data.registeredHighScores;
        oFile.Close();
    }
}

[Serializable]
class HighScoreData
{
    public Script_PlayerClass[] registeredHighScores;
}