using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryToAddressState : State
{
    
    public void Init()
    {
        
    }
    
    public override void Run()
    {
        
    }
    
    public void MoveToAddres(Transform addres)
    {
        var distance = (Vector2.Distance(postman.transform.position, addres.transform.position));

        if (distance > 0.5f)
        {
//            TODO идем дальше
        }
        else
        {
            //           TODO отдаем посылку.
        }
    }
}
