using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GotoStage2 : MonoBehaviour
{
    [SerializeField] Button _stage2;
    // Start is called before the first frame update
    void Start()
    {
        _stage2.onClick.AddListener
        (delegate { GotoStage2ButtonClick(_stage2); });
    }

    // Update is called once per frame
    void Update()
    { 

    }
    public void GotoStage2ButtonClick(Button button)
        {            
            SceneManager.UnloadSceneAsync("SceneStageSelect");
            SceneManager.LoadScene("Stage2");
        } 
    }