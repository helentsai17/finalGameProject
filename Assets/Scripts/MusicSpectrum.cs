using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSpectrum : MonoBehaviour
{
    const int COUNT = 64;
    float[] sample = new float[COUNT];
    GameObject[] cubes = new GameObject[COUNT];

    void Start()
    {
        for(int i = 0; i<COUNT; i++)
        {
            cubes[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubes[i].transform.position = new Vector3(i * 0.2f, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        AudioListener.GetSpectrumData(sample, 0, FFTWindow.Rectangular);
        for(int i= 0; i < COUNT; i++)
        {
            cubes[i].transform.localScale = new Vector3(0.2f, sample[i] * 5.0f, 1.0f);
        }
    }
}
