using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : MonoBehaviour
{
    [SerializeField] private SheepProperty sheepProperty;

    //[SerializeField] private float startSpeed;    
    [SerializeField] private Vector3 moveDirection;
    [SerializeField] private float force;
    [SerializeField] private GameObject particlesPrefab;
    [SerializeField] private Vector3 sheepOffset;
    [SerializeField] private float jumpForce;
    private float moveSpeed;
    private Rigidbody rb;
    private BoxCollider bc;
    private MeshRenderer mr;
    //public enum Movement { move, stay, jump }
    //Movement movement = Movement.move;
    //Movement stayMovement = Movement.stay;
    //идти или со€ть стартовое значение енума
    //создать екземпл€р и присвоить значение
    private void Awake()
    {

        rb = GetComponent<Rigidbody>();
        bc = GetComponent<BoxCollider>();
        mr = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        moveSpeed = sheepProperty.Speed;
        mr.material = sheepProperty.Material;
        
        Debug.Log(sheepProperty.Name);//get
        sheepProperty.Name = "Shon";//set
        Debug.Log(sheepProperty.Name);//get

    }

    void Update()
    {
        //проверить состо€ние и идти только если состо€ние идти
        //if (movement == Movement.move)
        //{
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        //}
    }
    public void SaveSheep()
    {


        rb.isKinematic = false;
        rb.AddForce(Vector3.up * force);
        moveSpeed = 0;//сделать состо€ние стоп//1. ќтключить скорость овце на 0 или как в тракторе!!!!!!!!
        //if (stayMovement == Movement.stay)
        //{
        //    moveSpeed = 0;
        //}
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
        rb.isKinematic = false;   //состо€ние стоп
        moveSpeed = 0;
        //if (stayMovement == Movement.stay)
        //{
        rb.AddForce(new Vector3(0f, 1f, -1f) * jumpForce);
        //}

    }
    public void LandThoughtWater()
    {
        rb.isKinematic = true;
        moveSpeed = sheepProperty.Speed;//состо€ние идти
        //movement = Movement.move
    }
    public void Size()
    {
       
        transform.localScale = new Vector3(1.2f, 0, 0);
       
    }
}
