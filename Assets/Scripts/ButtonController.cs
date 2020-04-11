using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SceneController sc;

    // Start is called before the first frame update
    void Start()
    {
        sc = GameObject.Find("SceneController").GetComponent<SceneController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Quit()
    {
        Application.Quit();
    }

    //public GameObject sceneController;

    public void LoadScene(int index)
    {
        sc.LoadScene(index);
    }
}
