using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{  
    public Transform playerBody;
    public Vector3 dis;
    private Vector3 velocity = Vector3.zero;
    public float SmoothTime = 0.05f;
    //=((-0.1f,3,-3f))
    //PlayerControls controls;
    //Vector2 getRotate;


    //void Awake()
    //{
    //    controls = new PlayerControls();

    //    controls.player.Rotate.performed += ctx => getRotate = ctx.ReadValue<Vector2>();
    //    controls.player.Rotate.canceled += ctx => getRotate = Vector2.zero;

    //}

    //void OnEnable()
    //{
    //    controls.player.Enable();
    //}

    //void OnDisable()
    //{
    //    controls.player.Disable();
    //}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 rotate = new Vector2(0, getRotate.x)*100f* Time.deltaTime;        
        //playerBody.Rotate(Vector3.up * rotate, Space.World);//沒搞懂Space.World

        transform.position=Vector3.SmoothDamp(transform.position, playerBody.transform.position + dis, ref velocity, SmoothTime);
        
        
    }
}
