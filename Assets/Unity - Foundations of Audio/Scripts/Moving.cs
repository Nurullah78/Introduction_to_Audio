using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public Vector3 positionChange;
    private Vector3 currentPosition;
    private Vector3 maxRange;
    private Vector3 minRange;
    private bool isMin = false;
    
    // Start is called before the first frame update
    void Start()
    {
        currentPosition = transform.position;
        maxRange = new Vector3(7, 0, 6);
        minRange = new Vector3(-6, 0, -4);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPosition.x >= minRange.x && isMin == false)
        {
            Debug.Log("Deneme Satırı1");
            transform.position -= positionChange;
            currentPosition = transform.position;
            if (currentPosition.x < minRange.x)
            {
                isMin = true;
            }
        }
        else if (currentPosition.x <= maxRange.x && isMin == true)
        {
            Debug.Log("Deneme Satırı2");
            transform.position += positionChange;
            currentPosition = transform.position;
            if (currentPosition.x > maxRange.x)
            {
                isMin = false;
            }
        }
    }
}
