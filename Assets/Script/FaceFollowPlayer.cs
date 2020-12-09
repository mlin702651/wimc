using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceFollowPlayer : MonoBehaviour
{
    public Transform player = null;
    public float rotSpeed = 0.6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LateUpdate()
    {
        Vector3 TargetDir = player.position - transform.position;
        TargetDir.y = 0.0f;//繞y旋轉
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(TargetDir), Time.time * rotSpeed);
    }
}
