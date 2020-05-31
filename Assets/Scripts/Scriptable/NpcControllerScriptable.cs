using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rakib
{
    public class NpcControllerScriptable : MonoBehaviour
    {
        [SerializeField] private NpcBehavior npcBehavior;

        private void Update()
        {
            npcBehavior.Behave(this);
        }
    }
}