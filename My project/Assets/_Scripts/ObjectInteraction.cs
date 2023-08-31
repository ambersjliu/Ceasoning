using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class ObjectInteraction : MonoBehaviour
{
    string FoodTag = "Food";
    public Transform RControllerTransform;
    public Transform LControllerTransform;
    public float dist = 5f;

    [SerializeField] Canvas FactsLabel;

    bool held = false;
    private GameObject heldObject;

    private void Start()
    {
        
    }

    private void Update()
    {
        //float triggerLeft = OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger);
        float triggerRight = OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger);

       

        if (triggerRight > 0.9f && !held)
        {
            held = true;

            if (heldObject == null)
            {
                PickUp(RControllerTransform);
            }
            else
            {

                Drop();
            }

        }
        if(held && triggerRight < 0.1f)
        {
            held = false;
        }
       
    }

    void PickUp(Transform controllerTransform)
    {
        RaycastHit hit;
        if (Physics.Raycast(controllerTransform.position, controllerTransform.forward, out hit, dist))
        {
            if (hit.collider.CompareTag(FoodTag))
            {
                FoodScript foodScript = hit.collider.GetComponent<FoodScript>();
                FactsLabel.gameObject.SetActive(true);
                DisplayNutrition.instance.ChangeNutritionReference(foodScript.nutrition);
                AudioController.instance.Play("Pop");
                // Check if it's the original food item or a copy
                if (foodScript.CanSpawnCopy)
                {
                    // Instantiate a new copy of the food object and parent it to the controller
                    heldObject = Instantiate(hit.collider.gameObject);
                    heldObject.transform.SetParent(controllerTransform);

                    // Set CanSpawnCopy to false and toggle rb kinematic for the newly spawned copy
                    FoodScript copyFoodScript = heldObject.GetComponent<FoodScript>();
                    copyFoodScript.CanSpawnCopy = false;
                    copyFoodScript.ToggleKinematic(true);
                }
                else
                {
                    // Pick up the existing copied object
                    heldObject = hit.collider.gameObject;
                    FoodScript copyFoodScript = heldObject.GetComponent<FoodScript>();
                    copyFoodScript.ToggleKinematic(true);
                    heldObject.transform.SetParent(controllerTransform);
                }

            }
        }
    }


    void Drop()
    {
        // Drop the held object by setting its parent to null
        heldObject.transform.SetParent(null);
        FoodScript copyFoodScript = heldObject.GetComponent<FoodScript>();
        copyFoodScript.ToggleKinematic(false);
        FactsLabel.gameObject.SetActive(false);

        heldObject = null;
    }

}
