using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Animator scoreAnimator;
    public Text scoreDisplay;
    public int ThreeStars = 3;
    public int TwoStars = 5;
    public int nextLevel = 0;
    public void EndLevel() 
    {
        Cannon cannon = FindObjectOfType<Cannon>();
        if (cannon) 
        {
            int numProjectiles = cannon.numProjectiles;
            if (numProjectiles <= ThreeStars) 
            {
                print("3 STARS!!");
                scoreDisplay.text = "Three Stars!";
                scoreAnimator.SetInteger("Stars", 3);
            }
            if (numProjectiles <= TwoStars && numProjectiles > ThreeStars)
            {
                print("2 STARS!!");
                scoreDisplay.text = "Two Stars!";
                scoreAnimator.SetInteger("Stars", 2);
            }
            if (numProjectiles > TwoStars)
            {
                print("1 STAR!!");
                scoreDisplay.text = "1 Star";
                scoreAnimator.SetInteger("Stars", 1);
            }
        }
        Invoke("NextLevel", 2);
    }
    void NextLevel() 
    {
        SceneManager.LoadScene(nextLevel);
    }
}
