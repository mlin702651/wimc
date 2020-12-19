using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDetermination : MonoBehaviour
{
    List<ParticleSystem.Particle> enter = new List<ParticleSystem.Particle>();
    int numEnter = 0;
    public static bool elfHit=false;
    int count = 200;
    void OnParticleTrigger()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();
        numEnter = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        //Debug.Log("count"+count);
        if (numEnter > 1&&count>200)
        {      
                       
            elfHit = true;
            count = 0;
        }
        if (count > 1000) count = 200;

    }
}
