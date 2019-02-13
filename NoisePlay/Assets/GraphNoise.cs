using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GraphNoise : MonoBehaviour {

	float t = 0;
    float inc = 0.01f;
    
	void Update () 
	{
        t += inc;
        float n = Mathf.PerlinNoise(t,1);
        Grapher.Log(n, "Perlin1", Color.yellow);    
	}
}
