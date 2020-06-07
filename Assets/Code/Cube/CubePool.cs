using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace TestWork.Cube
{
    public class CubePool : MonoBehaviour
    {
        private List<CubeBase> pool;

        private void Awake()
        {
            pool = new List<CubeBase>();
        }

        public void Add(CubeBase cube)
        {
            pool.Add(cube);
        }

        public void Remove(CubeBase cube)
        {
            pool.Remove(cube);
        }
    }
}
