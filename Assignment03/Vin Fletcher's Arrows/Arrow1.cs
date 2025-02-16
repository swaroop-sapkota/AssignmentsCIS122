// Written by Swaroop Sapkota
// 02/14/2025
// Vin Fletcher’s Arrows     

using System;

public enum Arrowhead { Steel, Wood, Obsidian }
public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }

public class Arrow1
{
    private Arrowhead arrowhead;
    private Fletching fletching;
    private float shaftLength;

    // Constructor
    public Arrow1(Arrowhead arrowhead, Fletching fletching, float shaftLength)
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
