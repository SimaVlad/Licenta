using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed, dashRange;
    private Vector2 direction;
    private Animator animator;
    private bool PlayerMoving;
    private Vector2 lastMove = Vector2.zero;

    private void Start()
    {
        animator = GetComponent<Animator>();
        App_path();
    }

    void Update()
    {
        TakeInput();
        Move();
        Idle();
    }

    private void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        SetAnimatorMovement(direction);
    }

 
    private void TakeInput()
    {
        lastMove += direction;
        direction = Vector2.zero;
        SetPlayerMoving(false);
        animator.SetBool("PlayerMoving", PlayerMoving);
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
            SetPlayerMoving(true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
            SetPlayerMoving(true);
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
            SetPlayerMoving(true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
            SetPlayerMoving(true);
        }
    }

    private void SetAnimatorMovement(Vector2 direction)
    {
        animator.SetBool("PlayerMoving", PlayerMoving);
        animator.SetFloat("xDir", direction.x);
        animator.SetFloat("yDir", direction.y);
    }

    private void Idle()
    {
        animator.SetBool("PlayerMoving", PlayerMoving);
        animator.SetFloat("LastMoveX", lastMove.x);
        animator.SetFloat("LastMoveY", lastMove.y);
        if (PlayerMoving == true)
        { 
            lastMove = Vector2.zero;
        }
    }

    private void SetPlayerMoving(bool moving)
    {
        PlayerMoving = moving;
    }

    public void App_path()
    {
        Debug.Log(Application.dataPath);
    }
}
