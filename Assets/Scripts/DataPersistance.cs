using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataPersistance : MonoBehaviour
{
    public static DataPersistance inst;
    public PlayerData playerData;
    
    string json;
    string saveString;
    public string currentPLayerName;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        inst = this;
        Load();
    }


    public void Save(string name,int score)
    {
        playerData.score = score;
        playerData.playerName = name;
        json = JsonUtility.ToJson(playerData);
        File.WriteAllText(Application.dataPath + "/savefile.txt", json);
        Debug.Log("saved");
    }
    void Load()
    {
        string loadPlayerData = File.ReadAllText(Application.dataPath + "/savefile.txt");
        playerData = JsonUtility.FromJson<PlayerData>(loadPlayerData);
        Debug.Log(playerData.score + " " + playerData.playerName);
        
    }
}
