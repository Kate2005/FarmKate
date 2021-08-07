using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator2 : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    [SerializeField] private Vector3 rotateAxis;
    private Transform HeyBaleTrans;
    void Start()
    {
        HeyBaleTrans = transform.GetChild(0); 
    }

    // Update is called once per frame
    void Update()
    {
       HeyBaleTrans.transform.Rotate(rotateAxis * rotateSpeed* Time.deltaTime);
    }
}
