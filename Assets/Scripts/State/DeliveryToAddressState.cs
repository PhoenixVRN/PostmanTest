using UnityEngine;

[CreateAssetMenu(menuName = "State/Delivery To Address State", fileName = "DeliveryToAddressState")]
public class DeliveryToAddressState : State
{
    
    public override void Init()
    {
        postman.text.text = "Go To Address";
    }
    
    public override void Run()
    {
        MoveToAddress();
    }
    
    public  void MoveToAddress()
    {
        var distance = (Vector2.Distance(postman.transform.position, postman.currentAddres.transform.position));
        
        if (postman.currentAddres.isClosed)
        {
            postman.SetState(postman.commingBackState);
        }
        if (distance > 0.5f)
        {
            postman.MoveTo(postman.currentAddres.transform.position);
        }
        else
        {
            postman.currentPackage = null;
            postman.SetState(postman.commingBackState);
        }
    }
}
