using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GotoStage1 : MonoBehaviour
{
    [SerializeField] Button _stage1;
    // Start is called before the first frame update
    void Start()
    {
        _stage1.onClick.AddListener
        (delegate { GotoStage1ButtonClick(_stage1); });
    }

    // Update is called once per frame
    void Update()
    { 

    }
    public void GotoStage1ButtonClick(Button button)
        {            
            SceneManager.UnloadSceneAsync("SceneStageSelect");
            SceneManager.LoadScene("Stage1");
        } 
    }
