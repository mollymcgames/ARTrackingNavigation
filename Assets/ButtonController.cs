using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button myButton; // Reference to your Button component

    void Start()
    {
        // Assuming you have already assigned the Button component in the Inspector
        if (myButton != null)
        {
            // Disable the button initially
            myButton.interactable = false;
        }
    }
}
