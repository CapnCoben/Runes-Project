using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    public float swingSpeed;
    [SerializeField] private Vector3 swing;


    // Update is called once per frame
    void Update()
    {
        Swinging();
    }

    private void Swinging()
    {
       
        transform.eulerAngles = new Vector3(0, 0, Mathf.Sin(Time.time) * 45);
        //transform.Rotate(swing * swingSpeed * Time.deltaTime);
    }
}
