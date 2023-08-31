using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTracker : MonoBehaviour
{
    public static FoodTracker instance;
    //Consider replacing List with Hashset instead to avoid duplicate elements
    //...Of course I could also just check that in the "add" condition.
    public List<GameObject> Foods;
    //Consider creating an Event each time a new food is added to the list and subscribing to it in AddFood

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        Foods = new List<GameObject>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food") && !Foods.Contains(other.gameObject))
        {
            Debug.Log("Collision");
            Foods.Add(other.gameObject);
            AudioController.instance.Play("Pot");
            // Print the names of the foods
            PrintFoodNames();
            
        }
    }

    public void Reset()
    {
        Foods.Clear();
    }
    
    public void DestroyFoods()
    {
        foreach (GameObject f in Foods)
        {
            Destroy(f);
        }
        Reset();  
    }

    private void PrintFoodNames()
    {
        foreach (GameObject f in Foods)
        {
            FoodScript foodScript = f.GetComponent<FoodScript>();
            Debug.Log(foodScript.nutrition.foodName);
        }
    }
}
