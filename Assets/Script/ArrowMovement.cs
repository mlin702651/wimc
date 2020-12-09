using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    public float speed=0.3f;
    public Transform target1;
    public Transform target2;
    bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (flag == false)
        {            
            transform.position = Vector3.MoveTowards(transform.position, target1.position, step);
            if(transform.position== target1.position) flag = true;
        }
        else
        {            
            transform.position = Vector3.MoveTowards(transform.position, target2.position, step);
            if (transform.position == target2.position) flag = false;      
        }

        


    }
}
