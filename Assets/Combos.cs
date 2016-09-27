using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.Events;

public class Combos : MonoBehaviour {
    public List<KeyCode> UtilKeys = new List<KeyCode>();
    public List<KeyCode> PressedKeys = new List<KeyCode>();
    public List<KeysCombos> ComboKeys = new List<KeysCombos>();
    public float ComboTime, ComboMaxKeys;
    float EndCombo;
    bool OnCombo;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	    foreach(KeyCode key in UtilKeys)
        {
            if (Input.GetKeyDown(key))
            {
                EndCombo = Time.time + ComboTime;
                if (OnCombo)
                {
                    PressedKeys.Add(key);
                }else
                {
                    OnCombo = true;
                    PressedKeys.Add(key);
                }
            }
        }

        if(Time.time >= EndCombo)
        {
            OnCombo = false;
            PressedKeys.Clear();
        }

        bool ValidCombo = true;
        foreach(KeysCombos combo in ComboKeys)
        {
            for(int i = 0;i < PressedKeys.Count; i++)
            {
                int j;
                for (j = 0;j < combo.Keys.Count; j++)
                {
                    if (i + j >= PressedKeys.Count)
                        break;
                    if(PressedKeys[j + i] == combo.Keys[j])
                    {
                        ValidCombo = true;
                    }
                    else
                    {
                        ValidCombo = false;
                        break;
                    }
                }
                if (ValidCombo && j >= combo.Keys.Count)
                {
                    combo.action.Invoke();
                    PressedKeys.Clear();
                }
            }
        }
	}

    public void Combo1()
    {
        Debug.Log("Combo1");
    }

    public void Combo2()
    {
        Debug.Log("Combo2");
    }
}

[Serializable]
public class KeysCombos
{
    public List<KeyCode> Keys;
    public UnityEvent action;
}