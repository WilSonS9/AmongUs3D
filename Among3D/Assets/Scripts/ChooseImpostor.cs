using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;

public class ChooseImpostor : MonoBehaviour
{
    public System.Random ran = new System.Random();
    // Start is called before the first frame update
    List<string> Players = new List<string>();
    
    void Start()
    {   
        for (int i = 0; i < ran.Next(8, 11); i++) {
            Players.Add("crew");
        }
        if (Players.Count <= 7) {
            Players[ran.Next(0, Players.Count)] = "imp";
        } else {
            int imp1 = 0;
            int imp2 = 0;
            while (imp1 == imp2) {
                imp1 = ran.Next(0, Players.Count);
                imp2 = ran.Next(0, Players.Count);
            }
            Players[imp1] = "imp";
            Players[imp2] = "imp";
        }

        for (int i = 0; i < Players.Count; i++) {
            Debug.Log(Players[i] + " player " + (i+1));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
