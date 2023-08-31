using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Food", menuName = "New Food")]
public class Nutrition : ScriptableObject
{
    public string foodName;
    public string serving;
    public double calories;

    #region Daily Values
    [Header("Daily Values")]

    //Ideally there should be a way to calculate these values from the gram values alone!
    //We should be able to derive one from another...
    //public int fatDV;
    //public int satFatDV;

    //public int fiberDV;
    //public int sugarDV;

    //public int sodiumDV;

    //public int potassiumDV;
    //public int calciumDV;
    //public int ironDV;


    #endregion

    #region Gram Values
    [Header("Gram Values")]
    public double fat;
    public double transFat;
    public double chol;
    public double sodium;
    public double carb;
    public double fibre;
    public double sugar;
    public double protein;
    public double calcium;
    public double iron;
    #endregion

}
