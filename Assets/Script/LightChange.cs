using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChange : MonoBehaviour
{

    public Transform playerBody;
    public GameObject target;

    Light lt;
    public Color colorYellow;
    public Color colorBlue;
    public Color colorRed;
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
        lt.enabled = false;
        //target.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.tag = playerBody.gameObject.tag;
        if (PlayerMovement.pressDown == true)
        {
            lt.enabled = true;
            //target.SetActive(true);
            //更改手電筒燈的顏色
            if (gameObject.tag== "yellow")
            {
                lt.color = colorYellow;
            }
            if (gameObject.tag == "blue")
            {
                lt.color = colorBlue;
            }
            if (gameObject.tag == "red")
            {
                lt.color = colorRed;
            }
        }
        else
        {
            lt.enabled = false;
            //target.SetActive(false);
        }
        

    }
}
