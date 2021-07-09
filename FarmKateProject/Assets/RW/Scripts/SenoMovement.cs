using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenoMovement : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    [SerializeField] private Vector3 rotateDirection;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Vector3 moveDirection;
    private Transform senoModel;

    void Start()
    {
        senoModel = transform.GetChild(0);
    }

    
    void Update()
    {
        transform.Translate(moveSpeed * moveDirection * Time.deltaTime);
        senoModel.transform.Rotate(rotateSpeed * rotateDirection * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SenoDestroydTrigger")//Other.CompareTag("SenoDestroydTrigger")
        {
            Destroy(gameObject);   
        }
        //if (other.gameObject.name == "SenoDestroydTrigger")
        //{
        //    Destroy(gameObject);          
        //}
        
        private void OnCollisionEnter(Collider other)
        {
            if (other.gameObject.tag == "SenoDestroys")//Other.CompareTag("SenoDestroydTrigger")
            {
                Destroy(gameObject);
            }

        }
    }


}
