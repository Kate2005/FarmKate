using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep: MonoBehaviour
{
    [SerializeField] private float startSpeed; 
    private float moveSpeed;
    [SerializeField] private Vector3 moveDirection;
    [SerializeField] private float force;
    private Rigidbody rb;
    private BoxCollider bc;
    [SerializeField] private GameObject particlesPrefab;
    [SerializeField] private Vector3 sheepOffset;
    [SerializeField] private float jumpForce;
    //идти или со€ть стартовое значение енума
    //создать екземпл€р и присвоить значение
    private void Awake()
    {

        rb = GetComponent<Rigidbody>();
        bc  = GetComponent<BoxCollider>();
    }

    private void Start()
    {
        moveSpeed = startSpeed;
    }

    void Update()
    {
        //проверить
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

    }
    public void SaveSheep()
    {
       
        
            rb.isKinematic = false;
            rb.AddForce(Vector3.up * force);

        //GetComponent<bc>();
        //enabled = false;
           moveSpeed = 0;//cjcnjzybtcnjg//1. ќтключить скорость овце на 0 или как в тракторе!!!!!!!!                         
        bc.enabled = false;//2. отключить бокс коллайдер овце
        rb.useGravity = false;//3. отключить гравитацию
        //4. —паунить патикл со здвигом над овцой или за овцой
        //спауним патикл в позиции овцы + sheepOffset
        GameObject particle = Instantiate(particlesPrefab, transform.position + sheepOffset, particlesPrefab.transform.rotation); //senoPrefab.transform.rotation
            Destroy(particle, 2f);
            Destroy(gameObject, 0.9f);               
    }
    public void JumpThoughtWater()
    {
        rb.isKinematic = false;   //стоп
        moveSpeed = 0;
        rb.AddForce(new Vector3(0f,1f,-1f) * jumpForce);
    }
    public void LandThoughtWater()
    {
        rb.isKinematic = true;
        moveSpeed = startSpeed;//идти
    }

}
