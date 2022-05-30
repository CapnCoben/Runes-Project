using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Replay : PowerUp
{
    [SerializeField] private Image[] btnImage;
    [SerializeField] private RuneManager RMScript;
    [SerializeField] private int minIndex = 0;
    // Start is called before the first frame update

    public override void OnPowerUpClick()
    {
        if(isAvailable &&RMScript.currentIndex > minIndex)
        {
            base.OnPowerUpClick();
            RMScript.currentIndex = 0;

            foreach (Image image in btnImage)
            {
                image.color = Color.white;
            }
        }

    }
}
