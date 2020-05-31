using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rakib
{
    public class NpcControllerEnum : MonoBehaviour
    {
        public NpcType npcType;
        public float forwardMoverSpeed = 20f;
        public float sideMoverSpeed = 10f;
        private void Update()
        {
            switch (npcType)
            {
                case NpcType.ForwardMover:
                    //Move Forward
                    transform.Translate(0, 0, Time.deltaTime * forwardMoverSpeed);
                    break;
                case NpcType.SideMover:
                    //Move sideways
                    transform.Translate(Time.deltaTime * sideMoverSpeed, 0, 0);
                    break;
            }
        }
    }

    public enum NpcType
    {
        ForwardMover, 
        SideMover
    }

}