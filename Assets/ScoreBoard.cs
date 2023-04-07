using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour
{
    int count = 0;
    public TMP_Text textbox;
    public string scenemenu;
    // Start is called before the first frame update
    void Start()
    {
        textbox.text = "B A N A N A";
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            count++;
            textbox.text = count.ToString();
        }
        if (OVRInput.GetUp(OVRInput.RawButton.B))
        {
            count--;
            textbox.text = count.ToString();
        }
        if (OVRInput.GetUp(OVRInput.RawButton.X))
        {
            SceneManager.LoadScene(scenemenu);
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bblock"))
        {
            count++;
        }
        else if (collision.gameObject.CompareTag("block"))
        {
            count++;
        }
    }
}
