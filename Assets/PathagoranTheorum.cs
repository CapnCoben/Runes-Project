using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathagoranTheorum : MonoBehaviour
{
    // Start is called before the first frame update
    public float aNum;
    public float bNum;
    public float CNum;
    private void Start()
    {
        float aSquared = Mathf.Pow(aNum,2);
        float bSquared = Mathf.Pow(bNum,2);

        CNum = Mathf.Sqrt(aSquared + bSquared);

        Debug.Log(CNum);
    }

}
