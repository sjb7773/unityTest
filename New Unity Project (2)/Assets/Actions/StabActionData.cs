using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///  요기는 데이터만 담는곳 (공통적으로 사용되는 데이터)
/// </summary>

[CreateAssetMenu(menuName = "Character Actions/Stab Action", fileName = "New StabActionData", order =0)]
public class StabActionData : ScriptableObject
{
    /// <summary>
    /// 액션의 길이
    /// </summary>
    public float Duration;

    /// <summary>
    /// 공격력 계수
    /// </summary>
    public float AtkMultiplier;

    /// <summary>
    /// 히트 횟수
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
