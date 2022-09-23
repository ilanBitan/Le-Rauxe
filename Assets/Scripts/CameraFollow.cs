using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class CameraFollow : MonoBehaviour
    {
        private Transform player;
        private Vector3 tempPos;
        [SerializeField]
        private float minX, maxX;
        private void Start()
        {
            player = GameObject.FindWithTag("Player").transform;
        }
        void LateUpdate()
        {
            if (player == null)
            {
                return;
            }
            tempPos = transform.position;
            tempPos.x = player.position.x;
            if(tempPos.x < minX)
                tempPos.x = minX;
            if (tempPos.x > maxX)
                tempPos.x = maxX;
            transform.position = tempPos;
        }
    }
}