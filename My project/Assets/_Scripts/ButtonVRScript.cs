using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVRScript : MonoBehaviour
{

    public GameObject button;
    public Canvas canvas;
    public TMP_Text text;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isPressed;
    // Start is called before the first frame update
    void Start()
    {
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            AudioController.instance.Play("Button");
            onPress.Invoke();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == presser) {

            button.transform.localPosition = new Vector3(0, 0.015f, 0);
            onRelease.Invoke();
            isPressed = false;
                
        }
    }

    public void DisplayAddedNutrients()
    {
        canvas.gameObject.SetActive(true);
        AddFood.instance.Reset();
        AddFood.instance.Add();
        DisplayMessage.Instance.OnButtonPress();
    }
}
