using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnClick : MonoBehaviour
{
    // ฟังก์ชันสำหรับการเปลี่ยน Scene
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}