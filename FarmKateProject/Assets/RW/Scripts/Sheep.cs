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
    //public enum Movement { move, stay, jump}
    //Movement movement = Movement.move
    
    //���� ��� ����� ��������� �������� �����
    //������� ��������� � ��������� ��������
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
        //��������� ��������� � ���� ������ ���� ��������� ����
        //if (movement == Movement.move)
        //{
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        //}
    }
    public void SaveSheep()
    {
       
        
        rb.isKinematic = false;
        rb.AddForce(Vector3.up * force);
        moveSpeed = 0;//������� ��������� ����//1. ��������� �������� ���� �� 0 ��� ��� � ��������!!!!!!!!
        //if (stayMovement == Movement.stay)
        //{
        //    moveSpeed = false; 
       // }
        bc.enabled = false;//2. ��������� ���� ��������� ����
        rb.useGravity = false;//3. ��������� ����������
        //4. �������� ������ �� ������� ��� ����� ��� �� �����
        //������� ������ � ������� ���� + sheepOffset
        GameObject particle = Instantiate(particlesPrefab, transform.position + sheepOffset, particlesPrefab.transform.rotation); //senoPrefab.transform.rotation
            Destroy(particle, 2f);
            Destroy(gameObject, 0.9f);               
    }
    public void JumpThoughtWater()
    {
        rb.isKinematic = false;   //��������� ����
        moveSpeed = 0;
        //if (stayMovement == Movement.stay)
        //{
            rb.AddForce(new Vector3(0f, 1f, -1f) * jumpForce);
        //}
        
    }
    public void LandThoughtWater()
    {
        rb.isKinematic = true;
        moveSpeed = startSpeed;//��������� ����
        //moveMovement = Movement.move
    }

}
