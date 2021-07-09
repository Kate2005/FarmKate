using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenoDestroys : MonoBehaviour
{
  
  private void Collision(Collider other)
    {
        if(other.gameObject.name == "Hay Bale")
        {
            Destroy(other.gameObject);
        }
       
    }

}
