using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Texts : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI inputText;
    [SerializeField] private TextMeshProUGUI finalText;

    public void LoadText()
    {
        finalText.text = inputText.text;
    }
}
