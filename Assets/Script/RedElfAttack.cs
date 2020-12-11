using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedElfAttack : MonoBehaviour
{
    Ray[] ray = new Ray[17];
    public float range = 5.0f;
    public static bool hitPlayer = false;
    int count = 3000;
    public Transform player = null;
    public float rotSpeed = 0.6f;

    List<ParticleCollisionEvent> collisionEvent;
    
    public ParticleSystem flash;
    public ParticleSystem main;
    public ParticleSystem shoot;

    // Start is called before the first frame update
    void Start()
    {
        collisionEvent = new List<ParticleCollisionEvent>();
        flash.Stop();
        shoot.Stop();
       
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 TargetDir = player.position - transform.position;
        TargetDir.y = 0.0f;//繞y旋轉
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(TargetDir), Time.time * rotSpeed);
    }

    void FixedUpdate()
    {

        ray[0] = new Ray(transform.position, transform.forward * range);
        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.forward * range, Color.red);

        //
        for (int newAngle = 5, i = 1; newAngle <= 30; newAngle += 5, i += 2)
        {
            Vector3 leftRayRotation = Quaternion.AngleAxis(-newAngle, transform.up) * transform.forward;
            ray[i] = new Ray(transform.position, leftRayRotation * range);
            Debug.DrawRay(transform.position, leftRayRotation * range, Color.red);
            Vector3 rightRayRotation = Quaternion.AngleAxis(newAngle, transform.up) * transform.forward;
            ray[i + 1] = new Ray(transform.position, rightRayRotation * range);
            Debug.DrawRay(transform.position, rightRayRotation * range, Color.red);
        }

        
        //碰到東西之後的行為
        for (int i = 0; i < 17; i++)
        {
            count++;
            if (Physics.Raycast(ray[i], out hit, range))
            {
                if (hit.collider.name == "player")
                {
                    print("hiiiiiiiii");
                    if (count > 3000)
                    {
                        //Debug.Log("HIT");                                          
                        main.Emit(1);
                        flash.Play();
                        main.Play();
                        shoot.Play();
                        count = 0;
                        
                    }                  
                }
                
            }
            if (count > 10000) count = 5000;
        }
        //Debug.Log(count);
    }
    

}
