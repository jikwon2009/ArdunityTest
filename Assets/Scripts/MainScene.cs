using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainScene : MonoBehaviour
{
    public TextMeshProUGUI userName;
    // Start is called before the first frame update
    void Start()
    {
        userName.text = GameManager.Instance.userName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
