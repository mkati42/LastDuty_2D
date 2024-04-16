using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelActive : MonoBehaviour
{
    public GameObject pausePanel;
    // Start is called before the first frame update
    void Start()
    {
        pausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            pausePanel.SetActive(!pausePanel.activeSelf);
        if (pausePanel.activeSelf == true)
        {
            Cursor.visible = true;
            Time.timeScale = 0;
        }

        else
        {
            Cursor.visible = false;
            Time.timeScale = 1;

        }

    }
}
