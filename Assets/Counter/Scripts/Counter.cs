using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text CounterText;

    private int count = 0;

    private void Start()
    {
        count = 0;
    }

    void UpdateCount()
    {
        CounterText.text = $"Count: {count}";
    }

    private void OnTriggerEnter(Collider other)
    {
        count++;
        UpdateCount();
    }

    private void OnTriggerExit(Collider other)
    {
        count--;
        UpdateCount();
    }
}
