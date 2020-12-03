using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Cinemachine.Examples
{
    [AddComponentMenu("")] // Don't display in add component menu
    public class CameraChange : MonoBehaviour
    {
        
        public CinemachineVirtualCameraBase switchCam; //Camera
        
        void Start()
        {
           
        }

        void OnTriggerEnter(Collider col)
        {
            if ( switchCam )
            {
                if (Camera.main.GetComponent<CinemachineBrain>().ActiveVirtualCamera.Name != switchCam.Name)
                {     
                    switchCam.VirtualCameraGameObject.SetActive(false); //先禁用再启用，得到切换效果
                    switchCam.VirtualCameraGameObject.SetActive(true);
                }
            }
        }

       

    }
}
