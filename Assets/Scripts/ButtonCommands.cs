using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonCommands : MonoBehaviour 
{
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public Button Button5;
    public Button Button6;

    public GameObject Mirror1;
    public GameObject Mirror2;
    public GameObject Mirror3;
    public GameObject Mirror4;
    public GameObject Mirror5;
    public GameObject Mirror6;

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
        if (index == 4)
            Button4.GetComponent<Image>().color = Color.yellow;
        if (index == 5)
            Button5.GetComponent<Image>().color = Color.yellow;
        if (index == 6)
            Button6.GetComponent<Image>().color = Color.yellow;

        sendSetCurrentMirrorMessageToMirrors(index);
    }

    private void uncolorAllButtons()
    {
        Button1.GetComponent<Image>().color = Color.white;
        Button2.GetComponent<Image>().color = Color.white;
        Button3.GetComponent<Image>().color = Color.white;
        Button4.GetComponent<Image>().color = Color.white;
        Button5.GetComponent<Image>().color = Color.white;
        Button6.GetComponent<Image>().color = Color.white;
    }

    private void sendSetCurrentMirrorMessageToMirrors(int index)
    {
        Mirror1.SendMessage("SetCurrentMirror", index);
        Mirror2.SendMessage("SetCurrentMirror", index);
        Mirror3.SendMessage("SetCurrentMirror", index);
        Mirror4.SendMessage("SetCurrentMirror", index);
        Mirror5.SendMessage("SetCurrentMirror", index);
        Mirror6.SendMessage("SetCurrentMirror", index);
    }
}
