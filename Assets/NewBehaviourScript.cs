using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    #region Vars
    int numberleft;
    int numberright;
    int CalculationResult;
    string operation;

    // Текст для вывода результата
    public TextMeshProUGUI Result;

    // Текст для вывода бобика
    public TextMeshProUGUI Bobik;


    #endregion

    #region Methods

    // Start is called before the first frame update
    void Start()
    {
        numberleft = 0;
        numberright = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (operation == "+")
        {
            CalculationResult = numberleft + numberright;
        }
        if (operation == "-")
        {
            CalculationResult = numberleft - numberright;
        }
        Result.text = numberleft.ToString() + " " + operation + " " + numberright.ToString() + " = " + CalculationResult.ToString();
    }



    // Кнопка обрабатывает нажатие цифр
    public void ButtonNumber(int x)
    {
        Bobik.text = "";
        if(x == 3) Bobik.text = "КУКУ";
        if (numberleft == 0)
        {
            numberleft = x;
            return;
        }
        else
        {
            if (numberright == 0)
            {
                numberright = x;
                return;
            }
            else
            {
                numberright = 0;
                numberleft = x;
            }
        }
    }



    // Кнопка обрабатывает плюс и минус
    public void ButtonPlusMinus(string InputOperation)
    {
        operation = InputOperation;

    }
    #endregion
}