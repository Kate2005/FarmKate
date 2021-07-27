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
    [SerializeField] private List<Transform> propertyPoints;
    
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
            return speed;

        }
        //private set
        //{
        //    speed = value;
        //}
    }
    
    //public Material Material {get{return matirial;}}//короткая форма записи       
    public Material Material => material; // get
    public float Size
    {
        get 
        {
            return size;
        }
        set
        {
            size = value;
        }
    }
   
}

