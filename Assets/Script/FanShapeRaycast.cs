using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanShapeRaycast : MonoBehaviour
{
   
    Ray[] ray=new Ray[17];
 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        ray[0] = new Ray (transform.position, transform.forward*10);
        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.forward * 10, Color.red);

        //
        for(int newAngle = 5, i=1; newAngle <= 30; newAngle += 5,i+=2)
        {
            Vector3 leftRayRotation = Quaternion.AngleAxis(-newAngle, transform.up) * transform.forward;
            ray[i] = new Ray(transform.position, leftRayRotation * 10);
            Debug.DrawRay(transform.position, leftRayRotation * 10, Color.red);
            Vector3 rightRayRotation = Quaternion.AngleAxis(newAngle, transform.up) * transform.forward;
            ray[i+1] = new Ray(transform.position, rightRayRotation * 10);
            Debug.DrawRay(transform.position, rightRayRotation * 10, Color.red);
        }


        //
        for(int i = 0; i < 17; i++)
        {
            if (Physics.Raycast(ray[i], out hit, 10))
            {
                Debug.Log("碰撞物件: " + hit.collider.name);
                Debug.Log(i);
            }

        }
        


    }
}
