using TMPro;
using UnityEngine;

public class Postman : MonoBehaviour
{
    [Header("Initial Parametrs")]
    public State idleState;
    public State waitingForParcelState;
    public State deveryToAddresState;
    public State commingBackState;
    public State startState;
    
    public State pastState;

    public Post post;
    public float speedPostman;
    
    public Addres currentAddres;
    public Package currentPackage;
    
    public float workingTime = 120f;
    
    [Header("Actual state")] 
    public State currentState;
    
    [HideInInspector] public TextMeshPro text;
    
    void Start()
    {
        text = GetComponentInChildren<TextMeshPro>();
        SetState(startState);
    }

   
    void Update()
    {
        RunState();
        WorkingHours();  
    }

    private void WorkingHours()
    {
        workingTime -= Time.deltaTime;
        
        if (workingTime < 0)
        {
            pastState = currentState;
            workingTime = 120;
            SetState(idleState);
        }
    }

    private void RunState()
    {
        if (!currentState.isFinished)
        {
            currentState.Run();
        }
    }
    
    public void SetState(State state)
    {
        currentState = Instantiate(state);
        currentState.postman = this;
        currentState.Init();
    }
    
    private void OnMouseDown()
    {
        if (text.text != "Idle") SetState(commingBackState);
    }

    public void MoveTo(Vector2 addres)
    {
        transform.position = Vector2.MoveTowards(transform.position,
            addres,
            speedPostman * Time.deltaTime);
    }
}
