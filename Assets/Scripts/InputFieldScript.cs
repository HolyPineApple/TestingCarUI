using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldScript : MonoBehaviour
{
    public GameObject _panelInput;
    public InputField _inputField;
    public Text _changeText;

    public void SaveInput()
    {
        if(_inputField.text=="")
        {
            Debug.Log("ERROR");
        }
        else
        {
            Debug.Log("GREAT");
            _changeText.text = _inputField.text;
            _panelInput.SetActive(false);
        }
    }
}
