using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear312 : MonoBehaviour
{
    public Transform target;
    public float speed = 0.6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (ButtonUp.buttonUp == 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }
}
