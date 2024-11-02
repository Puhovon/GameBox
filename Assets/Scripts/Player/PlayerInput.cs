using UnityEngine;
using Zenject;

[RequireComponent(typeof(CharacterController))]
public class PlayerInput : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField, Range(0.5f, 2)] private float _speed;
    [SerializeField] private float _gravityValue = -9.81f;

    private CharacterController _characterController;
    private InputManager _inputManager;

    [Inject]
    private void Construct(InputManager inputManager)
    {
        _characterController = GetComponent<CharacterController>();
        _inputManager = inputManager;
    }

    private void Update() => Move();
    
    private void Move()
    {
        var movement = _inputManager.GetPlayerMovement();
        var move = new Vector3(movement.x, 0f, movement.y);

        _characterController.Move(move * _speed * Time.deltaTime);
    }
}
