using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eat : MonoBehaviour
{
    public string Tag;
    public float Increase;
    public Text Letters;

    double Score = 0;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == Tag)
        {
            transform.localScale += new Vector3(Increase, Increase, Increase);
            Destroy(other.gameObject);
            Score += 0.5;
            Letters.text = "SCORE: " + Score;
        }
    }
}
