using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    public Nutrition nutrition;
    public bool CanSpawnCopy = true;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    //public bool IsPickedUp = false;
    public void ToggleKinematic(bool b)
    {
        rb.isKinematic = b;
    }




}
