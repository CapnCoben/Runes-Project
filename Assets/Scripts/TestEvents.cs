using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class TestEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent myEvent;
    [SerializeField] private TextMeshProUGUI coins;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            myEvent.Invoke();
            Debug.Log("Invoked");
        }
    }

    public void Clicking(int power)
    {
        coins.text += power.ToString();
       
    }
}
