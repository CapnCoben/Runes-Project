using System.IO;
using UnityEngine;
using TMPro;

public class LoadSavedData : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    private RuneManager instance;
    // Start is called before the first frame update
    private void OnApplicationQuit()
    {
        SaveData data = new SaveData();
        data.highscore = GameManage.instance.highScore.ToString();
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath + "/SaveData.json", json);
        PlayerPrefs.SetString("HighScore", "True");
    }

    private void Awake()
    {
        if(File.Exists(Application.dataPath + "/SaveData.json"))
        {
          string json = File.ReadAllText(Application.dataPath + "/SaveData.json");
          SaveData data = JsonUtility.FromJson<SaveData>(json);
            text.text = data.highscore;
        }
        
    }

}
