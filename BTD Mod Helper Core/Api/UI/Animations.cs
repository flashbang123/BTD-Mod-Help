﻿using System.Collections.Generic;
using UnhollowerRuntimeLib;
using UnityEngine;
#pragma warning disable CS1591

namespace BTD_Mod_Helper.Api
{
    /// <summary>
    /// Class to statically store RuntimeAnimationControllers for different animations
    /// </summary>
    public static class Animations
    {
        public static RuntimeAnimatorController GlobalButtonAnimation => Get("GlobalButtonAnimation");
        public static RuntimeAnimatorController TabAnimation => Get("GlobalTabAnimation");
        public static RuntimeAnimatorController GlowPulse => Get("GlowPulse");
        public static RuntimeAnimatorController PopupAnim => Get("PopupAnim");

        private static readonly Dictionary<string, RuntimeAnimatorController> AnimationsByName =
            new Dictionary<string, RuntimeAnimatorController>();

        internal static void Load()
        {
            if (AnimationsByName.Count == 0)
            {
                var animationControllers = Resources.FindObjectsOfTypeAll(Il2CppType.Of<RuntimeAnimatorController>());
                foreach (RuntimeAnimatorController runtimeAnimatorController in animationControllers)
                {
                    AnimationsByName[runtimeAnimatorController.name] = runtimeAnimatorController;
                    ModHelper.Msg("Animation: " + runtimeAnimatorController.name);
                }
            }
        }

        /// <summary>
        /// Gets an AnimationController by its name, or null if there isn't one with that name
        /// </summary>
        public static RuntimeAnimatorController Get(string name)
        {
            return AnimationsByName.TryGetValue(name, out var anim) ? anim : null;
        }

    }
}