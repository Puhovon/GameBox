using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerInput : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField, Range(0.5f, 2)] private float _speed;

    private CharacterController _characterController;

    public void Initialize(InputManager inputManager)
    {
        _characterController = GetComponent<CharacterController>();

        if( _characterController is null )
        {

        }
    }
}
