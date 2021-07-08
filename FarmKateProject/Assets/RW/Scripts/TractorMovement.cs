using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorMovement : MonoBehaviour
{
    [Header("Shoot Property")]
    [SerializeField] private GameObject senoPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float shootRate;
    private float nextShoot;
    [SerializeField] private Transform senoContainer;

    [Header("Tractor Property")]
    [SerializeField] private float speed;
    [SerializeField] private float bounds;
    private float direction;
    private bool isPress;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (isPress)
        {
            if (((transform.position.x > -bounds) && (direction == 1f)) || ((transform.position.x < bounds) && (direction == -1f)))
            {
                transform.Translate(Vector3.left * speed * direction * Time.deltaTime);
            }
        }
        
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
        if (Time.time > nextShoot)
        {
            nextShoot = Time.time + shootRate;
            GameObject seno = Instantiate(senoPrefab, spawnPoint.position, Quaternion.identity); //senoPrefab.transform.rotation
            Destroy(seno, 15f);
            seno.transform.SetParent(senoContainer.transform);


        }
    }

}
