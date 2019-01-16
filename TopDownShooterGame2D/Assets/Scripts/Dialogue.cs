using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue {
    
    //Setting the name and length for how many sentences and Dialogs you want.
    public string name;

    [TextArea(3, 10)]
    public string[] sentences;


}
