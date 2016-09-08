﻿using System;

namespace BDSA2016.Lecture02.Lib.Co__and_contravariance
{
    public class Example
    {
        public Example()
        {
            //ICreator<Sub> baseCreator = new Creator<Base>();
            //ICreator<Base> subCreator = new Creator<Sub>();
            //IDestroyer<Sub> baseDestroyer = new Destroyer<Base>();
            //IDestroyer<Base> subDestroyer = new Destroyer<Sub>();
            //ICreatorDestroyer<Sub> baseCreatorDestroyer = new CreatorDestroyer<Base>();
            //ICreatorDestroyer<Base> subCreatorDestroyer = new CreatorDestroyer<Sub>();
        }
    }

    public class Base : IDisposable
    {
        public override string ToString() => "Base";

        public void Dispose()
        {
        }
    }

    public class Sub : Base
    {
        public override string ToString() => "Sub";
    }
}
