using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public float currentTotalHealth = 100f;
    public float headHealth = 100f;
    public float bodyHealth = 100f;
    public float rightArmHealth = 100f;
    public float leftArmHealth = 100f;
    public float rightLegHealth = 100f;
    public float leftLegHealth = 100f;

    private GameObject playerHealthBar;
    private TMP_Text playerHealthBarText;

    public Image headImage;
    public Image bodyImage;
    public Image rightArmImage;
    public Image leftArmImage;
    public Image rightLegImage;
    public Image leftLegImage;

    public TMP_Text headText;
    public TMP_Text bodyText;
    public TMP_Text rightArmText;
    public TMP_Text leftArmText;
    public TMP_Text rightLegText;
    public TMP_Text leftLegText;

    // Start is called before the first frame update
    void Start()
    {
        playerHealthBar = GameObject.Find("PlayerHealthBar");
        playerHealthBarText = GameObject.Find("PlayerHealthBarText").GetComponent<TMP_Text>();

    }

    /// <summary>
    /// Update contains all the test functionality
    /// </summary>
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            HeadHit(20f);
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            BodyHit(20f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            RightArmHit(20f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            LeftArmHit(20f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            RightLegHit(20f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            LeftLegHit(20f);
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            HealHead(20f);
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            HealBody(20f);
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            HealRightArm(20f);
        }

        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            HealLeftArm(20f);
        }

        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            HealRightLeg(20f);
        }

        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            HealLeftLeg(20f);
        }

    }

    //Below are a list of methods that deal with each body part being damaged


    public void HeadHit(float amount)
    {
        if (headHealth > 0)
        {
            headHealth -= amount;

            //Changes the color of the body part icon based on how much health it has remaining
            if (headHealth <= 0)
            {
                headHealth = 0; //Keeps the health from falling into the negative
                bodyImage.color = new Color32(120, 41, 41, 255);
            }
            else if (headHealth <= 30)
            {
                headImage.color = new Color32(195, 80, 79, 255);
            }
            else if (headHealth <= 60)
            {
                headImage.color = new Color32(195, 136, 78, 255);
            }
            else if (headHealth <= 90)
            {
                headImage.color = new Color32(195, 189, 78, 255);
            }

            currentTotalHealth -= amount;
            if (currentTotalHealth < 0)
            {
                currentTotalHealth = 0;
            }

            UpdateHeadText(headHealth);
            UpdateHealthBar(currentTotalHealth);
        }
    }

    public void BodyHit(float amount)
    {
        if (bodyHealth > 0)
        {
            bodyHealth -= amount;

            //Changes the color of the body part icon based on how much health it has remaining
            if (bodyHealth <= 0)
            {
                bodyHealth = 0; //Keeps the health from falling into the negative
                bodyImage.color = new Color32(120, 41, 41, 255);
            }
            else if (bodyHealth <= 30)
            {
                bodyImage.color = new Color32(195, 80, 79, 255);
            }
            else if (bodyHealth <= 60)
            {
                bodyImage.color = new Color32(195, 136, 78, 255);
            }
            else if (bodyHealth <= 90)
            {
                bodyImage.color = new Color32(195, 189, 78, 255);
            }

            currentTotalHealth -= amount;
            if (currentTotalHealth < 0)
            {
                currentTotalHealth = 0;
            }

            UpdateBodyText(bodyHealth);
            UpdateHealthBar(currentTotalHealth);
        }
    }

    public void RightArmHit(float amount)
    {
        if (rightArmHealth > 0)
        {
            rightArmHealth -= amount;

            //Changes the color of the body part icon based on how much health it has remaining
            if (rightArmHealth <= 0)
            {
                rightArmHealth = 0; //Keeps the health from falling into the negative
                rightArmImage.color = new Color32(120, 41, 41, 255);
            }
            else if (rightArmHealth <= 30)
            {
                rightArmImage.color = new Color32(195, 80, 79, 255);
            }
            else if (rightArmHealth <= 60)
            {
                rightArmImage.color = new Color32(195, 136, 78, 255);
            }
            else if (rightArmHealth <= 90)
            {
                rightArmImage.color = new Color32(195, 189, 78, 255);
            }

            //Only does a percent of the damage as these are not vital body parts. Also rounds as to not have to deal with a decimal health value.
            currentTotalHealth = Mathf.Round(currentTotalHealth - (amount * 0.25f));
            if (currentTotalHealth < 0)
            {
                currentTotalHealth = 0;
            }

            UpdateRightArmText(rightArmHealth);
            UpdateHealthBar(currentTotalHealth);
        }
    }

    public void LeftArmHit(float amount)
    {
        if (leftArmHealth > 0)
        {
            leftArmHealth -= amount;

            //Changes the color of the body part icon based on how much health it has remaining
            if (leftArmHealth <= 0)
            {
                leftArmHealth = 0; //Keeps the health from falling into the negative
                leftArmImage.color = new Color32(120, 41, 41, 255);
            }
            else if (leftArmHealth <= 30)
            {
                leftArmImage.color = new Color32(195, 80, 79, 255);
            }
            else if (leftArmHealth <= 60)
            {
                leftArmImage.color = new Color32(195, 136, 78, 255);
            }
            else if (leftArmHealth <= 90)
            {
                leftArmImage.color = new Color32(195, 189, 78, 255);
            }

            //Only does a percent of the damage as these are not vital body parts. Also rounds as to not have to deal with a decimal health value.
            currentTotalHealth = Mathf.Round(currentTotalHealth - (amount * 0.25f));
            if (currentTotalHealth < 0)
            {
                currentTotalHealth = 0;
            }

            UpdateLeftArmText(leftArmHealth);
            UpdateHealthBar(currentTotalHealth);
        }
    }

    public void RightLegHit(float amount)
    {
        if (rightLegHealth > 0)
        {
            rightLegHealth -= amount;

            //Changes the color of the body part icon based on how much health it has remaining
            if (rightLegHealth <= 0)
            {
                rightLegHealth = 0; //Keeps the health from falling into the negative
                rightLegImage.color = new Color32(120, 41, 41, 255);
            }
            else if (rightLegHealth <= 30)
            {
                rightLegImage.color = new Color32(195, 80, 79, 255);
            }
            else if (rightLegHealth <= 60)
            {
                rightLegImage.color = new Color32(195, 136, 78, 255);
            }
            else if (rightLegHealth <= 90)
            {
                rightLegImage.color = new Color32(195, 189, 78, 255);
            }

            //Only does a percent of the damage as these are not vital body parts. Also rounds as to not have to deal with a decimal health value.
            currentTotalHealth = Mathf.Round(currentTotalHealth - (amount * 0.25f));
            if (currentTotalHealth < 0)
            {
                currentTotalHealth = 0;
            }

            UpdateRightLegText(rightLegHealth);
            UpdateHealthBar(currentTotalHealth);
        }
    }

    public void LeftLegHit(float amount)
    {
        if (leftLegHealth > 0)
        {
            leftLegHealth -= amount;

            //Changes the color of the body part icon based on how much health it has remaining
            if (leftLegHealth <= 0)
            {
                leftLegHealth = 0; //Keeps the health from falling into the negative
                leftLegImage.color = new Color32(120, 41, 41, 255);
            }
            else if (leftLegHealth <= 30)
            {
                leftLegImage.color = new Color32(195, 80, 79, 255);
            }
            else if (leftLegHealth <= 60)
            {
                leftLegImage.color = new Color32(195, 136, 78, 255);
            }
            else if (leftLegHealth <= 90)
            {
                leftLegImage.color = new Color32(195, 189, 78, 255);
            }

            //Only does a percent of the damage as these are not vital body parts. Also rounds as to not have to deal with a decimal health value.

            currentTotalHealth = Mathf.Round(currentTotalHealth - (amount * 0.25f));
            if (currentTotalHealth < 0)
            {
                currentTotalHealth = 0;
            }

            UpdateLeftLegText(leftLegHealth);
            UpdateHealthBar(currentTotalHealth);
        }
    }

    /// <summary>
    /// Takes in the current health value and updates the player health bar to represent that value
    /// </summary>
    /// <param name="currentHealth"></param>
    public void UpdateHealthBar(float currentHealth)
    {
        playerHealthBarText.text = "Health: " + currentHealth;
        Vector3 scale = new Vector3(currentHealth / 100, playerHealthBarText.transform.localScale.y);
        playerHealthBar.transform.localScale = scale;
    }


    //The following methods deal with healing the individual body parts


    public void HealHead(float amount)
    {
        if (headHealth < 100)
        {
            headHealth += amount;
            currentTotalHealth += amount;

            //Makes sure that neither the Head's health or Overall health exceeds 100
            if (headHealth > 100)
            {
                headHealth = 100;
            }

            if (currentTotalHealth > 100)
            {
                currentTotalHealth = 100;
            }


            //Changes the color of the body part icon based on how much health it has remaining
            if (headHealth <= 30)
            {
                headImage.color = new Color32(195, 80, 79, 255);
            }
            else if (headHealth <= 60)
            {
                headImage.color = new Color32(195, 136, 78, 255); ;
            }
            else if (headHealth <= 90)
            {
                headImage.color = new Color32(195, 189, 78, 255);
            }
            else if (headHealth == 100)
            {
                headImage.color = new Color32(207, 207, 207, 255);
            }

            UpdateHeadText(headHealth);
            UpdateHealthBar(currentTotalHealth);
        }
    }

    public void HealBody(float amount)
    {
        if (bodyHealth < 100)
        {
            bodyHealth += amount;
            currentTotalHealth += amount;

            //Makes sure that neither the Head's health or Overall health exceeds 100
            if (bodyHealth > 100)
            {
                bodyHealth = 100;
            }

            if (currentTotalHealth > 100)
            {
                currentTotalHealth = 100;
            }


            //Changes the color of the body part icon based on how much health it has remaining
            if (bodyHealth <= 30)
            {
                bodyImage.color = new Color32(195, 80, 79, 255);
            }
            else if (bodyHealth <= 60)
            {
                bodyImage.color = new Color32(195, 136, 78, 255);
            }
            else if (bodyHealth <= 90)
            {
                bodyImage.color = new Color32(195, 189, 78, 255);
            }
            else if (bodyHealth == 100)
            {
                bodyImage.color = new Color32(207, 207, 207, 255);
            }

            UpdateBodyText(bodyHealth);
            UpdateHealthBar(currentTotalHealth);
        }
    }

    public void HealRightArm(float amount)
    {
        if (rightArmHealth < 100)
        {
            rightArmHealth += amount;
            currentTotalHealth = Mathf.Round(currentTotalHealth + (amount * 0.25f));

            //Makes sure that neither the Head's health or Overall health exceeds 100
            if (rightArmHealth > 100)
            {
                rightArmHealth = 100;
            }

            if (currentTotalHealth > 100)
            {
                currentTotalHealth = 100;
            }


            //Changes the color of the body part icon based on how much health it has remaining
            if (rightArmHealth <= 30)
            {
                rightArmImage.color = new Color32(195, 80, 79, 255);
            }
            else if (rightArmHealth <= 60)
            {
                rightArmImage.color = new Color32(195, 136, 78, 255);
            }
            else if (rightArmHealth <= 90)
            {
                rightArmImage.color = new Color32(195, 189, 78, 255);
            }
            else if (rightArmHealth == 100)
            {
                rightArmImage.color = new Color32(207, 207, 207, 255);
            }

            UpdateRightArmText(rightArmHealth);
            UpdateHealthBar(currentTotalHealth);
        }
    }

    public void HealLeftArm(float amount)
    {
        if (leftArmHealth < 100)
        {
            leftArmHealth += amount;
            currentTotalHealth = Mathf.Round(currentTotalHealth + (amount * 0.25f));

            //Makes sure that neither the Head's health or Overall health exceeds 100
            if (leftArmHealth > 100)
            {
                leftArmHealth = 100;
            }

            if (currentTotalHealth > 100)
            {
                currentTotalHealth = 100;
            }


            //Changes the color of the body part icon based on how much health it has remaining
            if (leftArmHealth <= 30)
            {
                leftArmImage.color = new Color32(195, 80, 79, 255);
            }
            else if (leftArmHealth <= 60)
            {
                leftArmImage.color = new Color32(195, 136, 78, 255);
            }
            else if (leftArmHealth <= 90)
            {
                leftArmImage.color = new Color32(195, 189, 78, 255);
            }
            else if (leftLegHealth == 100)
            {
                leftArmImage.color = new Color32(207, 207, 207, 255);
            }

            UpdateLeftArmText(leftArmHealth);
            UpdateHealthBar(currentTotalHealth);
        }
    }

    public void HealRightLeg(float amount)
    {
        if (rightLegHealth < 100)
        {
            rightLegHealth += amount;
            currentTotalHealth = Mathf.Round(currentTotalHealth + (amount * 0.25f));

            //Makes sure that neither the Head's health or Overall health exceeds 100
            if (rightLegHealth > 100)
            {
                rightLegHealth = 100;
            }

            if (currentTotalHealth > 100)
            {
                currentTotalHealth = 100;
            }


            //Changes the color of the body part icon based on how much health it has remaining
            if (rightLegHealth <= 30)
            {
                rightLegImage.color = new Color32(195, 80, 79, 255);
            }
            else if (rightLegHealth <= 60)
            {
                rightLegImage.color = new Color32(195, 136, 78, 255);
            }
            else if (rightLegHealth <= 90)
            {
                rightLegImage.color = new Color32(195, 189, 78, 255);
            }
            else if (rightLegHealth == 100)
            {
                rightLegImage.color = new Color32(207, 207, 207, 255);
            }

            UpdateRightLegText(rightLegHealth);
            UpdateHealthBar(currentTotalHealth);
        }
    }

    public void HealLeftLeg(float amount)
    {
        if (leftLegHealth < 100)
        {
            leftLegHealth += amount;
            currentTotalHealth = Mathf.Round(currentTotalHealth + (amount * 0.25f));

            //Makes sure that neither the Head's health or Overall health exceeds 100
            if (leftLegHealth > 100)
            {
                leftLegHealth = 100;
            }

            if (currentTotalHealth > 100)
            {
                currentTotalHealth = 100;
            }


            //Changes the color of the body part icon based on how much health it has remaining
            if (leftLegHealth <= 30)
            {
                leftLegImage.color = new Color32(195, 80, 79, 255);
            }
            else if (leftLegHealth <= 60)
            {
                leftLegImage.color = new Color32(195, 136, 78, 255);
            }
            else if (leftLegHealth <= 90)
            {
                leftLegImage.color = new Color32(195, 189, 78, 255);
            }
            else if (leftLegHealth == 100)
            {
                leftLegImage.color = new Color32(207, 207, 207, 255);
            }

            UpdateLeftLegText(leftLegHealth);
            UpdateHealthBar(currentTotalHealth);
        }
    }

    //Below methods update each parts respective health text values in the HUD

    public void UpdateHeadText(float amount)
    {
        headText.text = amount + "%";
    }

    public void UpdateBodyText(float amount)
    {
        bodyText.text = amount + "%";
    }

    public void UpdateRightArmText(float amount)
    {
        rightArmText.text = amount + "%";
    }

    public void UpdateLeftArmText(float amount)
    {
        leftArmText.text = amount + "%";
    }

    public void UpdateRightLegText(float amount)
    {
        rightLegText.text = amount + "%";
    }

    public void UpdateLeftLegText(float amount)
    {
        leftLegText.text = amount + "%";
    }
}


