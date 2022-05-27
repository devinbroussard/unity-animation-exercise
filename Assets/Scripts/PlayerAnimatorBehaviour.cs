using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorBehaviour : MonoBehaviour
{
    [SerializeField]
    private PlayerMovementBehaviour _playerMovementBehaviour;

    [SerializeField]
    private Animator _animator;

    private void Awake()
    {
        WinBoxBehaviour.OnWin += () => _animator.SetTrigger("Win");
    }

    private void Update()
    {
        _animator.SetFloat("Speed", _playerMovementBehaviour.Velocity.magnitude);

        if (_playerMovementBehaviour.Velocity.magnitude == 0)
        {
            _animator.SetTrigger("Idle");
        }
    }
}
