using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float velocidade = 5f;
    private Rigidbody2D rb;
    private Vector2 movimento;

    private Animator anim;
    private bool isWalking = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        movimento = Vector2.zero;

        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) movimento.y = 1;
        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) movimento.y = -1;
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) movimento.x = 1;
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) movimento.x = -1;

        movimento = movimento.normalized;

        isWalking = (movimento.x !=0 || movimento.y !=0);
        anim.SetBool("isWalking", isWalking);

        if (isWalking)
        {
            anim.SetFloat("eixoX", movimento.x);
            anim.SetFloat("eixoY", movimento.y);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimento * velocidade * Time.fixedDeltaTime);
    }
}
