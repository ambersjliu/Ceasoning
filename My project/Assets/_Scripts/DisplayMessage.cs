using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMessage : MonoBehaviour
{
    public static DisplayMessage Instance;
    public int points;

    [SerializeField] public TextMeshProUGUI messageCal;
    [SerializeField] public TextMeshProUGUI messageFat;
    [SerializeField] public TextMeshProUGUI messageSatTransFat;
    [SerializeField] public TextMeshProUGUI messageChol;
    [SerializeField] public TextMeshProUGUI messageSodium;
    [SerializeField] public TextMeshProUGUI messageCarbs;
    [SerializeField] public TextMeshProUGUI messageFibre;
    [SerializeField] public TextMeshProUGUI messageSugar;
    [SerializeField] public TextMeshProUGUI messageProtein;
    [SerializeField] public TextMeshProUGUI messageCalcium;
    [SerializeField] public TextMeshProUGUI messageIron;
    [SerializeField] public TextMeshProUGUI messagePoints;

    private void Awake()
    {
        Instance = this;
        ResetPoints();
    }

    public void ResetPoints()
    {
        points = 0;
    }

    public void OnButtonPress()
    {
        double calories = AddFood.instance.calories;
        double fat = AddFood.instance.fat;
        double satTransFat = AddFood.instance.transFat;
        double chol = AddFood.instance.chol;
        double sodium = AddFood.instance.sodium;
        double carbs = AddFood.instance.carbs;
        double fibre = AddFood.instance.fibre;
        double sugar = AddFood.instance.sugar;
        double protein = AddFood.instance.protein;
        double calcium = AddFood.instance.calcium;
        double iron = AddFood.instance.iron;
        CheckCalories(calories);
        CheckFat(fat);
        CheckSatTransFat(satTransFat);
        CheckChol(chol);
        CheckSodium(sodium);
        CheckCarbs(carbs);
        CheckFibre(fibre);
        CheckSugar(sugar);
        CheckProtein(protein);
        CheckCalcium(calcium);
        CheckIron(iron);
        WritePoints();
    }


    private void WritePoints()
    {
        messagePoints.text = "Points: " + points.ToString() + "/11";
    }

    private void CheckIron(double iron)
    {
        if (iron > 14)
        {
            points--;
            messageIron.text = "You have too much iron";
        }
        else if (iron == 14)
        {
            messageIron.text = "No iron! Try to get more!";
        }
        else
        {
            points++;
            messageIron.text = "Iron looks OK! Try to get more!";
        }
    }

    private void CheckCalcium(double calcium)
    {
        if (calcium > 1100)
        {
            points--;
            messageCalcium.text = "You have too much calcium in your meal!";
        }
        else if (calcium == 0)
        {
            messageCalcium.text = "No calcium! How are your bones?";
        }
        else
        {
            points++;
            messageCalcium.text = "Calcium looks ok! Healthy bones!";
        }
    }

    private void CheckProtein(double protein)
    {
        if (protein > 50)
        {
            points--;
            messageProtein.text = "You have too much protein";
        }
        else if (protein == 0)
        {
            messageProtein.text = "No protein! Try to get more!";
        }
        else
        {
            points++;
            messageProtein.text = "Protein looks ok, try to get more!";
        }
    }

    private void CheckSugar(double sugar)
    {
        if (sugar > 28)
        {
            points--;
            messageSugar.text = "TOO SWEET! too much sugar for the day";
        }
        else if (sugar == 0)
        {
            messageSugar.text = "No sugar! Flash those pearly whites!";
        }
        else
        {
            points++;
            messageSugar.text = "Sugar looks OK!";
        }
    }

    private void CheckFibre(double fibre)
    {
        if (fibre > 25)
        {
            points--;
            messageFibre.text = "You have too much fibre in your meal!";
        }
        else if (fibre == 0)
        {
            messageFibre.text = "No fibre! Don't get constipated!";
        }
        else
        {
            points++;
            messageFibre.text = "Fibre looks OK! Try to get more :)";
        }
    }

    private void CheckCarbs(double carbs)
    {
        if (carbs > 300)
        {
            points--;
            messageCarbs.text = "Too many carbs for you!";
        }
        else if (carbs == 0)
        {
            messageCarbs.text = "No carbs!";
        }
        else
        {
            points++;
            messageCarbs.text = "Carbs look good!";
        }
    }

    private void CheckSodium(double sodium)
    {
        if (sodium > 2400)
        {
            points--;
            messageSodium.text = "Uh oh too salty haha (TOO MUCH SODIUM)";
        }
        else if (sodium == 0)
        {
            messageSodium.text = "No sodium!";
        }
        else
        {
            points++;
            messageSodium.text = "Sodium looks OK!";
        }
    }

    private void CheckChol(double chol)
    {
        if (chol > 200)
        {
            points--;
            messageChol.text = "Too much cholesterol!!!";
        }
        else if (chol == 0)
        {
            messageChol.text = "No cholesterol! Good!";
        }
        else
        {
            points++;
            messageChol.text = "Some cholesterol! Try to reduce!";
        }
    }

    private void CheckSatTransFat(double satTransFat)
    {
        if (satTransFat > 22)
        {
            points--;
            messageSatTransFat.text = "Too much saturated and trans fat~!";
        }
        else if (satTransFat == 0)
        {
            messageSatTransFat.text = "No saturated or trans fat! Good!!";
        }
        else
        {
            points--;
            messageSatTransFat.text = "Some sat. and trans fat, try to reduce!";
        }
    }

    private void CheckFat(double fat)
    {
        if (fat > 60)
        {
            points--;
            messageFat.text = "You have too much total fat!";
        }
        else if (fat == 0)
        {
            messageFat.text = "No fat!";
        }
        else
        {
            points++;
            messageFat.text = "Total fat looks OK!";
        }
    }

    private void CheckCalories(double calories)
    {
        if (calories > 2000)
        {
            points--;
            messageCal.text = "You have too many calories!";
        }
        else if (calories == 0)
        {
            messageCal.text = "No calories!";
        }
        else
        {
            points++;
            messageCal.text = "Calories look good!";
        }
    }

}
