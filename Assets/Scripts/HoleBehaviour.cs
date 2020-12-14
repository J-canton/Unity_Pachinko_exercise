using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoleBehaviour : MonoBehaviour
{
    public int award = 0;
    public int total = 0;
    public Text CounterText;


    private void OnTriggerEnter(Collider other)
    {
        HoleManager.TotalValue += award * 1;
        CounterText.text = "TOTAL PRIZE: " + HoleManager.TotalValue;
        Destroy(other);
        Debug.Log("BOLA EN EL AGUJERO " + total);
    }

}
