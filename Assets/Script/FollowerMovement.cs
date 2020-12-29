using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FollowerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform TargetObj = null;
    public float mindistance = 0.5f;
    public float maxdistance = 15;
    public float speed = 2;
    public float rotSpeed = 0.6f;
    public Transform Player = null;
    float height = -1.7f;
    float countHeight=0;

    protected Animator avatar;
    private float SpeedDampTime = 0.005f;

    Vector3 velocity;
    public float gravity = -0.98f;


    // Start is called before the first frame update
    void Start()
    {
        avatar = GetComponent<Animator>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        if (Player.gameObject.tag == gameObject.tag )
        {
            //重力
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
            //lightGun啟用的時候
            if(PlayerMovement.lightGunOn == true)
            {
                countHeight = TargetObj.position.y - transform.position.y;
                //距離跟按鈕壓下去
                if (Vector3.Distance(TargetObj.position, transform.position) > mindistance && Vector3.Distance(TargetObj.position, transform.position) < maxdistance && countHeight > height && PlayerMovement.pressDown == true && PlayerMovement.lightGunOn == true)
                {
                    Vector3 move = transform.forward;
                    controller.Move(move * speed * Time.deltaTime);
                    //動畫
                    avatar.SetFloat("Speed", 0.3f, SpeedDampTime, Time.deltaTime);
                    //設定面向 
                    //transform.LookAt(TargetObj);
                    Vector3 TargetDir = TargetObj.position - transform.position;
                    TargetDir.y = 0.0f;//繞y旋轉
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(TargetDir), Time.time * rotSpeed);
                }
                else
                {
                    //動畫
                    avatar.SetFloat("Speed", 0, SpeedDampTime, Time.deltaTime);
                    //設定面向 
                    transform.LookAt(null);
                }
            }            
        }
    }
}
