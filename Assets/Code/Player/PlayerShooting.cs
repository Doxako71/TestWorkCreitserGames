using System.Collections;
using System.Collections.Generic;
using TestWork.Ball;
using UnityEngine;

namespace TestWork.Player
{
    public class PlayerShooting : MonoBehaviour
    {
#pragma warning disable 0649
        [SerializeField]
        private BallSimple prefab;
#pragma warning restore 0649
        public void Shot(Vector3 direction)
        {
            var go = Instantiate(prefab, transform.position, Quaternion.identity);
            go.Push(direction);
        }
    }
}
