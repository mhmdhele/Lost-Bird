using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScrollerScript : MonoBehaviour
{

    // In This Script I Make The Background Scrolling Smoothly
    
    public float scrollSpeed = 0.5f;
    private float offset;
    private Material mat;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }


    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 10;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
