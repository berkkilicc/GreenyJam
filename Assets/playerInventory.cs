using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class playerInventory : MonoBehaviour
{
    public int NumberOfPlastic { get; private set; }
    public int NumberOfPaper { get; private set; }
    public int NumberOfGlass { get; private set; }
    public int NumberOfIron { get; private set; }
    public int NumberOfAluminum { get; private set; }

    public UnityEvent<playerInventory> OnPlasticCollected;
    public UnityEvent<playerInventory> OnPaperCollected;
    public UnityEvent<playerInventory> OnGlassCollected;
    public UnityEvent<playerInventory> OnIronCollected;
    public UnityEvent<playerInventory> OnAluminumCollected;

    public void PlasticCollected()
    {
        
        NumberOfPlastic++;
        OnPlasticCollected.Invoke(this);
    }

    public void PaperCollected()
    {
        
            NumberOfPaper++;
            OnPaperCollected.Invoke(this);
      
        
        
    }

    public void GlassCollected()
    {
       
            NumberOfGlass++;
            OnGlassCollected.Invoke(this);
        
        
    }

    public void IronCollected()
    {
        NumberOfIron++;
        OnIronCollected.Invoke(this);
    }

    public void AluminumCollected()
    {
        NumberOfAluminum++;
        OnAluminumCollected.Invoke(this);
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "paper":
                PaperCollected();
                break;
            case "glass":
                GlassCollected();
                break;
            case "iron":
                IronCollected();
                break;
            case "aluminum":
                AluminumCollected();
                break;
            case "plastic":
                PlasticCollected();
                break;
           
        }
    }
}