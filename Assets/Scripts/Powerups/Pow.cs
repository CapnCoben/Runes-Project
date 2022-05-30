using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MusicalRunes;
public class Pow : MonoBehaviour
{
    [SerializeField] private PowerUpConfig powerUp;

    private void Start()
    {
        if(powerUp.powerUpType == PowerUpType.Hint)
        {
            Debug.Log("True");
        }
        Debug.Log(powerUp.description);
    }
}
