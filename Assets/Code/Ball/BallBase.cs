using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestWork.Ball
{
    public abstract class BallBase : MonoBehaviour
    {
#pragma warning disable 0649

        [SerializeField]
        protected float force;

#pragma warning restore 0649

        protected Rigidbody rb;

        protected virtual void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        public virtual void Push(Vector3 direction)
        {
            rb.AddForce(direction * force * Time.fixedDeltaTime, ForceMode.Impulse);
        }
    }
}

