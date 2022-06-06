using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{
    public bool onDelivery;

    private float _waitingTime;
    
    [HideInInspector] public List<Package> _ListPackage;

    void Start()
    {
        _waitingTime = Random.Range(10f, 30f);
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
                DeletePackage();
            }
            _waitingTime -= Time.deltaTime;
        }
    }

    public void DeletePackage()
    {
        _ListPackage.Remove(this);
        Destroy(gameObject);
    }
}
