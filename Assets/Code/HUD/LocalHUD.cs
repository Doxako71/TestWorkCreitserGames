using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TestWork.UI
{
    public class LocalHUD : MonoBehaviour
    {
#pragma warning disable 0649
        [SerializeField]
        private Button btnMenu;
        [SerializeField]
        private Button btnRestart;
        [SerializeField]
        private Button btnClose;
        [SerializeField]
        private Button btnHomeWin;
        [SerializeField]
        private Button btnHome;
        [SerializeField]
        private GameObject panelWin;
        [SerializeField]
        private GameObject panelMenu;
#pragma warning restore 0649

        private void Start()
        {
            btnMenu.onClick.AddListener(() => panelMenu.SetActive(true));
            btnClose.onClick.AddListener(() => panelMenu.SetActive(false));
            btnHomeWin.onClick.AddListener(() => SceneManager.LoadScene(0));
            btnHome.onClick.AddListener(() => SceneManager.LoadScene(0));
            var indexLevel = SceneManager.GetActiveScene().buildIndex;
            btnRestart.onClick.AddListener(() => SceneManager.LoadScene(indexLevel));
        }

        public void ShowWinMenu()
        {
            panelWin.SetActive(true);
            btnMenu.interactable = false;
        }
    }
}
