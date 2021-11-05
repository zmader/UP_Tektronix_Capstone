using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeModifier : MonoBehaviour
{
    public Renderer rend;
    public int frames = 0;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if(frames == 10)
        {
            rend.material.SetColor("_Color", UpdateFrames());
            frames = 0;
        }
        frames++;
    }

    // Update is called once per frame
    Color UpdateFrames()
    {
        int r = Random.Range(0,255);
        int g = Random.Range(0,255);
        int b = Random.Range(0,255);
        Color newcolor = new Color(r,g,b);
        return newcolor;
    }
}
