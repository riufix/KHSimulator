using Cinemachine;
using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using static UnityEngine.InputSystem.InputAction;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    [SerializeField] float _speed;

    [SerializeField] InputActionReference _move;


    // Event pour les dev
    public event Action OnStartMove;

    // Event pour les GD
    [SerializeField] UnityEvent _onEvent;
    [SerializeField] UnityEvent _onEventPost;

    public Vector2 JoystickDirection { get; private set; }
    Coroutine MovementRoutine { get; set; }

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _move.action.performed += OnMove;
        _move.action.canceled += OnMove;
    }

    private void OnMove(CallbackContext ctx)
    {
        JoystickDirection = _move.action.ReadValue<Vector2>();
        Vector3 Move = new Vector3 (JoystickDirection.x,0,JoystickDirection.y);
        _rb.velocity = Move * _speed;
        OnStartMove.Invoke();
    }

    private void OnDestroy()
    {
        _move.action.performed -= OnMove;
        _move.action.canceled -= OnMove;
    }

}
