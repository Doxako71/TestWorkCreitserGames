using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestWork.Cube
{
    public abstract class CubeBase : MonoBehaviour
    {
#pragma warning disable 0649
        [SerializeField]
        private CubePool cubePool;
#pragma warning restore 0649

        protected virtual void OnValidate()
        {
            cubePool = FindObjectOfType<CubePool>();
        }

        private void Start()
        {
            cubePool.Add(this);
        }

        protected virtual void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("absorp"))
            {
                cubePool.Remove(this);
                Destroy(gameObject);
            }
        }
    }
}
