using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


/// <summary>
/// 캐릭터를 조종하는곳 어쩔수 없이 일단 플레이어의 캐릭터를 조종하는 역할
/// </summary>
[RequireComponent(typeof(CharacterBehavior))]
public class CharacterController : MonoBehaviour
{
    private CharacterBehavior behaviour;
    // Start is called before the first frame update
    void Awake()
    {
        behaviour = GetComponent<CharacterBehavior>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMove(InputValue value)
    {
        var dir = value.Get<Vector2>();
        behaviour.MoveDirection = new Vector3(dir.x, 0, dir.y);
    }
}

/// CharacterController
/// ㄴPlayerCharacterController
/// ㄴAICharacterController
