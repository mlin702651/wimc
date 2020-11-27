using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAim : MonoBehaviour
{
    PlayerControls controls;
    Vector2 getHandMove;
    public Transform gun;

    void Awake(){
        controls = new PlayerControls();
        controls.player.HandMove.performed += ctx => getHandMove = ctx.ReadValue<Vector2>();
        controls.player.HandMove.canceled += ctx => getHandMove = Vector2.zero;
    }

    void OnEnable()
    {
        controls.player.Enable();
    }

    void OnDisable()
    {
        controls.player.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (getHandMove.x != 0 || getHandMove.y != 0)
        {
            if(gun.transform.eulerAngles.y > 30)
            {
                Quaternion quate = Quaternion.identity;
                quate.eulerAngles = new Vector3(0, 29, 0);
                gun.transform.rotation = quate;

            }
            else if (gun.transform.eulerAngles.y < -30)
            {
                Quaternion quate = Quaternion.identity;
                quate.eulerAngles = new Vector3(0, -29, 0);
                gun.transform.rotation = quate;
            }
            else
            {
                //Vector2 upRotate = new Vector2(0, getHandMove.x) * 100f * Time.deltaTime;
                //Vector2 rightRotate = new Vector2(getHandMove.y, 0) * 100f * Time.deltaTime;
                Vector3 rotate= new Vector3(getHandMove.x,0, getHandMove.y)* 100f * Time.deltaTime;
                //gun.Rotate(Vector3.up * upRotate, Space.World);//沒搞懂Space.World
                gun.Rotate(rotate, Space.World);//沒搞懂Space.World
            }
            
        }
        Debug.Log("x"+getHandMove.x);
        Debug.Log("y" + getHandMove.y);

    }
}
