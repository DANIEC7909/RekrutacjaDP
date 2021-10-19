using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CalculateValue : MonoBehaviour
{
   [SerializeField] TextMeshProUGUI text;
   [SerializeField] TMP_InputField input;
 
   public void CalculateVal()
    {
        int number = 0;

        if (string.IsNullOrEmpty(input.text))//check is inputField empty
        {
            number = 0;
        }
        else
        {
            number = int.Parse(input.text);//prase string to int
        }
        #region DO MATH
        if (number % 5 == 0 && number % 3 == 0)
        {
            text.text = "Marco Polo";
        }
        else if (number % 5 == 0)
        {
            text.text = "Polo";
        }else if (number % 3 == 0 )
        {
            text.text = "Marco";
        }
        #endregion
        if (number== 0)
        {
            text.text = "";
        }//if num=0 clear text field
    }
}
