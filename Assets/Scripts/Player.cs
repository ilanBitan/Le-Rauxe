using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private float moveForce = 10f;

        [SerializeField]
        private float jumpForce = 11f;

        private float movementX;

        [SerializeField]
        private Rigidbody2D myBody;

        private SpriteRenderer sr;

        private Animator anim;
        private string WALK_ANIMATION = "Walk";

        private bool isGrounded;
        private string GROUND_TAG = "Ground";
        private string ENEMY_TAG = "Enemy";

        private void Awake()
        {
            myBody = GetComponent<Rigidbody2D>();
            anim = GetComponent<Animator>();

            sr = GetComponent<SpriteRenderer>();
        }

        void Start()
        {
        
        }
        void Update()
        {
            PlayerMoveKeyboard();
            AnimatePlayer();
        }

        private void FixedUpdate()
        {
            PlayerJump();
        }
        void PlayerMoveKeyboard()
        {
            movementX = Input.GetAxisRaw("Horizontal");

            transform.position += new Vector3(movementX, 0f, 0f) * moveForce * Time.deltaTime;
        }
        void AnimatePlayer()
        {
            if (movementX > 0)
            {
                anim.SetBool("Walk", true);
                sr.flipX = true;
            }
            else if (movementX < 0)
            {
                anim.SetBool("Walk", true);
                sr.flipX = false;
            }
            else
            {
                anim.SetBool("Walk", false);
            }
            }
        void PlayerJump()
        {
            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                isGrounded = false;
                myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            }
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag(GROUND_TAG))
            {
                isGrounded = true;
            }
            if (collision.transform.CompareTag(ENEMY_TAG))
            {
                Destroy(gameObject);
            }
        }
    }
}