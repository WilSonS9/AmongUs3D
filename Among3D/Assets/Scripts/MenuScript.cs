using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;
using MLAPI.Transports.UNET;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public GameObject menuPanel;
    public InputField inputField;
    public InputField username;

    public void Host()
    {
        NetworkManager.Singleton.StartHost();
        menuPanel.SetActive(false);
        if (username.text.Length <= 0)
        {
            Globals.latestName = "Red";
        }
        else
        {
            Globals.latestName = username.text;
        }
    }

    public void Join()
    {
        // Clicked Join
        if (inputField.text.Length <= 0)
        {
            NetworkManager.Singleton.GetComponent<UNetTransport>().ConnectAddress = "127.0.0.1";
        }
        else
        {
            NetworkManager.Singleton.GetComponent<UNetTransport>().ConnectAddress = inputField.text;
        }

        if (username.text.Length <= 0)
        {
            Globals.latestName = "Red";
        }
        else
        {
            Globals.latestName = username.text;
        }
        NetworkManager.Singleton.StartClient();
        menuPanel.SetActive(false);
    }
}
