using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KidController : MonoBehaviour
{
    [SerializeField] float speed = 6f;
    [SerializeField] float jumpSpeed = 8f;
    Vector2 moveInput;
    Rigidbody2D _rigid;
    Animator _anim;
    CapsuleCollider2D _bodyCollider;
    SpriteRenderer _sprite;
    void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _bodyCollider = GetComponent<CapsuleCollider2D>();
        _sprite = GetComponent<SpriteRenderer>();

    }
    void Update()
    {
        Run();
        FlipSprite();
    }


    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();

    }


    void OnJump(InputValue value)
    {
        if (value.isPressed && _bodyCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            _rigid.velocity += new Vector2(0f, jumpSpeed);
        }

    }
    void Run()
    {
        Vector2 playerVelocity =
                new Vector2(moveInput.x * speed, moveInput.y * speed);
        _rigid.velocity = playerVelocity;

        bool playerHasHorizontalSpeed = Mathf.Abs(_rigid.velocity.x) > Mathf.Epsilon;
        _anim.SetBool("isRun", playerHasHorizontalSpeed);
    }

    void FlipSprite()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(_rigid.velocity.x) > Mathf.Epsilon; // Epsilon teknikli 0 demek, X i miz ekside artýda olsa x deðeri var sayýlacak

        if (playerHasHorizontalSpeed)
        {
            transform.localScale = new Vector2((Mathf.Sign(_rigid.velocity.x) * -1f), 1f);
        }
    }
}
