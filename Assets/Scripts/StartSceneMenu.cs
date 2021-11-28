using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneMenu : MonoBehaviour
{
    public InputField nameIF;
    string name;
    public Text nameTxt;
   public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    private void OnDestroy()
    {
        DataPersistance.inst.SavePlayerName(nameTxt.text);
    }
}
