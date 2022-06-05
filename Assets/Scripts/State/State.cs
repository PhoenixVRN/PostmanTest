using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : ScriptableObject
{
    public bool isFinished { get; protected set; }

    [HideInInspector] public Postman postman;
   
    public virtual void Init(){}

    public abstract void Run();
}
