// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public enum FileProcessingStatus
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "success")]
        #pragma warning disable CS1591
        Success,
        #pragma warning restore CS1591
        [EnumMember(Value = "internalError")]
        #pragma warning disable CS1591
        InternalError,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownError")]
        #pragma warning disable CS1591
        UnknownError,
        #pragma warning restore CS1591
        [EnumMember(Value = "processingTimeout")]
        #pragma warning disable CS1591
        ProcessingTimeout,
        #pragma warning restore CS1591
        [EnumMember(Value = "invalidFileId")]
        #pragma warning disable CS1591
        InvalidFileId,
        #pragma warning restore CS1591
        [EnumMember(Value = "fileSizeIsZero")]
        #pragma warning disable CS1591
        FileSizeIsZero,
        #pragma warning restore CS1591
        [EnumMember(Value = "fileSizeIsTooLarge")]
        #pragma warning disable CS1591
        FileSizeIsTooLarge,
        #pragma warning restore CS1591
        [EnumMember(Value = "fileDepthLimitExceeded")]
        #pragma warning disable CS1591
        FileDepthLimitExceeded,
        #pragma warning restore CS1591
        [EnumMember(Value = "fileBodyIsTooLong")]
        #pragma warning disable CS1591
        FileBodyIsTooLong,
        #pragma warning restore CS1591
        [EnumMember(Value = "fileTypeIsUnknown")]
        #pragma warning disable CS1591
        FileTypeIsUnknown,
        #pragma warning restore CS1591
        [EnumMember(Value = "fileTypeIsNotSupported")]
        #pragma warning disable CS1591
        FileTypeIsNotSupported,
        #pragma warning restore CS1591
        [EnumMember(Value = "malformedFile")]
        #pragma warning disable CS1591
        MalformedFile,
        #pragma warning restore CS1591
        [EnumMember(Value = "protectedFile")]
        #pragma warning disable CS1591
        ProtectedFile,
        #pragma warning restore CS1591
        [EnumMember(Value = "poisonFile")]
        #pragma warning disable CS1591
        PoisonFile,
        #pragma warning restore CS1591
        [EnumMember(Value = "noReviewSetSummaryGenerated")]
        #pragma warning disable CS1591
        NoReviewSetSummaryGenerated,
        #pragma warning restore CS1591
        [EnumMember(Value = "extractionException")]
        #pragma warning disable CS1591
        ExtractionException,
        #pragma warning restore CS1591
        [EnumMember(Value = "ocrProcessingTimeout")]
        #pragma warning disable CS1591
        OcrProcessingTimeout,
        #pragma warning restore CS1591
        [EnumMember(Value = "ocrFileSizeExceedsLimit")]
        #pragma warning disable CS1591
        OcrFileSizeExceedsLimit,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue,
        #pragma warning restore CS1591
    }
}
