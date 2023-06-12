using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberPoints : MonoBehaviour
{
   private float points;
   private TextMeshProUGUI textMesh;

   private void Start(){
    textMesh = GetComponent <TextMeshProUGUI>();
   }

    private void Update(){
        points += Time.deltaTime;
        textMesh.text = points.ToString("0");
    }

    public void IncreasePoints(float ppoints){
        points += ppoints;
    }
}

