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

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed * moveDirection * Time.deltaTime);
        senoModel.transform.Rotate(rotateSpeed * rotateDirection * Time.deltaTime);
    }
}
