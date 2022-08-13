using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemCollector : MonoBehaviour
{
    private int Strawberries = 0;
    [SerializeField] private Text StrawberriesText;
    [SerializeField] AudioSource collectSoundEffect;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Strawberry"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            Strawberries++;
            StrawberriesText.text = "Strawberries: " + Strawberries;
        }
    }
}
