using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit_Script : MonoBehaviour
{

    public GameObject WinMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) //Picks up items labled with tag 'Pick Up'
        {
            if (other.gameObject.CompareTag("Player"))
            {
                WinMenuUI.SetActive(true);
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }

}
