using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Pickup : MonoBehaviour
{

    public Text CountText;

    public GameObject ExitDoor;

    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText ();
        ExitDoor.SetActive(true);
    }

      private void OnTriggerEnter2D(Collider2D other) //Picks up items labled with tag 'Pick Up'
        {
            if (other.gameObject.CompareTag("Pick Up"))
            {
                other.gameObject.SetActive (false);
                count = count + 1;
                SetCountText ();
                FindObjectOfType<AudioManager>().Play("ShinyPickup");
            }
        }

        void SetCountText ()
        {
            CountText.text = "Shinies Collected: " + count.ToString ();
            if (count >= 10)
            {
                ExitDoor.SetActive(false);
            }

        }


    
}

