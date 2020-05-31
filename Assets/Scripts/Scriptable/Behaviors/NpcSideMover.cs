using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rakib
{
    [CreateAssetMenu(menuName = "NpcBehavior/SideMover", fileName = "SideMover")]
    public class NpcSideMover : NpcBehavior
    {
        [SerializeField] private float speed;

        public override void Behave(NpcControllerScriptable npcController)
        {
            npcController.transform.Translate(Time.deltaTime * speed, 0f, 0f);
        }
    }
}