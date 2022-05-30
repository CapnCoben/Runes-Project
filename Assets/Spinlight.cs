using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinlight : MonoBehaviour
{
    [SerializeField] [Range(-10,10)] float spinVel;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, spinVel * Time.deltaTime) ;
    }
}
