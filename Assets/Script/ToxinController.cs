using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToxinController : MonoBehaviour
{
    public ParticleSystem toxinGunPS;
    public ParticleSystem burstPS;
    List<ParticleCollisionEvent> collisionEvent;

 
    // Start is called before the first frame update
    void Start()
    {
        //DoEmit，0秒鐘後開始，每0.3秒一次
        InvokeRepeating("DoEmit", 0f, 0.3f);
        collisionEvent = new List<ParticleCollisionEvent>();

       

    
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnParticleCollision(GameObject other)
    {
        
        ParticlePhysicsExtensions.GetCollisionEvents(toxinGunPS, other, collisionEvent);
        
        for (int i = 0; i < collisionEvent.Count; i++)
        {
            Vector3 pos = collisionEvent[i].intersection;
            burstPS.transform.position = collisionEvent[i].intersection;
            
        }
        
        burstPS.Play();
       
    }
    void DoEmit()
    {
        
        if (PlayerMovement.pressDown == true&&PlayerMovement.toxinGunOn==true)
        {
            toxinGunPS.Emit(1);
            toxinGunPS.Play();
        }
       
    }
}
