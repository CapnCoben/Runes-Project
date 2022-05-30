using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadraticEquation : MonoBehaviour
{
    public float a;
    public float b;
    public float c;
    public float x1;
    public float x2;

    // Start is called before the first frame update
    void Start()
    {
        float squareRoot = Mathf.Sqrt(Mathf.Pow(b, 2) - (4*(a * c)));
        x1 = ((-b + squareRoot) / (2 * a));
        x2 = ((-b - squareRoot) / (2 * a));
    }
}
