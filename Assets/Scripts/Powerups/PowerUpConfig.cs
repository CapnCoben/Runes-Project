using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MusicalRunes;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New PowerUp Config", menuName = "Configs/Power Up" )]
public class PowerUpConfig: ScriptableObject
{
    public PowerUpType powerUpType;
    
    public Sprite icon;
    public bool Upgradable;

    public string powerUpName => Localization.currentLocalizationTable[powerUpNameID];
    public string description => Localization.currentLocalizationTable[descriptionID];
    public string powerUpNameID;
    public string descriptionID;


}
