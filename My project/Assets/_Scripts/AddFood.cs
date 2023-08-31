using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFood : MonoBehaviour
{

    public static AddFood instance;
    //might need smthing to reset values but that will be ez!
    public double calories;
    public double fat;
    public double transFat;
    public double chol;
    public double sodium;
    public double carbs;
    public double fibre;
    public double sugar;
    public double protein;
    public double calcium;
    public double iron;

    private void Awake()
    {
        instance = this;
    }


    private void Start()
    {
        Reset();
        
    }


    public void Add()
    {
        List<GameObject> list = FoodTracker.instance.Foods;
        foreach (GameObject food in list)
        {
            Nutrition nutrition = food.GetComponent<FoodScript>().nutrition;
            calories+= nutrition.calories;
            fat+= nutrition.fat;
            transFat+= nutrition.transFat;
            chol += nutrition.chol;
            sodium+= nutrition.sodium;
            carbs += nutrition.carb;
            fibre += nutrition.fibre;
            sugar += nutrition.sugar;
            protein+= nutrition.protein;
            calcium += nutrition.calcium;
            iron += nutrition.iron;
        }

    }

    public void Reset()
    {
        //For when a reset is necessary -> game start, after food is removed.
        calories = 0f; fat = 0f; transFat = 0f; chol = 0f; sodium = 0f; 
        fibre = 0f; sugar = 0f; protein = 0f; calcium = 0f; iron = 0f; carbs = 0f;
    }
}