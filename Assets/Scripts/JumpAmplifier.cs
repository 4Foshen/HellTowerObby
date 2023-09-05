using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAmplifier : MonoBehaviour
{
    [SerializeField] private float _amplifyMovement;
    [SerializeField] private float _amplifiedSprint;

    private ThirdPersonController _player;
    private float _beforeMovement;
    private float _beforeSprint;

    private void Awake()
    {
        _player = GetComponent<ThirdPersonController>();
        _beforeMovement = _player.MoveSpeed;
        _beforeSprint = _player.SprintSpeed;
    }
    private void Update()
    {
        if(!_player.Grounded)
        {
            AmplifySpeed();
        }
        if (_player.Grounded)
        {
            NormalSpeed();
        }
    }
    private void AmplifySpeed()
    {
        _player.MoveSpeed = _amplifyMovement;
        _player.SprintSpeed = _amplifiedSprint;
    }
    private void NormalSpeed()
    {
        _player.MoveSpeed = _beforeMovement;
        _player.SprintSpeed = _beforeSprint;
    }
}
