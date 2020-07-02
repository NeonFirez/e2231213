/* The Cow class has methods and properties that are similar to those of the
 * Elephant class but are implemented in a different way
 */

using UnityEngine;

public class MiniCow : Animal
{
    private Color skinColor = Color.black;
    public override Color SkinColor
    {
        get { return skinColor; }
    }

    private Color noseColor = new Color(0.64f, 0.16f, 0.16f);
    public override Color NoseColor
    {
        get { return noseColor; }
    }

    private float noseLength = 1.2f;
    public override float NoseLength
    {
        get { return noseLength; }
    }

    private float scale =1.5f;
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
        Debug.Log("HeavyBreathing!");
    }

    public override string Talk()
    {
        return "Moo!";
    }

    public override GameObject GetEars()
    {
        GameObject ears = Resources.Load("CatEars") as GameObject;
        return ears;
    }
}
