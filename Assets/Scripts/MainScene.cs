using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MainScene : MonoBehaviour
{
    public TextMeshProUGUI userName;
    public List<Button> BrightnessButton;
    public List<Button> ColorButton;
    // Start is called before the first frame update
    void Start()
    {
        userName.text = GameManager.Instance.userName + "��" + "\n" + "�ѷ��� �Ĺ� ����";

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
