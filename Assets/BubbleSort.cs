using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{
    [SerializeField] private int[] bubble;
    [SerializeField] private int size;

    // Start is called before the first frame update
    void Start()
    {
        bubble = new int[Random.Range(1, 20)];
        RandomizeArray();
        BubbleSorting(size);
    }

    private void BubbleSorting(int size)
    {
        for(int num = 0; num < size; num ++)
        {
            for(int i = 0; i <size - num; i++)
            {
                if(bubble[i] > bubble[i +1])
                {
                    int currentNum = bubble[i]; //Got this
                    bubble[i] = bubble[i + 1];  // part off 
                    bubble[i + 1] = currentNum; // the internet 
                }

            }    
        }
    }

    // Update is called once per frame


    private void RandomizeArray()
    {
        for (int i = 0; i < bubble.Length; i ++)
        {
            bubble[i] = Random.Range(1, 20);

        }

    }
}
