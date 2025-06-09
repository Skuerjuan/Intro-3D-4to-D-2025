using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitNSeconds : MonoBehaviour
{
    public float timeToWait;
    float timeElapsed;
    public Transform cuboTR;
    void Start()
    {
        //InvokeRepeating(nameof(ElevateCube), 0, timeToWait);
        StartCoroutine(WaitUntilElevate());
    }

    void Update()
    {
        //if(timeElapsed >= timeToWait)
        //{
        //    Debug.Log("tiempo cumplido");
        //    ElevateCube();
        //    timeElapsed = 0;
        //}
        //else
        //{
        //    Debug.Log(timeElapsed += Time.deltaTime);
        //}
    }

    IEnumerator WaitUntilElevate()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToWait);
            ElevateCube();
        }
    }

    void ElevateCube()
    {
        cuboTR.position += Vector3.up * 2;
    }
}
