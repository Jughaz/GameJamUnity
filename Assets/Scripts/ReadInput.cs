using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour
{
    [SerializeField] InputField inputField;
    [SerializeField] Text resultText;

    string ValidInputs = ["Walk", "Run"];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ValidateInput(string s)
    {
        string input = inputField.text;

            if(input.Length < 4)
            {
                resultText.text = "Invalid input";
                resultText.color = Color.red;
            }
            else
            {
                resultText.text = inputField.text;
                resultText.color = Color.green;
            }
        }
}
