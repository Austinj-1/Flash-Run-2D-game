using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCollector : MonoBehaviour
{
    // Setting a counter to count the crystals collected
    private int crystals = 0;

    [SerializeField] private Text crystalsText;


    //Sprite hits the crystal and it dissappears
    private void OnTriggerEnter2D(Collider2D collision)
      
    {
        if (collision.gameObject.CompareTag("Crystal"))
        {
            Destroy(collision.gameObject);
            crystals++;  //When crystal is collected it increments the counter
            crystalsText.text = "Crystals: " + crystals;
        }
    }
}