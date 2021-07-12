using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenoDestroys : MonoBehaviour
{
    private Transform senoModel;

    void Start()
    {
        senoModel = transform.GetChild(0);
    }

    private void CollisionExit(Collision other)
    {
        if(other.gameObject.name == "Hay Bale")
        {
            Destroy(other.gameObject);
        }
       
    }

}
