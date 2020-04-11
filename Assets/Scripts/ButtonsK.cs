using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsK : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject textsPanel;
    public GameObject visualsPanel;
    public GameObject buttonsPanel;

    public void SetTexts(bool enable)
    {
        buttonsPanel.SetActive(!enable);
        textsPanel.SetActive(enable);
    }

    public void SetVisuals(bool enable)
    {
        buttonsPanel.SetActive(!enable);
        visualsPanel.SetActive(enable);
    }

    public void Intro()
    {
        Application.OpenURL("https://en.wikipedia.org/wiki/Tadeusz_Ko%C5%9Bciuszko");
    }
}
