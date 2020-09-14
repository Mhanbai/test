using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    string name = "Gregor";
    string status = "Young teacher";
    int age = 30;
	
	// Update method happens over and over as long as the gameobject remains in the scene
	void Update () {
        CheckStatus();
        DrinkAgingPotion(1);
	}

    //This method will only happen if we 'Call' it from one of the other methods
    void DrinkAgingPotion(int years)
    {
        //I can do a bunch of stuff inside this method
        age = age + years;
    }

    void CheckStatus()
    {
        if (age <= 50)
        {
            status = "Young teacher";
        }

        if (age > 50)
        {
            status = "Old fogey";
        }
    }
}
