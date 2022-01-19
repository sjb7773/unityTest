using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///  ���� �����͸� ��°� (���������� ���Ǵ� ������)
/// </summary>

[CreateAssetMenu(menuName = "Character Actions/Stab Action", fileName = "New StabActionData", order =0)]
public class StabActionData : ScriptableObject
{
    /// <summary>
    /// �׼��� ����
    /// </summary>
    public float Duration;

    /// <summary>
    /// ���ݷ� ���
    /// </summary>
    public float AtkMultiplier;

    /// <summary>
    /// ��Ʈ Ƚ��
    /// </summary>
    public float HitTiming;
}

public class StabAction
{
    public void OnEnter()
    {
        ///Blah
    }
    
    public void OnUpdate()
    {
        ///blah
    }

    public void OnExit()
    {
        ///Blah
    }
}
