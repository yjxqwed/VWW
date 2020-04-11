using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualsOnEnable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        vp.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public UnityEngine.Video.VideoPlayer vp;

    private void OnEnable()
    {
        vp.Play();
    }

    private void OnDisable()
    {
        vp.Stop();
    }
}
