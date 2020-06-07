using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TestWork.UI;

namespace TestWork.Cube
{
    public class CubePool : MonoBehaviour
    {
#pragma warning disable 0649

        [SerializeField]
        private LocalHUD localHUD;

#pragma warning restore 0649
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
            if (pool.Count == 0)
            {
                localHUD.ShowWinMenu();
            }
        }
    }
}
