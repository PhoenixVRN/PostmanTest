using UnityEngine;

public abstract class State : ScriptableObject
{
    public bool isFinished;

    [HideInInspector] public Postman postman;

    public virtual void Init() {}

    public abstract void Run();
}
