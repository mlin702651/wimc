﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clearence311 : MonoBehaviour
{
    public static bool clearence = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            clearence = true;
            
        }
    }

}
