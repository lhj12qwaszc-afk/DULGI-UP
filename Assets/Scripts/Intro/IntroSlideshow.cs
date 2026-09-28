using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroSlideshow : MonoBehaviour
{
    public Image introImage;
    public Sprite[] introSprites;

    public float slideTime = 2.5f;

    private void Start()
    {
        StartCoroutine(PlayIntro());
    }

    private IEnumerator PlayIntro()
    {
        for (int i = 0; i < introSprites.Length; i++)
        {
            introImage.sprite = introSprites[i];

            yield return new WaitForSeconds(slideTime);
        }

        SceneManager.LoadScene("MainMenu");
    }
}