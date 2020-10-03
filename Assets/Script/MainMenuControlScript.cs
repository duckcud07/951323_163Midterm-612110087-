using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuControlScript : MonoBehaviour
{
    [SerializeField] Button _startButton;
    [SerializeField] Button _optionsButton;
    [SerializeField] Button _exitButton;
    [SerializeField] Button _creditsButton;
//    [SerializeField] Button _charaterButton;

    // Start is called before the first frame update
    void Start()
    {
        _startButton.onClick.AddListener (
            delegate{StartButtonClick(_startButton);});
            _optionsButton.onClick.AddListener (
               delegate{OptionsButtonClick(_optionsButton);});
                _exitButton.onClick.AddListener (
                    delegate{ExitButtonClick(_exitButton);});
                    _creditsButton.onClick.AddListener(
                       delegate{CreditsButtonClick(_creditsButton);});
//                       _charaterButton.onClick.AddListener(
//                            delegate{CharButtonClick(_charaterButton);});
                       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneStageSelect");
    }
    public void OptionsButtonClick(Button button)
    {
        if (!GameApplicationManager.Instance.IsOptionMenuActive)
        {
            SceneManager.LoadScene("SceneOption", LoadSceneMode.Additive);
            GameApplicationManager.Instance.IsOptionMenuActive = true;
        }
    }
    public void CharButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneCharacterChoose");
    }

    public  void  CreditsButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneCredit");
    }

    public void ExitButtonClick(Button button)
    {
        Application.Quit();
    }



}
