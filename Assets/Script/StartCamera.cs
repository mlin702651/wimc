using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine.Examples
{

    [AddComponentMenu("")] // Don't display in add component menu
    public class StartCamera : MonoBehaviour
    {

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

    }
}
