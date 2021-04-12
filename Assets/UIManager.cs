using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    private string name;
    
    public int health;
    public int strength;
    public int toughness;
    public int dexterity;
    public int iq;
    public int power;
    public int charm;
    public int hp;
    public int sp;
    
    public TMP_InputField nameText;
    public TMP_InputField healthText;
    public TMP_InputField strengthText;
    public TMP_InputField toughnessText;
    public TMP_InputField dexterityText;
    public TMP_InputField iqText;
    public TMP_InputField powerText;
    public TMP_InputField charmText;


    public TMP_Text playerName;
    public TMP_Text healthPoint;
    public TMP_Text spellPoint;
    private bool canPress;

    public GameObject inputPanel;
    public GameObject playerPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //print(Screen.currentResolution);
        name = nameText.text;
        
        health = int.Parse(nameText.text);
        strength = int.Parse(strengthText.text);
        toughness = int.Parse(toughnessText.text);
        dexterity = int.Parse(dexterityText.text);
        iq = int.Parse(iqText.text);
        power = int.Parse(powerText.text);
        charm = int.Parse(charmText.text);
    }

    public void generate()
    {
        if (nameText.text != null &&
            healthText.text != null &&
            strengthText.text != null &&
            toughnessText.text != null &&
            dexterityText.text != null &&
            iqText.text != null &&
            powerText.text != null &&
            charmText.text != null)
        {
            Debug.Log("Ha");
            //hp = toughness * 15 + strength * 2 + power;
            playerName.text = "Name: " + nameText.text;
            healthPoint.text = "hp: " + (toughness * 15 + strength * 2 + power).ToString();
            spellPoint.text = "SP: " + (iq * 10 + dexterity * 2).ToString();
            print(toughness * 15 + strength * 2 + power);
            print(iq * 10 + dexterity * 2);
            playerPanel.SetActive(true);
            inputPanel.SetActive(false);
        }
        //health = Toughness*15 + Strength*2 + Power*1
        //Spell P = IQ*10 + Dexterity*2
    }

    public void returnInput()
    {
        inputPanel.SetActive(true);
        playerPanel.SetActive(false);
    }
}
