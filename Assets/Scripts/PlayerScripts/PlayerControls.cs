using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;

    float inputX;

    public float speed = 8f;

    // Start is called before the first frame update
    void Start()
    {
    animator = GetComponent<Animator>();
    rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate() 
    {
        if (inputX > 0)
        {
            transform.localScale = new Vector3(-1.0f,1.0f,1.0f);
        }

        if (inputX < 0)
        {
            transform.localScale = new Vector3(1.0f,1.0f,1.0f);
        }

        rb.velocity = new Vector2(inputX * speed, rb.velocity.y);

        if (Mathf.Abs(inputX) > 0)
        {
            animator.SetTrigger("Run");
        }
        else 
        {
            animator.SetTrigger("Idle");
        }
    }

    
}
