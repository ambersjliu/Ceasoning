using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public Rigidbody obj;
    bool fire;

    private void Update()
    {
        float triggerLeft = OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger);
        float triggerRight = OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger);

        if (triggerRight > 0.9 && !fire)
        {
            fire = true;
            Instantiate(obj, new Vector3(Random.Range(-3, 3), Random.Range(1, 4), Random.Range(-3, 3)), Quaternion.identity);
        }
        if (fire  && triggerRight < 0.1f)
        {
            fire = false;
        }
    }
}
