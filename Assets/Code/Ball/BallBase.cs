using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestWork.Ball
{
    public abstract class BallBase : MonoBehaviour
    {
        private const float Delta = 1000f;
#pragma warning disable 0649

        [SerializeField]
        protected float force;
        [SerializeField]
        protected GameObject fx;

#pragma warning restore 0649

        protected Rigidbody rb;

        protected virtual void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        protected virtual void OnTriggerEnter(Collider other)
        {
            print(other);
            if (other.CompareTag("absorp"))
            {
                Destroy(gameObject);
            }
            fx.SetActive(true);
        }

        public virtual void Push(Vector3 direction)
        {
            rb.AddForce(direction * force * Delta * Time.fixedDeltaTime, ForceMode.Impulse);
        }
    }
}

