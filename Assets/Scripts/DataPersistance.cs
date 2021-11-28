using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistance : MonoBehaviour
{
    public static DataPersistance inst;
    [SerializeField] PlayerData playerData;

    
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        inst = this;
    }
    public void SavePlayerName(string name)
    {
        playerData.playerName = name;
    }
    public void SaveScore(int level)
    {
        playerData.level = level;
    }

    private void OnDestroy()
    {
        //SaveData
    }
}
