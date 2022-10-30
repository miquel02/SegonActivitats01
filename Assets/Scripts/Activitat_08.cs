using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;

public class Activitat_08 : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI message;

    public void ConfirmUsername()
    {
        // Checks if the input field is empty.
        if (!(inputField.text == ""))
        {
            // Display a message on the screen.
            message.text = "Hello " + inputField.text + ", welcome to this amazing adventure!";
        }
    }
}
