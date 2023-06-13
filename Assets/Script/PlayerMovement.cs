using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   // public List<string> inventory;

    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;

    [SerializeField] private LayerMask jumpableGround;

    private float dirX = 0f;
    private bool isMoving;
    [SerializeField]private float moveSpeed = 7f;
    [SerializeField]private float runForce;
    [SerializeField]private float jumpForce = 20f;
    
    private enum MovementState { idle, run, jumping, falling }

    [SerializeField] private AudioSource jumpSoundEffect;
    [SerializeField] private AudioSource runSoundEffect;

    // Start is called before the first frame update
    private void Start()
    {
       // inventory = new List<string>();

        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);


        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            jumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        if (Input.GetAxisRaw("Horizontal") != 0){
            isMoving = true;
            if(isMoving) {
                if(!runSoundEffect.isPlaying){
                    runSoundEffect.Play();
                }
                // else
                //     runSoundEffect.Stop();
            }
        }

        // anim.SetFloat("move", Mathf.Abs(dirX));


        if (dirX > 0f)
        {
            anim.SetBool("run", true);
        }
            else if (dirX < 0f)
            {
                anim.SetBool("run", true);
            }
            else
            {
                anim.SetBool("run", false);
            }

        UpdateAnimationsState();
    }

    private void UpdateAnimationsState()
    {
        MovementState state;
        //karakter mirror
        if (dirX > 0f)
            {
                state = MovementState.run;
                sprite.flipX = false;
            }
            else if (dirX < 0f)
                {
                    state = MovementState.run;
                    sprite.flipX = true;
                }
            else
                {
                state = MovementState.idle;
                }
          
        if (rb.velocity.y > .1f)
            {
                state = MovementState.jumping;
            }
       
            else if (rb.velocity.y < -.1f)
            {
                state = MovementState.falling;
            }

        anim.SetInteger("state", (int)state);
    }

    private bool IsGrounded()
    {
         return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Yoo"))
    //    {
           
     //       string itemType = collision.gameObject.GetComponent<ItemCollectorScript>().itemType;
      //      print ("We have collected a:" + itemType);

      //      inventory.Add(itemType);
        //    print("Inventory length:" + inventory.Count);

        //    Destroy(collision.gameObject);

}
