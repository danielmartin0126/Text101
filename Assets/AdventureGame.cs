using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "Welcome to the Punchathon. Seven punchers enter. One puncher leaves.\n" +
                             "You stand in a circle of contestants, each wearing a numbered shirt. " +
                             "Your shirt reads 7. \n" +
                             "PUNCHATHON BEGINS IN: 3..2..1 \n\n" +
                             "Select an action:\n" +
                             "1: Perform Ultimate Punch on contestant 6\n" +
                             "2: Cry\n" +
                             "3: Wait\n";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
