using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScanFeder : MonoBehaviour
{
    public Image img;
    public AnimationCurve curve; 

    private void Start()
    {
       StartCoroutine(FadeIN());
    }
    public void FadeTo(string scane)
    {
        StartCoroutine(FadeOut(scane));
    }
    IEnumerator FadeIN()
    {
        float t = 1f;       
        while(t > 0)
        {
            t -= Time.deltaTime;
            float a = curve.Evaluate(t);
            img.color = new Color(0f, 0f, 0f, a);
            yield return 0;
        }
    }

    IEnumerator FadeOut(string scane)
    {
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime;
            float a = curve.Evaluate(t);
            img.color = new Color(0f, 0f, 0f, a);
            yield return 0;
        }
        SceneManager.LoadScene(scane);
    }
}
