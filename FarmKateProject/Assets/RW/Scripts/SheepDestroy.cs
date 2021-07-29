using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepDestroy : MonoBehaviour
{
    [SerializeField] private SoundManeger soundManeger;

    private void OnTriggerEnter(Collider other)
    {
        Sheep sheep = other.gameObject.GetComponent<Sheep>();

        if (sheep != null)
        {
          
            Destroy(other.gameObject);
        }
        soundManeger.PlayDropClip();
    }
}
