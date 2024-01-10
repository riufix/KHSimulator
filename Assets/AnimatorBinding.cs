using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorBinding : MonoBehaviour
{
    [SerializeField, Required] Animator _anim;
    [SerializeField, Required] PlayerMove _move;
    [SerializeField, AnimatorParam("_anim", AnimatorControllerParameterType.Bool)] string _isWalkingBoolParam;

    private void Start()
    {
        _move.OnStartMove += _move_OnMove;
        _move.OnStopMove += _move_OnStop;
    }
    private void _move_OnMove()
    {
        _anim.SetBool(_isWalkingBoolParam, true);
    }

    private void _move_OnStop()
    {
        _anim.SetBool(_isWalkingBoolParam, false);
    }

}
