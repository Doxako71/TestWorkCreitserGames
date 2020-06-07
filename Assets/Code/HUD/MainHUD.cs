using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

namespace TestWork.UI
{
    public class MainHUD : MonoBehaviour
    {
        private const string CountText = "COUNT BALL: ";
#pragma warning disable 0649
        [SerializeField]
        private TextMeshProUGUI textCount;
        [SerializeField]
        private Transform containerButtons;
#pragma warning restore 0649
        private List<Button> buttons;

        private void Start()
        {
            textCount.text = CountText + Data.GetCountBall();
            buttons = containerButtons.GetComponentsInChildren<Button>().ToList();
            for (var i = 0; i < buttons.Count; ++i)
            {
                var x = i;
                buttons[i].onClick.AddListener(() => SetLoadScene(x + 1));
            }
        }

        private void SetLoadScene(int value)
        {
            SceneManager.LoadScene(value);
        }
    }
}