using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class StartScene : MonoBehaviour
{
    public TMP_InputField nameInput;
    public Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(ClickStartButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ClickStartButton()
    {
        if (nameInput.text != "")
        {
            GameManager.Instance.userName = nameInput.text;
            SceneManager.LoadScene("MainScene");

        }
    }

}
