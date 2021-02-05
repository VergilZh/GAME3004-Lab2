using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(300.0f, 10.0f, 600.0f, 500.0f), "Panel");

        if (GUI.Button(new Rect(512.0f, 10.0f, 100.0f, 30.0f), "Start"))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
