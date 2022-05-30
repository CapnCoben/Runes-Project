using System.IO;
using UnityEngine;
using TMPro;

public class GameManage : MonoBehaviour
{
    public static GameManage instance;

    [SerializeField] private TextMeshProUGUI highscoreText;
    [SerializeField] private TextMeshProUGUI currentScoreText;

    private int currentScore;
    public int highScore;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("multiple singleton instances");
        }
        if(File.Exists(Application.dataPath + "/SaveData.json"))
        {
            string json = File.ReadAllText(Application.dataPath + "/SaveData.json");
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            highScore = int.Parse(data.highscore);
            highscoreText.text = highScore.ToString();
        }        
    }

    public void AddScore(int points)
    {
        currentScore += points; 
        currentScoreText.text = currentScore.ToString();

        if(currentScore > highScore)
        {
            highScore = currentScore;
            highscoreText.text = highScore.ToString();
        }
    }


    private void OnApplicationQuit()
    {
       if(currentScore >= highScore)
        {
            SaveData data = new SaveData();
            data.highscore = currentScore.ToString();
            string json = JsonUtility.ToJson(data);
            File.WriteAllText(Application.dataPath + "/SaveData.json", json);
        }
    }

}
