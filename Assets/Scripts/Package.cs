using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{
    public bool onDelivery;
    
    
    private float _waitingTime;
    public List<Package> _ListPackage;
    public Package ssyl;
    
    void Start()
    {
        _waitingTime = Random.Range(10f, 30f);
        Debug.Log("Удалюсь через: " + _waitingTime);
    }

  
    void Update()
    {
       Timer(); 
    }

    private void Timer()
    {
        if (!onDelivery)
        {
            if (_waitingTime < 0)
            {
                _ListPackage.Remove(this);
                Destroy(gameObject);
            }
            _waitingTime -= Time.deltaTime;
        }
    }
}
