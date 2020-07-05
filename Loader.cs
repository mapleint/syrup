using UnityEngine;
using UnityEngine.Networking;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Collections;
using System;
using BeanAssembly.Features;

namespace BeanAssembly
{
    // Loading Component
    public class Loader
    {
        // Unity Loader
        static GameObject gameObject;
        public static void Load()
        {
            gameObject = new GameObject();
            gameObject.AddComponent<syrup>();
            UnityEngine.Object.DontDestroyOnLoad(gameObject);
        }
        public static void Unload()
        {
            UnityEngine.Object.Destroy(gameObject);
        }
    }
}


