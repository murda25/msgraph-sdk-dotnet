// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.Security {
    [Flags]
    public enum ExportOptions {
        [EnumMember(Value = "originalFiles")]
        OriginalFiles = 1,
        [EnumMember(Value = "text")]
        Text = 2,
        [EnumMember(Value = "pdfReplacement")]
        PdfReplacement = 4,
        [EnumMember(Value = "tags")]
        Tags = 8,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 16,
    }
}
