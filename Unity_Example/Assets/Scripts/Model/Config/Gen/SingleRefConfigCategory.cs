//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;




namespace Example
{
    [Config]
    public partial class SingleRefConfigCategory : ACategory<SingleRefConfig>
    {
        public static SingleRefConfigCategory Instance { get; private set; }

        public SingleRefConfigCategory()
        {
            Instance = this;
        }

        public override void TranslateText()
        {
            foreach(var v in dict.Values)
            {
                v.TranslateText();
            }
        }

    }
}
