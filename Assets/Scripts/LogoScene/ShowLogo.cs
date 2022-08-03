using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShowLogo : MonoBehaviour
{
    public Image fade;
    void Start()
    {
        StartCoroutine("SceneManage");
    }

    IEnumerator SceneManage()
    {
        float alpha = 1f;

        while (alpha > 0)
        {
            alpha -= Time.deltaTime;
            fade.color = new Color(0, 0, 0, alpha);
            yield return new WaitForFixedUpdate();
        }

        yield return new WaitForSeconds(3f);

        while (alpha < 1f)
        {
            alpha += Time.deltaTime;
            fade.color = new Color(0, 0, 0, alpha);
            yield return new WaitForFixedUpdate();
        }

        SceneManager.LoadScene("MainScene");
    }
}
