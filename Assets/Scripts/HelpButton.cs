using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpButton : MonoBehaviour
{
    public GameObject helpMenu;

    private bool popUp;

    private void Start()
    {
        helpMenu.SetActive(false);
    }

    public void OnClick()
    {
        PopUp();
        helpMenu.SetActive(popUp);
    }

    void PopUp()
    {
        popUp = !popUp;

    }
}
