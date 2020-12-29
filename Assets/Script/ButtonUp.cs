using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUp : MonoBehaviour
{
    
    
    public GameObject elf;
    float moveTo = 0.1f;
    public static int buttonUp = 0;


    void OnTriggerExit(Collider other)
    {       
        if (other.tag == elf.tag)
        {
            transform.position = transform.position+new Vector3(0, moveTo, 0);
        }
        
        buttonUp += 1;
    }

}
