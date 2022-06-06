using UnityEngine;

[CreateAssetMenu(menuName = "State/Idle State", fileName = "Idle State")]
public class IdleState : State
{
    public float idleTime;
    public override void Init()
    {
        postman.text.text = "Idle";
    }
    
    public override void Run()
    {
        idleTime -= Time.deltaTime;
        if (idleTime < 0)
        {
            postman.workingTime = 120;
            postman.SetState(postman.pastState);
        }
    }
}



