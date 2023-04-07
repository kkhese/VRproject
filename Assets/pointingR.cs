using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class pointingR : MonoBehaviour
{
    public Button button;
    public Button button2;
    public LineRenderer Line;
    public TMP_Text buttonText;
    public TMP_Text buttonText2;

    public string scene1;
    public string scene2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //    Line.SetPosition(0, transform.position);
    //    Line.SetPosition(1, transform.position + (transform.forward * 100));
        // generate a raycast
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out hit);

        Line.SetPosition(0, transform.position);
        Line.SetPosition(1, transform.position + (transform.forward * 20));

        // check if it hit anything
        if (hit.collider)
        {
            if (hit.collider.CompareTag("button"))
            {
                Line.SetPosition(1, hit.point);
                button.Select();
                if (OVRInput.GetDown(OVRInput.Button.Any))
                {
                    ExecuteEvents.Execute(button.gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
                    SceneManager.LoadScene(scene1);
                }
            }
            else if (hit.collider.CompareTag("button2"))
            {
                Line.SetPosition(1, hit.point);
                button2.Select();
                if (OVRInput.GetDown(OVRInput.Button.Any))
                {
                    ExecuteEvents.Execute(button2.gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
                    SceneManager.LoadScene(scene2);

                }
            }
            else
            {
                EventSystem.current.SetSelectedGameObject(null);
            }
        }
    }

    public void ChangeText()
    {
        buttonText.text = "Clicked";
    }
    public void ChangeText2()
    {
        buttonText2.text = "Clicked";
    }
}
