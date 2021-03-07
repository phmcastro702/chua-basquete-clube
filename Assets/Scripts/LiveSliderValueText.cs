using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LiveSliderValueText : MonoBehaviour
{

    private TextMeshProUGUI valueText;

    private void Start() 
    {
        valueText = transform.GetComponent<TextMeshProUGUI>();
        Debug.Log(valueText.transform.name);

    }

    public void OnAngleValueChanged(float value)
    {
        value = Mathf.RoundToInt(value);
        valueText.text = $"{value}°";

    }

    public void OnForceValueChanged(float value)
    {
        valueText.text = $"{value}f";
    }
}
