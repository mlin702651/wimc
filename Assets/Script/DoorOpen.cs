using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public float speed = 0.3f;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (Clear311.clear)
        {
            
            
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            
        }
    }
}
