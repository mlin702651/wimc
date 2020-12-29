using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorColorChange : MonoBehaviour
{
    private Material _mat;

    public Color lv0;
    public Color lv1;
    public Color lv2;
    float timer = 0;


    void Start()
    {

        Renderer nRend = GetComponent<Renderer>();
        _mat = nRend.material;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (ToxinController.countR == 0)
        {
            _mat.SetColor("_BaseColor", lv0);
        }
        else if (ToxinController.countR == 1)
        {
            _mat.SetColor("_BaseColor", lv1);
            timer = 0;
        }
        else if (ToxinController.countR == 2)
        {
            _mat.SetColor("_BaseColor", lv2);
            ToxinController.waitR = true;

            Debug.Log(timer);
            if (timer > 1)
            {
                ToxinController.waitR = false;
                ToxinController.countR = 0;
                timer = 0;
            }
        }
    }

}
    
   

