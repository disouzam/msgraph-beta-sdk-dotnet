// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ColumnDefinition : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>This column stores Boolean values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.BooleanColumn? Boolean
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.BooleanColumn?>("boolean"); }
            set { BackingStore?.Set("boolean", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.BooleanColumn Boolean
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.BooleanColumn>("boolean"); }
            set { BackingStore?.Set("boolean", value); }
        }
#endif
        /// <summary>This column&apos;s data is calculated based on other columns.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CalculatedColumn? Calculated
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CalculatedColumn?>("calculated"); }
            set { BackingStore?.Set("calculated", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CalculatedColumn Calculated
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CalculatedColumn>("calculated"); }
            set { BackingStore?.Set("calculated", value); }
        }
#endif
        /// <summary>This column stores data from a list of choices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ChoiceColumn? Choice
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ChoiceColumn?>("choice"); }
            set { BackingStore?.Set("choice", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ChoiceColumn Choice
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ChoiceColumn>("choice"); }
            set { BackingStore?.Set("choice", value); }
        }
#endif
        /// <summary>For site columns, the name of the group this column belongs to. Helps organize related columns.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ColumnGroup
        {
            get { return BackingStore?.Get<string?>("columnGroup"); }
            set { BackingStore?.Set("columnGroup", value); }
        }
#nullable restore
#else
        public string ColumnGroup
        {
            get { return BackingStore?.Get<string>("columnGroup"); }
            set { BackingStore?.Set("columnGroup", value); }
        }
#endif
        /// <summary>This column stores content approval status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ContentApprovalStatusColumn? ContentApprovalStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ContentApprovalStatusColumn?>("contentApprovalStatus"); }
            set { BackingStore?.Set("contentApprovalStatus", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ContentApprovalStatusColumn ContentApprovalStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ContentApprovalStatusColumn>("contentApprovalStatus"); }
            set { BackingStore?.Set("contentApprovalStatus", value); }
        }
#endif
        /// <summary>This column stores currency values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CurrencyColumn? Currency
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CurrencyColumn?>("currency"); }
            set { BackingStore?.Set("currency", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CurrencyColumn Currency
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CurrencyColumn>("currency"); }
            set { BackingStore?.Set("currency", value); }
        }
#endif
        /// <summary>This column stores DateTime values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DateTimeColumn? DateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeColumn?>("dateTime"); }
            set { BackingStore?.Set("dateTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DateTimeColumn DateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeColumn>("dateTime"); }
            set { BackingStore?.Set("dateTime", value); }
        }
#endif
        /// <summary>The default value for this column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DefaultColumnValue? DefaultValue
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DefaultColumnValue?>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DefaultColumnValue DefaultValue
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DefaultColumnValue>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
#endif
        /// <summary>The user-facing description of the column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The user-facing name of the column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>If true, no two list items may have the same value for this column.</summary>
        public bool? EnforceUniqueValues
        {
            get { return BackingStore?.Get<bool?>("enforceUniqueValues"); }
            set { BackingStore?.Set("enforceUniqueValues", value); }
        }
        /// <summary>This column stores a geolocation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.GeolocationColumn? Geolocation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GeolocationColumn?>("geolocation"); }
            set { BackingStore?.Set("geolocation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.GeolocationColumn Geolocation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GeolocationColumn>("geolocation"); }
            set { BackingStore?.Set("geolocation", value); }
        }
#endif
        /// <summary>Specifies whether the column is displayed in the user interface.</summary>
        public bool? Hidden
        {
            get { return BackingStore?.Get<bool?>("hidden"); }
            set { BackingStore?.Set("hidden", value); }
        }
        /// <summary>This column stores hyperlink or picture values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.HyperlinkOrPictureColumn? HyperlinkOrPicture
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.HyperlinkOrPictureColumn?>("hyperlinkOrPicture"); }
            set { BackingStore?.Set("hyperlinkOrPicture", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.HyperlinkOrPictureColumn HyperlinkOrPicture
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.HyperlinkOrPictureColumn>("hyperlinkOrPicture"); }
            set { BackingStore?.Set("hyperlinkOrPicture", value); }
        }
#endif
        /// <summary>Specifies whether the column values can used for sorting and searching.</summary>
        public bool? Indexed
        {
            get { return BackingStore?.Get<bool?>("indexed"); }
            set { BackingStore?.Set("indexed", value); }
        }
        /// <summary>Indicates whether this column can be deleted.</summary>
        public bool? IsDeletable
        {
            get { return BackingStore?.Get<bool?>("isDeletable"); }
            set { BackingStore?.Set("isDeletable", value); }
        }
        /// <summary>Indicates whether values in the column can be reordered. Read-only.</summary>
        public bool? IsReorderable
        {
            get { return BackingStore?.Get<bool?>("isReorderable"); }
            set { BackingStore?.Set("isReorderable", value); }
        }
        /// <summary>Specifies whether the column can be changed.</summary>
        public bool? IsSealed
        {
            get { return BackingStore?.Get<bool?>("isSealed"); }
            set { BackingStore?.Set("isSealed", value); }
        }
        /// <summary>This column&apos;s data is looked up from another source in the site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.LookupColumn? Lookup
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LookupColumn?>("lookup"); }
            set { BackingStore?.Set("lookup", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.LookupColumn Lookup
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LookupColumn>("lookup"); }
            set { BackingStore?.Set("lookup", value); }
        }
