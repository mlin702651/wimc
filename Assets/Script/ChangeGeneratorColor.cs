using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGeneratorColor : MonoBehaviour
{
    [SerializeField]
    private Material mater;
    int count = 0;
    void Update()
    {
        Debug.Log(count);
        count++;
        if (count > 50)
        {
            mater.color = Color.cyan;
            count = 0;
        }
        
            
        
    }
}
