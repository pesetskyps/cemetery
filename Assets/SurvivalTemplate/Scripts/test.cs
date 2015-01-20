﻿using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

    void Start()
    {
        print("Starting " + Time.time);
        StartCoroutine(WaitAndPrint(2.0F));
        print("Before WaitAndPrint Finishes " + Time.time);
    }
    IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        print("WaitAndPrint " + Time.time);
    }
}
