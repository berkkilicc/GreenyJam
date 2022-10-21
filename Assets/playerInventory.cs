using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInventory : MonoBehaviour
{
    public int NumberOfPlastic { get; private set; }
    public int NumberOfPaper { get; private set; }
    public int NumberOfGlass { get; private set; }
    public int NumberOfIron { get; private set; }
    public int NumberOfAluminum { get; private set; }

    public void PlasticCollected()
    {
        NumberOfPlastic++;
    }

    public void PaperCollected()
    {
        NumberOfPaper++;
    }

    public void GlassCollected()
    {
        NumberOfGlass++;
    }

    public void IronCollected()
    {
        NumberOfIron++;
    }

    public void AluminumCollected()
    {
        NumberOfAluminum++;
    }
}