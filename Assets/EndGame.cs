using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Entered: " + other.gameObject.name); // Hangi nesneye �arp�ld���n� g�sterir
        if (other.CompareTag("Player"))
        {
            Debug.Log("You Win!");
            // Oyun bitince yap�lacak di�er i�lemler (�rn. yeni sahne y�kleme)
        }
    }
}
