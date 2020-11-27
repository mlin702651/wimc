using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    
    PlayerControls controls;
    public float speed = 5f;
    public float rotSpeed = 0.6f;

    public static Vector2 getMove;
    public static Vector2 getRotate;    
    public static bool pressDown = false;
    int weaponNum=1;
    public static bool toxinGunOn = false;
    public static bool lightGunOn = false;
    public GameObject toxinGun;
    public GameObject lightGun;

    Vector3 velocity;
    public float gravity = -0.98f;

    void Awake()
    {
        //手把控制
        controls = new PlayerControls();
        controls.player.Move.performed += ctx => getMove = ctx.ReadValue<Vector2>();
        controls.player.Move.canceled += ctx => getMove = Vector2.zero;
        controls.player.SwitchWeaponPlus.performed += ctx => SwitchWeaponPlus();
        controls.player.SwitchWeaponLess.performed += ctx => SwitchWeaponLess();
        //
        controls.player.Shoot.started += ctx => ShootStart();
        controls.player.Shoot.canceled += ctx => ShootCanceled();
       
        
    }
    //切換武器
    void SwitchWeaponPlus(){
        weaponNum++;
        if (weaponNum > 3)
        {
            weaponNum %= 3;
        }
    }
    void SwitchWeaponLess()
    {
        weaponNum--;
        if (weaponNum == 0)
        {
            weaponNum = 3;
        }
    }
    void ShootStart()
    {
        pressDown = true;
    }
    void ShootCanceled()
    {
        pressDown = false;
    }
    void OnEnable()
    {
        controls.player.Enable();
    }

    void OnDisable()
    {
        controls.player.Disable();
    }

    //測試 射線檢測扇形面積
  



    //

    void Update()
    {
        //移動
        if (getMove.x != 0 || getMove.y != 0)
        {  
                     
            Vector3 TargetDir = new Vector3(getMove.x, 0, getMove.y);           
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(TargetDir), Time.time * rotSpeed);
            controller.Move(transform.forward * speed * Time.deltaTime);
            
        }
        //重力
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        //切換槍
        if (weaponNum == 1)
        {
            toxinGunOn = false;
            lightGunOn = false;
            toxinGun.SetActive(false);
            lightGun.SetActive(false);
            
        }
        else if(weaponNum == 2)
        {
            //啟用toxinGun
            toxinGunOn = true;
            lightGunOn = false;
            toxinGun.SetActive(true);
            lightGun.SetActive(false);
        }
        else if (weaponNum == 3)
        {
            //啟用lightGun
            toxinGunOn = false;
            lightGunOn = true;
            toxinGun.SetActive(false);
            lightGun.SetActive(true);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "yellow")
        {
            gameObject.tag = "yellow";
        }
        else if (other.gameObject.tag == "blue")
        {
            gameObject.tag = "blue";
        }
        else if (other.gameObject.tag == "red")
        {
            gameObject.tag = "red";
        }
    }


}
