using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorMovement : MonoBehaviour
{
    enum TractorCondition { Move, Stay}
    TractorCondition tractorCondition = TractorCondition.Stay;
    
    [SerializeField] private SoundManeger soundManeger;
  




    [SerializeField] private GameObject senoPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float shootRate;
    private float nextShoot;
    [SerializeField] private Transform senoContainer;
    

    [Header("Tractor Property")]
    [SerializeField] private float speed;
    [SerializeField] private float bounds;
    private float direction;

    [Header("SenoPool")]
    [SerializeField] private int senoPoolSize;
    [SerializeField] List<GameObject> senos;
    private int currentSenoIndext;
    //private bool isPress;
    //[SerializeField] private float maxAmmo;
    // private int currentAmmo;
    //[SerializeField] private int Ammo = 5;
    private void Awake()
    {
        senos = new List<GameObject>();
    }



    void Start()
    {
        for (int i = 0; i < senoPoolSize; i++)
        {
            senos.Add(Instantiate(senoPrefab));
            senos[i].transform.SetParent(senoContainer.transform);
            senos[i].SetActive(false);
        }
    }

    
    void Update()
    {
        if (tractorCondition == TractorCondition.Move)
        {
            if (((transform.position.x > -bounds) && (direction == 1f)) || ((transform.position.x < bounds) && (direction == -1f)))
            {
                transform.Translate(Vector3.left * speed * direction * Time.deltaTime);
            }
        }
        //if (currentAmmo <= 0)
        //{
        //    StartCoroutine(Spawn()); 
            
        //}
    }


    public void PressLeft()
    {
        direction = 1f;
        tractorCondition = TractorCondition.Move;
       //soundManeger.PlayArrowClickingClip();
    }
    public void PressRight()
    {
        direction = -1f;
        tractorCondition = TractorCondition.Move;
       // soundManeger.PlayArrowClickingClip();
    }
    public void StopPress()
    {
        tractorCondition = TractorCondition.Stay;
    }
    

    public void PressShoot()
    {
        if (Time.time > nextShoot)
        {
            nextShoot = Time.time + shootRate;

            senos[currentSenoIndext].transform.position = spawnPoint.position;
            senos[currentSenoIndext].SetActive(true);

            currentSenoIndext++;
            if(currentSenoIndext >= senoPoolSize)
            {
                currentSenoIndext = 0;
            }
            //GameObject seno = Instantiate(senoPrefab, spawnPoint.position, Quaternion.identity); //senoPrefab.transform.rotation
            //Destroy(seno, 15f);

            soundManeger.PlayShootClip();


        }
        //if (Ammo > 0)
        //{
        //    Shoot ();
        //    Ammo = Ammo - 1;
        //}
            


        
    }

}
