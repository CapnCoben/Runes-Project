using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JackiScript : MonoBehaviour
{

    [SerializeField] int[] Numbers;
    // Start is called before the first frame update
    void Start()
    {
        rune(Numbers);
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void rune(int[] numbers)
    {
        int biggestNum = 0;
        int biggestNumIndex = 0;
        for (int i = 0; i < Numbers.Length; i++)
        {
            if (numbers[i] > biggestNum)
            {
                biggestNum = numbers[i];
            }
        }
        Debug.Log(biggestNum);

    }
}
//    void rune(int[] Rune)​
//    {
//        int biggestNumber = 0;
//       int biggestNumberindex = 0;  
//      for (int i = 0; i<Rune.Length; i++)
//        {
//            if (Rune[i]> biggestNumber)
//            {
//                biggestNumber = Rune[i];
//                biggestNumberindex = i;
//            }
   
//         }
//}
//        Debug.Log("biggestnumber: " + biggestNumber);
//Debug.Log("index: " + biggestNumberindex);
//}
