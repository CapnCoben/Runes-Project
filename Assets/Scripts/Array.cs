using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public int[] array = new int[0];
    float currentTime = 0;
    float maxTime = 3;
    // Update is called once per frame
    private void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= maxTime)
        {
            GetLargestElement(array);
            currentTime = 0;
        }
    }
    public int GetLargestElement(int[] array)
    {
        int maxElement = array[0];
        for (int index = 1; index < array.Length; index++)
        {
            if (array[index] > maxElement)
            {
                maxElement = array[index];
            }
        }      
        
        return maxElement;
        
    }
}
