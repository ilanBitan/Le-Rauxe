using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Monster : MonoBehaviour
    {
        [SerializeField]
        public float speed;

        private Rigidbody2D mybody;

        private void Awake()
        {
            mybody = GetComponent<Rigidbody2D>();

        }

        private void FixedUpdate()
        {
            mybody.velocity = new Vector2(speed, mybody.velocity.y);
        }
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}