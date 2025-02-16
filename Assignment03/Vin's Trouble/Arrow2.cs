// Written by Swaroop Sapkota
// 02/14/2025
// Vin's Trouble  

using System;

public enum Arrowhead { Steel, Wood, Obsidian }
public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }

public class Arrow2
{
    // Private fields
    private Arrowhead arrowhead;
    private Fletching fletching;
    private float shaftLength;

    // Getter methods for each field
    public Arrowhead ArrowheadType
    {
        get { return this.arrowhead; }
    }

    public Fletching FletchingType
    {
        get { return this.fletching; }
    }

    public float ShaftLength
    {
        get { return this.shaftLength; }
    }

    // Constructor
    public Arrow2(Arrowhead arrowhead, Fletching fletching, float shaftLength)
    {
        this.arrowhead = arrowhead;
        this.fletching = fletching;
        this.shaftLength = shaftLength;
    }

    // Method to calculate arrow cost
    public float GetCost()
    {
        float arrowheadCost = arrowhead == Arrowhead.Steel ? 10 :
                               arrowhead == Arrowhead.Wood ? 3 :
                               arrowhead == Arrowhead.Obsidian ? 5 : 0;
        float fletchingCost = fletching == Fletching.Plastic ? 10 :
                               fletching == Fletching.TurkeyFeathers ? 5 :
                               fletching == Fletching.GooseFeathers ? 3 : 0;
        float shaftCost = shaftLength * 0.05f;

        return arrowheadCost + fletchingCost + shaftCost;
    }
}
