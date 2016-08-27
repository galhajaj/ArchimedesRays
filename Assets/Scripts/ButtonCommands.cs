using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonCommands : MonoBehaviour 
{
    public Button Button1;
    public Button Button2;
    public Button Button3;

    public GameObject Mirror1;
    public GameObject Mirror2;
    public GameObject Mirror3;

    public void MoveToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void SetLevelType(string levelType)
    {
        PlayerPrefs.SetString("LevelType", levelType);
    }

    public void SetCurrentMirror(int index)
    {
        uncolorAllButtons();

        if (index == 1)
            Button1.GetComponent<Image>().color = Color.yellow;
        if (index == 2)
            Button2.GetComponent<Image>().color = Color.yellow;
        if (index == 3)
            Button3.GetComponent<Image>().color = Color.yellow;

        sendSetCurrentMirrorMessageToMirrors(index);
    }

    private void uncolorAllButtons()
    {
        Button1.GetComponent<Image>().color = Color.white;
        Button2.GetComponent<Image>().color = Color.white;
        Button3.GetComponent<Image>().color = Color.white;
    }

    private void sendSetCurrentMirrorMessageToMirrors(int index)
    {
        Mirror1.SendMessage("SetCurrentMirror", index);
        Mirror2.SendMessage("SetCurrentMirror", index);
        Mirror3.SendMessage("SetCurrentMirror", index);
    }

    public void SendRightToMirrors()
    {
        Mirror1.SendMessage("GoRight");
        Mirror2.SendMessage("GoRight");
        Mirror3.SendMessage("GoRight");
    }

    public void SendLeftToMirrors()
    {
        Mirror1.SendMessage("GoLeft");
        Mirror2.SendMessage("GoLeft");
        Mirror3.SendMessage("GoLeft");
    }

    public void SendUpToMirrors()
    {
        Mirror1.SendMessage("GoUp");
        Mirror2.SendMessage("GoUp");
        Mirror3.SendMessage("GoUp");
    }

    public void SendDownToMirrors()
    {
        Mirror1.SendMessage("GoDown");
        Mirror2.SendMessage("GoDown");
        Mirror3.SendMessage("GoDown");
    }

    public void SendStopToMirrors()
    {
        Mirror1.SendMessage("Stop");
        Mirror2.SendMessage("Stop");
        Mirror3.SendMessage("Stop");
    }
}
