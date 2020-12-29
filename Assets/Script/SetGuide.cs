using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGuide : MonoBehaviour
{
  
    void OnTriggerEnter(Collider col)
    {
        gameObject.SetActive(false);
        
    }
}
