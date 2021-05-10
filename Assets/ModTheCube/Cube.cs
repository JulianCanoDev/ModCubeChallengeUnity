using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float nextColor = 0.0f;
    private float timeBeforeNextColor = 2.2f;
    
    void Start()
    {
        //transform.position = new Vector3(2.0f, 4.0f, -5.0f);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        //material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 0.3f, 0.7f);
    }
    
    void Update()
    {
        transform.Rotate(50.0f * Time.deltaTime, 20.0f * Time.deltaTime, 20.0f * Time.deltaTime);

        if (Time.time > nextColor)
        {
            nextColor = Time.time + timeBeforeNextColor;
            transform.position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-8.0f, 8.0f));
            Renderer.material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }
    }
}
