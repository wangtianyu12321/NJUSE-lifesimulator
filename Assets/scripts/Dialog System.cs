using System.Collections;
using System.Collections.Generic;

using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogSystem : MonoBehaviour
{
    [Header("文本文件")]
    public TextAsset textFile;
    public Text perText;
    private int index;
    public Button nextButton;
    private string[] textList; 
    
    // Start is called before the first frame update
    void Start()
    {
        textList = textFile.text.Split("\r\n");
        index = -1;
        nextButton.onClick.AddListener(OnNextButtonClick);
    }
    private void OnNextButtonClick()
    {
        index++;
        if (index >= textList.Length)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            ShowDialogue();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ShowDialogue()
    {
        perText.text = textList[index];
        if (index >= textList.Length)
        {
            nextButton.gameObject.SetActive(false);
        }
    }
    
}
