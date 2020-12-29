using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purple : MonoBehaviour
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

        if (ToxinController.countP == 0)
        {
            _mat.SetColor("_BaseColor", lv0);
        }
        else if (ToxinController.countP == 1)
        {
            _mat.SetColor("_BaseColor", lv1);
            timer = 0;
        }
        else if (ToxinController.countP == 2)
        {
            _mat.SetColor("_BaseColor", lv2);
            ToxinController.waitP = true;

            Debug.Log(timer);
            if (timer > 1)
            {
                ToxinController.waitP = false;
                ToxinController.countP = 0;
                timer = 0;
            }
        }

    }

}
