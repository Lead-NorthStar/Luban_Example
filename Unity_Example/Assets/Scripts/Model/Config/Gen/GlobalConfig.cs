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
    public partial class GlobalConfig :  AConfig 
    {
    	/// <summary>
    	/// 默认音量
    	/// </summary>
        [JsonProperty("volume")]
        private float _volume { get; set; }

        [JsonIgnore]
        public EncryptFloat volume { get; private set; } = new();
    	/// <summary>
    	/// 默认 Icon 位置
    	/// </summary>
        [JsonProperty]
        public string  default_icon { get; private set; }

        public override void EndInit() 
        {
            volume = _volume;
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
