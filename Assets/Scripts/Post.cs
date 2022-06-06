using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Post : MonoBehaviour
{
    public List<Addres> addresList;
    [HideInInspector] public List<Package> packages;
    void Start()
    {
        StartCoroutine(ParcelGenerator());
    }
    
    IEnumerator ParcelGenerator()
    {
        while (true)
        {
            if (packages.Count < 21)
            {
                var time = Random.Range(5f, 10f);
                yield return new WaitForSeconds(time);
                var package = new GameObject().AddComponent<Package>();
                package.GetComponent<Package>()._ListPackage = packages;
                packages.Add(package);
            }
        }
    }
}
