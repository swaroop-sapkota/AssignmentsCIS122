// Written by Swaroop Sapkota
// 02/14/2025
// The Properties of Arrows  

using System;

public enum Arrowhead { Steel, Wood, Obsidian }
public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }

public class Arrow3
{

    // Class Variables
    private Arrowhead arrowhead;
    private Fletching fletching;
    private float shaftLength;

    // Getters and Setters
    public Arrowhead ArrowheadType
    {
        get { return this.arrowhead; }
        set { this.arrowhead = value; }
    }

    public Fletching FletchingType
    {
        get { return this.fletching; }
        set { this.fletching = value; }
    }

    public float ShaftLength
    {
        get { return this.shaftLength; }
        set
        {
            if (value >= 60 && value <= 100) 
                shaftLength = value;
        }
    }

    // Constructor
    public Arrow3(Arrowhead arrowhead, Fletching fletching, float shaftLength)
    {
        ArrowheadType = arrowhead;
        FletchingType = fletching;
        ShaftLength = shaftLength;
    }

    // Method to calculate arrow cost
    public float GetCost()
    {
        float arrowheadCost = ArrowheadType == Arrowhead.Steel ? 10 :
                               ArrowheadType == Arrowhead.Wood ? 3 :
                               ArrowheadType == Arrowhead.Obsidian ? 5 : 0;
        float fletchingCost = FletchingType == Fletching.Plastic ? 10 :
                               FletchingType == Fletching.TurkeyFeathers ? 5 :
                               FletchingType == Fletching.GooseFeathers ? 3 : 0;
        float shaftCost = ShaftLength * 0.05f;

        return arrowheadCost + fletchingCost + shaftCost;
    }
}
