using System;

public class Class1
{
	public Class1()
	{
        bool found = false;
        foreach (string s in sList)
        {
            if (s.equals("ok"))
            {
                found = true;
                break; // get out of the loop
            }
        }

        // do stuff

        return found;
    }
}
