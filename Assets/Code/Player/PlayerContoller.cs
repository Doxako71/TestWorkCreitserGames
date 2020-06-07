using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TestWork.Player
{
    public class PlayerContoller : MonoBehaviour
    {
#pragma warning disable 0649
        [SerializeField]
        private PlayerShooting playerShooting;
        [SerializeField]
        private EventSystem eventSystem;
#pragma warning restore 0649
        private Camera cam;

        private void Awake()
        {
            cam = Camera.main;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0) && !eventSystem.IsPointerOverGameObject())
            {
                var dir = cam.ScreenPointToRay(Input.mousePosition);
                playerShooting.Shot(dir.direction);
            }
        }
    }
}
