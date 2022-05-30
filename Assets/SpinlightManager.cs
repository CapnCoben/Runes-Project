using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinlightManager : MonoBehaviour
{
    [SerializeField] private GameObject[] spinLight;


    private void Start()
    {
        StartCoroutine(Flashlights());
    }
    IEnumerator Flashlights()
    {
        while(true)
        {
            yield return new WaitForSeconds(.5f);
            foreach(GameObject go in spinLight)
            {
              go.SetActive(!go.activeSelf);
            }
        }
    }
}
