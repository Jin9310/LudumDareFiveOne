using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _moveInput;
    [SerializeField] private float _speed = 5f;

    [SerializeField] private float _jumpForce;
    [SerializeField] private bool _isGrounded;
    [SerializeField] private int _extraJumps;
    public float checkRadius;
    private int _basicJumpValue = 1;

    public Transform groundCheck;
    public LayerMask whatIsGround;

    Rigidbody2D rb;

    private void Start()
    {
        _extraJumps = _basicJumpValue;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        

        _moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(_moveInput * _speed, rb.velocity.y);

        
    }

    private void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if ((Input.GetKeyDown(KeyCode.Space)) && _extraJumps > 0)
        {
            rb.velocity = Vector2.up * _jumpForce;
            _extraJumps--;
        }
        else if (((Input.GetKeyDown(KeyCode.Space)) && _extraJumps == 0 && _isGrounded == true))
        {
            rb.velocity = Vector2.up * _jumpForce;
            _extraJumps = _basicJumpValue;
        }
    }
}
