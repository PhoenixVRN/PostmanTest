using UnityEngine;

[CreateAssetMenu(menuName = "State/Coming Back State", fileName = "ComingBackState")]
public class ComingBackState : State
{
    public override void Init()
    {
        postman.text.text = "Go Post";
    }
    
    public override void Run()
    {
       MoveToPost();
    }
    
    
    public void MoveToPost()
    {
        var distance = (Vector2.Distance(postman.transform.position, postman.post.transform.position));

        if (distance > 0.5f)
        {
            postman.MoveTo(postman.post.transform.position);
        }
        else
        {
            postman.SetState(postman.waitingForParcelState);
        }
    }
}
