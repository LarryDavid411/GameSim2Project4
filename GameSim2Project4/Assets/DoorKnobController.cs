using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKnobController : MonoBehaviour
{
    public int knobSequence;
    public GameObject levelAttributes;
    public int knobType;
    public Material redMaterial;
    public Material greenMaterial;
    public enum KnobState
    {
        Green,
        Red
    }

    public KnobState knobState;

    public void DoorKnobUpdate()
    {
        //Material rend = GetComponent<Renderer>().material;
        switch (knobState)
        {
            case KnobState.Green:
            {
                gameObject.GetComponent<Renderer>().material = greenMaterial;
            } break;

            case KnobState.Red:
            {
                gameObject.GetComponent<Renderer>().material = redMaterial;
            } break;
        }
    }

}
