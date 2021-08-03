using UnityEngine.Events;
using UnityEngine;

public class CollisionTractorWithSheep : MonoBehaviour
{
    [SerializeField] private SoundManeger soundManeger;
   // [SerializeField] private UnityEvent SaveSheepEvent;

    private void OnTriggerEnter(Collider other)
    {
        Sheep sheep = other.gameObject.GetComponent<Sheep>();

        if (sheep != null)
        {
             sheep.DestroySheep();
            //SaveSheepEvent.Invoke();
        }
        soundManeger.PlayShootClip();


    }
}
