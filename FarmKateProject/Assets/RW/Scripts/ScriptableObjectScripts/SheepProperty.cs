using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SheepProperty", menuName = "ScriptableObjects/newSheepProperty")]
public class SheepProperty : ScriptableObject
{
    [SerializeField] private string sheepName;
    [SerializeField] private float speed;
    [SerializeField] private Material material;
    [SerializeField] private float size;
    
    
    public string Name
    {
        get
        {
            if(sheepName =="")
            {
                Debug.LogWarning("No SheepName");
                return "None Name";
            }
            return sheepName;

        }
        set
        {
            sheepName = value;
        }
    }

    public float Speed
    {
        get
        {
            if (speed == 0)
            {
                return 5f;
            }
            else
            {
                return speed;
            }

        }
        //private set
        //{
        //    speed = value;
        //}
    }
    
    //public Material Material {get{return matirial;}}//короткая форма записи       
    public Material Material => material; // get
    public Vector3 Size
    {
        get 
        {
            return new Vector3(size, size, size);
        }     
    }
   
}

