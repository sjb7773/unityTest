using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// ĳ���� �ൿ, �׼� ��ɵ��� ������ ������ ��
/// </summary>
[RequireComponent(typeof(Character))]

public class CharacterBehavior : MonoBehaviour
{
    /// <summary>
    /// ĳ���� ����
    /// </summary>
    private Character character;

    /// <summary>
    /// �ִϸ��̼� ��Ʈ�ѷ�
    /// </summary>
    private Animator anim;


    private Rigidbody rigidbody;

    /// private new Transform transform;

    /// <summary>
    /// ������ ����
    /// </summary>
    public Vector3 MoveDirection;

    /// <summary>
    /// ����ĳ���� �Ÿ�
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

    ///string �Ƴ�����
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
