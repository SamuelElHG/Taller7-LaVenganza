using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeTextPlank : MonoBehaviour
{
    public TMP_Text resultText;
    public InteractablePlank otherScript;

    public void UpdateText(string inputText)
    {
        if (otherScript != null)
        {
            float value = otherScript.GetValue();
            resultText.text = $"{value}/4";
        }
    }
}
