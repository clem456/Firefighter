using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countdowntimer : MonoBehaviour
{
    public GameObject firePoint;
    public Sprite vuur2;
    public Sprite vuur3;
    public float startingtime = 20f;
    private float currenttime = 0f;

    private SpriteRenderer firePointSpriteRenderer; // Reference to the SpriteRenderer component of firePoint

    // Start is called before the first frame update
    void Start()
    {
        currenttime = startingtime;
        firePointSpriteRenderer = firePoint.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        currenttime -= Time.deltaTime; // Decrease currenttime by deltaTime
        Debug.Log(currenttime);

        if (currenttime <= 10)
        {
            firePointSpriteRenderer.sprite = vuur2;
           
            
        }
        if (currenttime <= 0)
        {
            firePointSpriteRenderer.sprite = vuur3;
           
            currenttime = startingtime;
            enabled = false;
        }
    }
}
