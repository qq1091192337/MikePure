﻿using System.Collections;
using System.Reflection;
using MikePure.MikePure.Cheats.Overrides;
using MikePure.MikePure.Framework.Loader;
using MikePure.MikePure.Framework.Util;
using SDG.Unturned;
using UnityEngine;

namespace MikePure.MikePure.Framework.Handler
{
    internal class AutoPilot : MonoBehaviour
    {
        public void Start()
        {
            HackDirector.Start();
            
            //Add implementation to this method
            LocalFileHelper.LoadAll();
        }

        public void Update()
        {
            HackDirector.Update();
        }

    }
}