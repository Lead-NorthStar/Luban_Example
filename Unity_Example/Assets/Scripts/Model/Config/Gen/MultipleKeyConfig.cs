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







namespace Example
{
    [Serializable]
    public partial class MultipleKeyConfig :  AConfig 
    {
    	/// <summary>
    	/// 主键 1
    	/// </summary>
        [JsonProperty]
        public string  key_1 { get; private set; }
    	/// <summary>
    	/// 主键 2
    	/// </summary>
        [JsonProperty("key_2")]
        private int _key_2 { get; set; }

        [JsonIgnore]
        public EncryptInt key_2 { get; private set; } = new();
    	/// <summary>
    	/// 主键 4
    	/// </summary>
        [JsonProperty("key_3")]
        private long _key_3 { get; set; }

        [JsonIgnore]
        public EncryptLong key_3 { get; private set; } = new();

        public override void EndInit() 
        {
            key_2 = _key_2;
            key_3 = _key_3;
            base.EndInit();
        }

        public override void TranslateText()
        {
            base.TranslateText();
        }

        public override void BindRef() 
        {
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
