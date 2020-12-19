using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMovement.getAngle.y > 0.5 || PlayerMovement.getAngle.y < -0.5)
        {
            
            transform.Rotate(PlayerMovement.getAngle.y, 0, 0,Space.Self);
        }
    }
}
