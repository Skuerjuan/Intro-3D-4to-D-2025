using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecutionOrder : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("awake");
    }
    private void Start()
    {
        Debug.Log("start");
    }
    private void Update()
    {
        Debug.Log("update");
    }
    private void FixedUpdate()
    {
        Debug.Log("fixed update");
    }
    private void OnEnable()
    {
        Debug.Log("onEnable");
    }
}
