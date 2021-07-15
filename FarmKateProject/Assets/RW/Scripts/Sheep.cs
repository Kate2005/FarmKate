using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep: MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Vector3 moveDirection;
    [SerializeField] private float force;
    private Rigidbody rb;
    [SerializeField] private GameObject particlesPrefab;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
    public void SaveSheep()
    {
       
        
            rb.isKinematic = false;
            rb.AddForce(Vector3.up * force);
            ///////////////////////// ��� ������
            //1. ��������� �������� ���� �� 0 ��� ��� � ��������
            //2. ��������� ���� ��������� ����
            //3. ��������� ����������
            //4. �������� ������ �� ������� ��� ����� ��� �� �����
            //������� ������ � ������� ����
            GameObject particle = Instantiate(particlesPrefab, transform.position, particlesPrefab.transform.rotation); //senoPrefab.transform.rotation
            Destroy(particle, 2f);
            Destroy(gameObject, 0.9f);
        
        
    }
}