#endif
        /// <summary>The API-facing name of the column as it appears in the fields on a listItem. For the user-facing name, see displayName.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>This column stores number values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.NumberColumn? Number
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.NumberColumn?>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.NumberColumn Number
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.NumberColumn>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#endif
        /// <summary>This column stores Person or Group values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.PersonOrGroupColumn? PersonOrGroup
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PersonOrGroupColumn?>("personOrGroup"); }
            set { BackingStore?.Set("personOrGroup", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.PersonOrGroupColumn PersonOrGroup
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PersonOrGroupColumn>("personOrGroup"); }
            set { BackingStore?.Set("personOrGroup", value); }
        }
#endif
        /// <summary>If true, changes to this column will be propagated to lists that implement the column.</summary>
        public bool? PropagateChanges
        {
            get { return BackingStore?.Get<bool?>("propagateChanges"); }
            set { BackingStore?.Set("propagateChanges", value); }
        }
        /// <summary>Specifies whether the column values can be modified.</summary>
        public bool? ReadOnly
        {
            get { return BackingStore?.Get<bool?>("readOnly"); }
            set { BackingStore?.Set("readOnly", value); }
        }
        /// <summary>Specifies whether the column value isn&apos;t optional.</summary>
        public bool? Required
        {
            get { return BackingStore?.Get<bool?>("required"); }
            set { BackingStore?.Set("required", value); }
        }
        /// <summary>The source column for content type column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ColumnDefinition? SourceColumn
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ColumnDefinition?>("sourceColumn"); }
            set { BackingStore?.Set("sourceColumn", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ColumnDefinition SourceColumn
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ColumnDefinition>("sourceColumn"); }
            set { BackingStore?.Set("sourceColumn", value); }
        }
#endif
        /// <summary>ContentType from which this column is inherited from. Used only to fetch contentTypes columns.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ContentTypeInfo? SourceContentType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ContentTypeInfo?>("sourceContentType"); }
            set { BackingStore?.Set("sourceContentType", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ContentTypeInfo SourceContentType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ContentTypeInfo>("sourceContentType"); }
            set { BackingStore?.Set("sourceContentType", value); }
        }
#endif
        /// <summary>This column stores taxonomy terms.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TermColumn? Term
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TermColumn?>("term"); }
            set { BackingStore?.Set("term", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TermColumn Term
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TermColumn>("term"); }
            set { BackingStore?.Set("term", value); }
        }
#endif
        /// <summary>This column stores text values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TextColumn? Text
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TextColumn?>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TextColumn Text
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TextColumn>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#endif
        /// <summary>This column stores thumbnail values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ThumbnailColumn? Thumbnail
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ThumbnailColumn?>("thumbnail"); }
            set { BackingStore?.Set("thumbnail", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ThumbnailColumn Thumbnail
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ThumbnailColumn>("thumbnail"); }
            set { BackingStore?.Set("thumbnail", value); }
        }
