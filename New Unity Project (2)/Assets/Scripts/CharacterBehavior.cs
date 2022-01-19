using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 캐릭터 행동, 액션 기능들을 실제로 구현할 곳
/// </summary>
[RequireComponent(typeof(Character))]

public class CharacterBehavior : MonoBehaviour
{
    /// <summary>
    /// 캐릭터 정보
    /// </summary>
    private Character character;

    /// <summary>
    /// 애니메이션 컨트롤러
    /// </summary>
    private Animator anim;


    private Rigidbody rigidbody;

    /// private new Transform transform;

    /// <summary>
    /// 움직일 방향
    /// </summary>
    public Vector3 MoveDirection;

    /// <summary>
    /// 레이캐스팅 거리
    /// </summary>
    public float rayDetectionDistance;

    void Awake()
    {
        character = GetComponent<Character>();
        anim = GetComponent<Animator>();
        /// transform = GetComponent<Transform>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(MoveDirection);
    }

    ///string 아끼려구
    private const string moveKey = "Move";

    public void Move(Vector3 direction)
    {
        var magnitude = direction.sqrMagnitude;
        Vector3 pos = transform.position;
        transform.LookAt(pos + direction, Vector3.up);

        Debug.DrawRay(transform.position, direction * rayDetectionDistance, Color.magenta, 0.1f);
        if (Physics.Raycast(transform.position + Vector3.up * 0.01f, direction, rayDetectionDistance))
        {
            anim.SetFloat(moveKey, 0);
        }
        else
        {
            anim.SetFloat(moveKey, magnitude);

            
            transform.position += direction * character.Speed * Time.deltaTime;
        }
        
    }
}
