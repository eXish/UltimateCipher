﻿using Words;
public class creamCipher : cipherBase
{
    protected override string Name { get { return "Cream"; } }

    static int moduleIdCounter = 1;

    protected override void Initialize()
    {
        moduleId = moduleIdCounter++;
        answer = new Data().PickWord(6);
        Log("CREAM", "Generated Word: {0}", answer);
        pages = creamcipher(answer);
    }
}
