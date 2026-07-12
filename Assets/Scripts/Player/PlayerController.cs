using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public PlayerMovement movement;
    public PlayerInput input;
    void Start()
    {
        movement = GetComponent<PlayerMovement>();
        input = GetComponent<PlayerInput>();
    }

    void Update()
    {
        movement.Move(input.axis);
    }
}
