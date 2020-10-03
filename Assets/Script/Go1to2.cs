using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Go1to2 : MonoBehaviour
{
    [SerializeField] Button _next;
    // Start is called before the first frame update
    void Start()
    {
        _next.onClick.AddListener
        (delegate { Go1to2ButtonClick(_next); });
    }

    // Update is called once per frame
    void Update()
    { 

    }
    public void Go1to2ButtonClick(Button button)
        {            
            SceneManager.UnloadSceneAsync("Stage1");
            SceneManager.LoadScene("Stage2");
        } 
    }