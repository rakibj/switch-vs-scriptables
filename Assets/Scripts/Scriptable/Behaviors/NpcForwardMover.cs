using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rakib
{
    [CreateAssetMenu(menuName = "NpcBehavior/ForwardMover", fileName = "ForwardMover")]
    public class NpcForwardMover : NpcBehavior
    {
        [SerializeField] private float speed;

        public override void Behave(NpcControllerScriptable npcController)
        {
            npcController.transform.Translate(0,0,Time.deltaTime*speed);
        }
    }
}