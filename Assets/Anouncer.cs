using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anouncer : MonoBehaviour
{
    [SerializeField] [Range(0,2)] private float bounceAmplitude = .01f;
    [SerializeField] [Range(-2,2)] private float bounceFrequency = .01f;

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.one + Vector3.one * Mathf.Sin(Time.time * bounceFrequency) * bounceAmplitude;
    }
}
