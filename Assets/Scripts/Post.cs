using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Post : MonoBehaviour
{
    public List<Package> _packages;
    void Start()
    {
        StartCoroutine(ParcelGenerator());
    }

  
    void Update()
    {
        
    }

    IEnumerator ParcelGenerator()
    {
        while (true)
        {
            var time = Random.Range(5f, 10f);
            Debug.Log(time);
            yield return new WaitForSeconds(time);
            var package = new GameObject().AddComponent<Package>();
            package.GetComponent<Package>()._ListPackage = _packages;
            _packages.Add(package);
            Debug.Log("+1");
        }
    }
    
}
