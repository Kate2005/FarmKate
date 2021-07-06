using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private float shoot;
    private bool isPress;

    void Start()
    {
        
    }


    void Update()
    {
        public void PressShoot()
        {
            
            isPress = true;

        }
        Debug.Log(Shoot);

        public void StopPress()
        {
            isPress = false;
        }
    }
}
