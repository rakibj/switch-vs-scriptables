using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rakib
{
    public abstract class NpcBehavior : ScriptableObject
    {
        public abstract void Behave(NpcControllerScriptable npcController);
    }
}