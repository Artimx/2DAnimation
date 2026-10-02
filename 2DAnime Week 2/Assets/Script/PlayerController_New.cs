using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController_New : MonoBehaviour
{
    public float moveSpeed;
    private Animator anim;
    private Vector2 movement;
    private Rigidbody2D rb;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue movementValue)
    {
        movement = movementValue.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        if(movement != Vector2.zero)
        {
            anim.SetFloat("LookX", movement.x);
            anim.SetFloat("LookY", movement.y);
        }
        anim.SetFloat("Speed", movement.sqrMagnitude);
    }
}
