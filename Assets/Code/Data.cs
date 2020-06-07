using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestWork
{
    public static class Data
    {
        private const string Ball = "Ball";
        public static int GetCountBall()
        {
            return PlayerPrefs.HasKey(Ball) ? PlayerPrefs.GetInt(Ball) : 0;
        }

        public static void AddBall()
        {
            var count = PlayerPrefs.HasKey(Ball) ? PlayerPrefs.GetInt(Ball) : 0;
            ++count;
            PlayerPrefs.SetInt(Ball, count);
            PlayerPrefs.Save();
        }
    }
}
