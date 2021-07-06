using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorMovement1 : MonoBehaviour
{
    [Header("Shoot Property")]
    [SerializeField] private GameObject senoPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float shootRate;
    private float nextShoot;

    [Header("Tractor Property")]
    [SerializeField] private float speed;
    [SerializeField] private float bounds;
    private float direction;
    private bool isPress;

    void Start()
    {
        nextShoot = shootRate;
    }

    
    void Update()
    {
        //if (((transform.position.x > -bounds) && (direction == 1f)) || ((transform.position.x < bounds) && (direction == -1f)))
        //{
        //    transform.Translate(Vector3.left * speed * direction * Time.deltaTime);           
        //}
        if (isPress)
        {
            if (((transform.position.x > -bounds) && (direction == 1f)) || ((transform.position.x < bounds) && (direction == -1f)))
            {
                transform.Translate(Vector3.left * speed * direction * Time.deltaTime);
            }
        }
        nextShoot += Time.deltaTime;
    }


    public void PressLeft()
    {
        direction = 1f;
        isPress = true;
    }
    public void PressRight()
    {
        direction = -1f;
        isPress = true;
    }
    public void StopPress()
    {
        isPress = false;
    }
    public void PressShoot()
    {
        if (nextShoot < shootRate)
        {
            GameObject seno = Instantiate(senoPrefab, spawnPoint.position, Quaternion.identity); //senoPrefab.transform.rotation
            Destroy(seno, 15f);
            nextShoot = 0;
        }
    }

}
