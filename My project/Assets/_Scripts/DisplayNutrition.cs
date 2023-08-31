using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayNutrition : MonoBehaviour
{
    public static DisplayNutrition instance;

    Nutrition nutrition;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI calorieText;
    public TextMeshProUGUI fatText;
    public TextMeshProUGUI transFatText;
    public TextMeshProUGUI cholText;
    public TextMeshProUGUI sodiumText;
    public TextMeshProUGUI carbText;
    public TextMeshProUGUI fibreText;
    public TextMeshProUGUI sugarText;
    public TextMeshProUGUI proteinText;
    public TextMeshProUGUI calciumText;
    public TextMeshProUGUI ironText;

    private void Awake()
    {
        instance= this;
    }


    public void ChangeNutritionReference(Nutrition newNutrition)
    {
        nutrition = newNutrition;

        // Update the UI display with the new nutrition values
        UpdateUI();
    }
    void UpdateUI()
    {
        nameText.text = nutrition.foodName;
        calorieText.text = nutrition.calories.ToString();
        fatText.text = nutrition.fat.ToString();
        transFatText.text = nutrition.transFat.ToString();
        cholText.text = nutrition.chol.ToString();
        sodiumText.text = nutrition.sodium.ToString();
        carbText.text = nutrition.carb.ToString();
        fibreText.text = nutrition.fibre.ToString();
        sugarText.text = nutrition.sugar.ToString();
        proteinText.text = nutrition.protein.ToString();
        calciumText.text = nutrition.calcium.ToString();
        ironText.text = nutrition.iron.ToString();
    }


}
