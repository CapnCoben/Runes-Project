using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class PowerUp : MonoBehaviour
{
    [SerializeField] private int coolDownDuration = 3;

    [SerializeField] private Image powerUpBtn;

    [SerializeField] private float currentCooldown;

    protected bool isAvailable => currentCooldown <= 0;

    private void Update()
    {
        if (currentCooldown >= 0)
        {
            currentCooldown -= Time.deltaTime;
            powerUpBtn.fillAmount = 1 - currentCooldown / coolDownDuration;
        }
    }

    public virtual void OnPowerUpClick()
    {
        if (!isAvailable) return;
        currentCooldown = coolDownDuration;
    }

}