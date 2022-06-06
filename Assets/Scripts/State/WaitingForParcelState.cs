using UnityEngine;

[CreateAssetMenu(menuName = "State/Waiting For a Parcel State", fileName = "WaitingForParcelState")]
public class WaitingForParcelState : State
{
    public override void Init()
    {
        postman.text.text = "Waiting For Parcel";
    }

    public override void Run()
    {
        TakeParcel();
    }
    
    public void TakeParcel()
    {
        if (postman.post.packages.Count != 0)
        {
            postman.currentAddres = postman.post.addresList[Random.Range(0, postman.post.addresList.Count)];
            if (postman.currentAddres.isClosed)
            {
                TakeParcel();
            }
            else
            {
                postman.post.packages[0].DeletePackage();
                postman.SetState(postman.deveryToAddresState);
            }
        }
    }
}
