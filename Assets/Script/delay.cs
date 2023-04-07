using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class delay : MonoBehaviour
{
    public TMP_Text textBox;
    // Start is called before the first frame update
    void Start()
    {
        textBox.text="";
        Invoke("DisplayText", 4);
        Invoke("DisplayText2", 10);
        Invoke("DisplayText3", 18);
        Invoke("DisplayText4", 20);
        Invoke("DisplayText5", 30);
        Invoke("DisplayText6", 32);
        Invoke("DisplayText7", 44);
        Invoke("DisplayText8", 46);
        Invoke("DisplayText9", 56);
        Invoke("DisplayText10", 57);
        Invoke("DisplayText11", 58);
        Invoke("DisplayText12", 59);
        Invoke("DisplayText13", 60);
        Invoke("DisplayText14", 62);
        Invoke("DisplayText15", 64);
        Invoke("DisplayText16", 67);
        Invoke("DisplayText17", 70);
    }

    // Update is called once per frame
    void DisplayText()
    {
        textBox.text="2023";
    }
    void DisplayText2()
    {
        textBox.text = "World";
    }
    void DisplayText3()
    {
        textBox.text = "2023 World";
    }
    void DisplayText4()
    {
        textBox.text = "Canada";
    }
    void DisplayText5()
    {
        textBox.text = "2023 World Canada";
    }
    void DisplayText6()
    {
        textBox.text = "Kimchi";
    }
    void DisplayText7()
    {
        textBox.text = "2023 World Canada Kimchi";
    }
    void DisplayText8()
    {
        textBox.text = "Festival & Expo";
    }
    void DisplayText9()
    {
        textBox.text = "2";
    }
    void DisplayText10()
    {
        textBox.text = "202";
    }
    void DisplayText11()
    {
        textBox.text = "2023 W";
    }
    void DisplayText12()
    {
        textBox.text = "2023 World";
    }
    void DisplayText13()
    {
        textBox.text = "2023 World Cana";
    }
    void DisplayText14()
    {
        textBox.text = "2023 World Canada Kim";
    }
    void DisplayText15()
    {
        textBox.text = "2023 World Canada Kimchi Fes";
    }
    void DisplayText16()
    {
        textBox.text = "2023 World Canada Kimchi Festival &";
    }
    void DisplayText17()
    {
        textBox.text = "2023 World Canada Kimchi Festival & Expo";
    }
}
