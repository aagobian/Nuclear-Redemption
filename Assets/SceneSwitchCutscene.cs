using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchCutscene : MonoBehaviour
{
    void Start()
    {
        Invoke("CutSwitch", 17);
    }

    void CutSwitch()
    {
        SceneManager.LoadScene(2);
    }
}
