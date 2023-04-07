using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneName;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("stick"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}