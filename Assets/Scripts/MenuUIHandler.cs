using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public InputField userName;
    public TextMeshProUGUI userNameDisplay;
    // Start is called before the first frame update
    void Start()
    {
        userName = FindObjectOfType<InputField>();
        userNameDisplay.text = PlayerPrefs.GetString("UserName");

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void UserNameInput()
    {
        PlayerPrefs.SetString("UserName", userName.text);
    }
}
