﻿using System;
using System.Diagnostics;
using UnityEngine;

namespace HelloWorld
{
    [KSPAddon(KSPAddon.Startup.MainMenu, false)]
    public class Hello : MonoBehaviour
    {
        public void Update()
        {
            Debug.Log("Hello world! " + Time.realtimeSinceStartup);
        }
    }

    /// <summary>
    /// My first part!
    /// </summary>
    public class HelloKerbinMod : PartModule
    {
        /// <summary>
        /// Called when the part is started by Unity.
        /// </summary>
        public override void OnStart(StartState state)
        {
            // Add stuff to the log
            print("Hello, Kerbin?");
        }
    }
}