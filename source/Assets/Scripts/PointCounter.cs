using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointCounter : MonoBehaviour
{
    public static PointCounter instance;
    public TMP_Text pointText;
    public int currentPoint = 0;

    void Awake()
    {
        instance = this;    
    }

    void Start()
    {
        pointText.text = "Points: " + currentPoint.ToString();
    }

    public void IncreasePoints(int v)
    {
        currentPoint += v;
        pointText.text = "Points: " + currentPoint.ToString();
    }
}
