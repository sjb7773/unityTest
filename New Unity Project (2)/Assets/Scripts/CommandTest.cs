using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class CommandTest : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            using (var cmd = DamageCommand.Create(this.gameObject))
            {
                cmd.Execute();
            }
            
        }
    }
}

public interface ICommand
{
    void Execute();
}


public class DamageCommand :ICommand, IDisposable
{
    private static ObjectPool<DamageCommand> pool = new ObjectPool<DamageCommand>();
    private GameObject go;
    public void Execute() 
    {
        Debug.Log($"{go.name}데미지 입었다!");
    }

    public static DamageCommand Create(GameObject go)
    {
        var cmd = pool.GetOrCreate();
        cmd.go = go;
        return cmd;
    }

    public void Dispose()
    {
        go = null;
    }
}
