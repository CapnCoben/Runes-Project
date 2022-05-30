using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHint : PowerUp
{
    [SerializeField] private Image[] btnImgs;

    [SerializeField] private RuneManager rmScript;

    public override void OnPowerUpClick()
    {
        

        if(isAvailable == true)
        {
          base.OnPowerUpClick();
          btnImgs[rmScript.currentIndex].color = Color.green;
        }
       
    }
}