#endif
        /// <summary>For site columns, the type of column. Read-only.</summary>
        public global::Microsoft.Graph.Beta.Models.ColumnTypes? Type
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ColumnTypes?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>This column stores validation formula and message for the column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ColumnValidation? Validation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ColumnValidation?>("validation"); }
            set { BackingStore?.Set("validation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ColumnValidation Validation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ColumnValidation>("validation"); }
            set { BackingStore?.Set("validation", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ColumnDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ColumnDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ColumnDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "boolean", n => { Boolean = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.BooleanColumn>(global::Microsoft.Graph.Beta.Models.BooleanColumn.CreateFromDiscriminatorValue); } },
                { "calculated", n => { Calculated = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CalculatedColumn>(global::Microsoft.Graph.Beta.Models.CalculatedColumn.CreateFromDiscriminatorValue); } },
                { "choice", n => { Choice = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ChoiceColumn>(global::Microsoft.Graph.Beta.Models.ChoiceColumn.CreateFromDiscriminatorValue); } },
                { "columnGroup", n => { ColumnGroup = n.GetStringValue(); } },
                { "contentApprovalStatus", n => { ContentApprovalStatus = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ContentApprovalStatusColumn>(global::Microsoft.Graph.Beta.Models.ContentApprovalStatusColumn.CreateFromDiscriminatorValue); } },
                { "currency", n => { Currency = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CurrencyColumn>(global::Microsoft.Graph.Beta.Models.CurrencyColumn.CreateFromDiscriminatorValue); } },
                { "dateTime", n => { DateTime = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeColumn>(global::Microsoft.Graph.Beta.Models.DateTimeColumn.CreateFromDiscriminatorValue); } },
                { "defaultValue", n => { DefaultValue = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DefaultColumnValue>(global::Microsoft.Graph.Beta.Models.DefaultColumnValue.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "enforceUniqueValues", n => { EnforceUniqueValues = n.GetBoolValue(); } },
                { "geolocation", n => { Geolocation = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.GeolocationColumn>(global::Microsoft.Graph.Beta.Models.GeolocationColumn.CreateFromDiscriminatorValue); } },
                { "hidden", n => { Hidden = n.GetBoolValue(); } },
                { "hyperlinkOrPicture", n => { HyperlinkOrPicture = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.HyperlinkOrPictureColumn>(global::Microsoft.Graph.Beta.Models.HyperlinkOrPictureColumn.CreateFromDiscriminatorValue); } },
                { "indexed", n => { Indexed = n.GetBoolValue(); } },
                { "isDeletable", n => { IsDeletable = n.GetBoolValue(); } },
                { "isReorderable", n => { IsReorderable = n.GetBoolValue(); } },
                { "isSealed", n => { IsSealed = n.GetBoolValue(); } },
                { "lookup", n => { Lookup = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.LookupColumn>(global::Microsoft.Graph.Beta.Models.LookupColumn.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "number", n => { Number = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.NumberColumn>(global::Microsoft.Graph.Beta.Models.NumberColumn.CreateFromDiscriminatorValue); } },
                { "personOrGroup", n => { PersonOrGroup = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.PersonOrGroupColumn>(global::Microsoft.Graph.Beta.Models.PersonOrGroupColumn.CreateFromDiscriminatorValue); } },
                { "propagateChanges", n => { PropagateChanges = n.GetBoolValue(); } },
                { "readOnly", n => { ReadOnly = n.GetBoolValue(); } },
                { "required", n => { Required = n.GetBoolValue(); } },
                { "sourceColumn", n => { SourceColumn = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ColumnDefinition>(global::Microsoft.Graph.Beta.Models.ColumnDefinition.CreateFromDiscriminatorValue); } },
                { "sourceContentType", n => { SourceContentType = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ContentTypeInfo>(global::Microsoft.Graph.Beta.Models.ContentTypeInfo.CreateFromDiscriminatorValue); } },
                { "term", n => { Term = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TermColumn>(global::Microsoft.Graph.Beta.Models.TermColumn.CreateFromDiscriminatorValue); } },
                { "text", n => { Text = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TextColumn>(global::Microsoft.Graph.Beta.Models.TextColumn.CreateFromDiscriminatorValue); } },
                { "thumbnail", n => { Thumbnail = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ThumbnailColumn>(global::Microsoft.Graph.Beta.Models.ThumbnailColumn.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ColumnTypes>(); } },
                { "validation", n => { Validation = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ColumnValidation>(global::Microsoft.Graph.Beta.Models.ColumnValidation.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.BooleanColumn>("boolean", Boolean);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CalculatedColumn>("calculated", Calculated);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ChoiceColumn>("choice", Choice);
            writer.WriteStringValue("columnGroup", ColumnGroup);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ContentApprovalStatusColumn>("contentApprovalStatus", ContentApprovalStatus);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CurrencyColumn>("currency", Currency);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeColumn>("dateTime", DateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DefaultColumnValue>("defaultValue", DefaultValue);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enforceUniqueValues", EnforceUniqueValues);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.GeolocationColumn>("geolocation", Geolocation);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.HyperlinkOrPictureColumn>("hyperlinkOrPicture", HyperlinkOrPicture);
            writer.WriteBoolValue("indexed", Indexed);
            writer.WriteBoolValue("isDeletable", IsDeletable);
            writer.WriteBoolValue("isReorderable", IsReorderable);
            writer.WriteBoolValue("isSealed", IsSealed);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.LookupColumn>("lookup", Lookup);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.NumberColumn>("number", Number);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.PersonOrGroupColumn>("personOrGroup", PersonOrGroup);
            writer.WriteBoolValue("propagateChanges", PropagateChanges);
            writer.WriteBoolValue("readOnly", ReadOnly);
            writer.WriteBoolValue("required", Required);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ColumnDefinition>("sourceColumn", SourceColumn);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ContentTypeInfo>("sourceContentType", SourceContentType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TermColumn>("term", Term);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TextColumn>("text", Text);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ThumbnailColumn>("thumbnail", Thumbnail);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ColumnTypes>("type", Type);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ColumnValidation>("validation", Validation);
        }
    }
}
#pragma warning restore CS0618
