using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpThroughtWater : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Sheep sheep = other.gameObject.GetComponent<Sheep>();
        if (sheep != null)
        {
            sheep.JumpThoughtWater();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
