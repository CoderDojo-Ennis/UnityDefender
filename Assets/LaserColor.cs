using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserColor : MonoBehaviour
{
    public float ColorChangeSpeed = 2f;
    public float Saturation = 1f;
    public float Luminance = 1f;
    public float Intensity = 5f;

    private Renderer LaserRenderer;
    private Material LaserMaterial;

    private void Start()
    {
        LaserRenderer = GetComponent<Renderer>();
        LaserMaterial = LaserRenderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        float hue = (Time.time * ColorChangeSpeed) % 1f;
        Color laserColor = Color.HSVToRGB(hue, Saturation, Luminance, true);
        LaserMaterial.SetColor("_EmissionColor", laserColor * Intensity);      
    }
}
