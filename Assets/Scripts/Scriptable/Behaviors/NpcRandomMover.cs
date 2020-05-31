using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Rakib
{
    [CreateAssetMenu(menuName = "NpcBehavior/RandomMover", fileName = "RandomMover")]
    public class NpcRandomMover : NpcBehavior
    {
        [SerializeField] private float speed;
        [SerializeField] private float randomRange = 10f; 
        [SerializeField] private Vector3 m_randomPosition;
        [SerializeField] private bool m_moving = false;

        public override void Behave(NpcControllerScriptable npcController)
        {
            var npcTransform = npcController.transform;
            var distance = Vector3.Distance(npcTransform.position, m_randomPosition);
            if (distance < 0.5f || distance > 10f)
            {
                m_randomPosition = GetRandomPosition(npcTransform.position);
                npcTransform.LookAt(m_randomPosition);
                m_moving = true;
            }
            else
                npcTransform.Translate(0,0,Time.deltaTime * speed);
        }


        private Vector3 GetRandomPosition(Vector3 centerPosition)
        {
            var randomXy = Random.insideUnitCircle * randomRange;
            var randomPosition = new Vector3(randomXy.x, centerPosition.y, randomXy.y);
            return randomPosition;
        }
    }
}