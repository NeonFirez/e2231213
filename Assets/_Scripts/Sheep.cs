/* The Sheep class has methods and properties that are similar to those of the
 * Elephant class but are implemented in a different way
 */

using UnityEngine;

public class Sheep : Animal
{
    private Color skinColor = Color.white;
    public override Color SkinColor
    {
        get { return skinColor; }
    }

    private Color noseColor = Color.black;
    public override Color NoseColor
    {
        get { return noseColor; }
    }

    private float noseLength = 1.1f;
    public override float NoseLength
    {
        get { return noseLength; }
    }

    private float scale = 1.3f;
    public override float Scale
    {
        get
        {
            return scale;
        }
        set
        {
            if (value < 0.1f)
            {
                value = 0.1f;
            }
            else if (value > 1.5f)
            {
                value = 1.5f;
            }
            scale = value;
        }
    }

    public override void Sleep()
    {
        Debug.Log("Mööh!");
    }

    public override string Talk()
    {
        return "Määh!";
    }

    public override GameObject GetEars()
    {
        GameObject ears = Resources.Load("CatEars") as GameObject;
        return ears;
    }
}