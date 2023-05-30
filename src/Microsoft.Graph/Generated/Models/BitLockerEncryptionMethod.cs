using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>BitLockerEncryptionMethod types</summary>
    public enum BitLockerEncryptionMethod {
        /// <summary>AES-CBC 128-bit.</summary>
        [EnumMember(Value = "aesCbc128")]
        AesCbc128,
        /// <summary>AES-CBC 256-bit.</summary>
        [EnumMember(Value = "aesCbc256")]
        AesCbc256,
        /// <summary>XTS-AES 128-bit.</summary>
        [EnumMember(Value = "xtsAes128")]
        XtsAes128,
        /// <summary>XTS-AES 256-bit.</summary>
        [EnumMember(Value = "xtsAes256")]
        XtsAes256,
    }
}
