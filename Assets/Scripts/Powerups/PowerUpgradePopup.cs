using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MusicalRunes
{
    public class PowerUpgradePopup : MonoBehaviour
    {
        public Image btnImage;
        public Button btn;
        public PowerUpConfig powerUpConfig;
        // Start is called before the first frame update
        void Start()
        {
            Setup(powerUpConfig);
        }
      

        public void Setup(PowerUpConfig powerUpConfig)
        {
            btnImage.sprite = powerUpConfig.icon;
            gameObject.name = powerUpConfig.powerUpName;
            btn.interactable = powerUpConfig.Upgradable;
        }
    }

}

