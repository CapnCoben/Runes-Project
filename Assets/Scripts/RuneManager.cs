using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class RuneManager : MonoBehaviour
{

    /// <summary>
    /// Attach to Game Object
    /// tell us if they clicked the right buttton
    /// </summary>
    /// 
    [SerializeField] private Button[] runeButtons;
    public int points = 10;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private float maxTimer = 3;
    private float timer;
    private bool isRuneChoosingTime = true;

    public int playerLives;

    [SerializeField] private AudioSource aSource;
    public int[] runeSequence = new[] { 0, 1, 2, 3 };
    public int currentIndex = 0;

    private void Update()
    {
        if (!isRuneChoosingTime)
        {
            return;
        }
        else
        {
            maxTimer -= Time.deltaTime;
            timer = Mathf.Max(0, timer);
        }

        if(timer <= 0)
        {
            playerLives--;
            currentIndex = 0;
            OnFail();
        }
    }
    public void OnRuneActive(int index)
    {
        isRuneChoosingTime = true;
        if (currentIndex >= runeSequence.Length)
        {
            return;
        }
        if (runeSequence[currentIndex] == index)
        {
            CorrectSelected();
        }
        else
        {
            Failed();
        }
    }

    public void Failed()
    {
        isRuneChoosingTime = false;
        currentIndex = 0;
        StartCoroutine(OnFail());
        playerLives--;
        if(playerLives == 0)
        {
            SequenceFailed();
            Debug.Log("Sequence Failed");
        }
    }

   

    IEnumerator OnFail()
    {
        foreach (var rune in runeButtons)
        {
            rune.enabled = false;
        }
        text.text = "FAILED!";
        yield return new WaitForSeconds(1);
        text.text = "3!";
        yield return new WaitForSeconds(1);
        text.text = "2!";
        yield return new WaitForSeconds(1);
        text.text = "1!";
        yield return new WaitForSeconds(1);
        text.text = "Go!";
        foreach (var rune in runeButtons)
        {
            rune.enabled = true;
        }
    }

    public void CorrectSelected()
    {
        currentIndex++;
        aSource.Play();
        Debug.Log("Correct");
        GameManage.instance.AddScore(points);

       
        if (currentIndex == runeSequence.Length)
        {
            SequenceEnded();
            Debug.Log("Sequence Ended");
        }
     
        
        
        
        
    }

    public void SequenceEnded()
    {
       // gmScript.highScore++;

    }
    private void SequenceFailed()
    {
        throw new NotImplementedException();
    }
}
