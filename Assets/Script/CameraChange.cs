using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Cinemachine.Examples
{
    [AddComponentMenu("")] // Don't display in add component menu
    public class CameraChange : MonoBehaviour
    {
        
        public CinemachineVirtualCameraBase switchCam1; //Camera 湯匙走完
        public CinemachineVirtualCameraBase switchCam2; //Camera 解謎切視角
        public CinemachineVirtualCameraBase switchCam3; //Camera 看藍色的小精靈

        // Use this for initialization
        public CinemachineVirtualCameraBase vcam;

        // Use this for initialization
        void Start()
        {
            if (vcam)
            {
                vcam.MoveToTopOfPrioritySubqueue();
            }
           
        }

        void OnTriggerEnter(Collider col)
        {
            if (col.gameObject.tag == "guide")
            {
                if (switchCam1)
                {
                    if (Camera.main.GetComponent<CinemachineBrain>().ActiveVirtualCamera.Name != switchCam1.Name)
                    {
                        switchCam1.VirtualCameraGameObject.SetActive(false); //先禁用再启用，得到切换效果
                        switchCam1.VirtualCameraGameObject.SetActive(true);
                    }
                }
            }
            if (col.gameObject.tag == "pazzle")
            {
                if (switchCam2)
                {
                    if (Camera.main.GetComponent<CinemachineBrain>().ActiveVirtualCamera.Name != switchCam2.Name)
                    {
                        switchCam2.VirtualCameraGameObject.SetActive(false); //先禁用再启用，得到切换效果
                        switchCam2.VirtualCameraGameObject.SetActive(true);
                    }
                }
            }
            if (col.gameObject.tag == "watchElf")
            {
                if (switchCam3)
                {
                    if (Camera.main.GetComponent<CinemachineBrain>().ActiveVirtualCamera.Name != switchCam3.Name)
                    {
                        switchCam3.VirtualCameraGameObject.SetActive(false); //先禁用再启用，得到切换效果
                        switchCam3.VirtualCameraGameObject.SetActive(true);
                        
                    }
                }
            }

        }
        void OnTriggerExit(Collider col)
        {
            if (switchCam1)
            {
                if (Camera.main.GetComponent<CinemachineBrain>().ActiveVirtualCamera.Name != switchCam1.Name)
                {
                    switchCam1.VirtualCameraGameObject.SetActive(false); //先禁用再启用，得到切换效果
                    switchCam1.VirtualCameraGameObject.SetActive(true);
                }
            }

        }



    }
}
