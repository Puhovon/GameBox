using UnityEngine;

public class InputManager : MonoBehaviour
{
    private InputSystem_Actions _action;

    private void Awake()
    {
        _action = new InputSystem_Actions();
    }

    private void OnEnable()
    {
        _action.Enable();
    }

    private void OnDisable()
    {
        _action.Disable();
    }

    public Vector2 GetPlayerMovement()
    {
        return _action.Player.Move.ReadValue<Vector2>();
    }
}