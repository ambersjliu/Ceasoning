using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCanvas : MonoBehaviour
{

    public bool DisableOnStart;
    // Start is called before the first frame update
    void Start()
    {
        if (DisableOnStart)
        {
            Disable();
        }

    }

    public void Disable()
    {
        gameObject.SetActive(false);
    }


}
