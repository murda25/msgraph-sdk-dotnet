using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class Person : Entity, IParsable {
        /// <summary>The person&apos;s birthday.</summary>
        public string Birthday {
            get { return BackingStore?.Get<string>(nameof(Birthday)); }
            set { BackingStore?.Set(nameof(Birthday), value); }
        }
        /// <summary>The name of the person&apos;s company.</summary>
        public string CompanyName {
            get { return BackingStore?.Get<string>(nameof(CompanyName)); }
            set { BackingStore?.Set(nameof(CompanyName), value); }
        }
        /// <summary>The person&apos;s department.</summary>
        public string Department {
            get { return BackingStore?.Get<string>(nameof(Department)); }
            set { BackingStore?.Set(nameof(Department), value); }
        }
        /// <summary>The person&apos;s display name.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The person&apos;s given name.</summary>
        public string GivenName {
            get { return BackingStore?.Get<string>(nameof(GivenName)); }
            set { BackingStore?.Set(nameof(GivenName), value); }
        }
        /// <summary>The instant message voice over IP (VOIP) session initiation protocol (SIP) address for the user. Read-only.</summary>
        public string ImAddress {
            get { return BackingStore?.Get<string>(nameof(ImAddress)); }
            set { BackingStore?.Set(nameof(ImAddress), value); }
        }
        /// <summary>true if the user has flagged this person as a favorite.</summary>
        public bool? IsFavorite {
            get { return BackingStore?.Get<bool?>(nameof(IsFavorite)); }
            set { BackingStore?.Set(nameof(IsFavorite), value); }
        }
        /// <summary>The person&apos;s job title.</summary>
        public string JobTitle {
            get { return BackingStore?.Get<string>(nameof(JobTitle)); }
            set { BackingStore?.Set(nameof(JobTitle), value); }
        }
        /// <summary>The location of the person&apos;s office.</summary>
        public string OfficeLocation {
            get { return BackingStore?.Get<string>(nameof(OfficeLocation)); }
            set { BackingStore?.Set(nameof(OfficeLocation), value); }
        }
        /// <summary>Free-form notes that the user has taken about this person.</summary>
        public string PersonNotes {
            get { return BackingStore?.Get<string>(nameof(PersonNotes)); }
            set { BackingStore?.Set(nameof(PersonNotes), value); }
        }
        /// <summary>The type of person, for example distribution list.</summary>
        public Microsoft.Graph.Models.PersonType PersonType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PersonType>(nameof(PersonType)); }
            set { BackingStore?.Set(nameof(PersonType), value); }
        }
        /// <summary>The person&apos;s phone numbers.</summary>
        public List<Phone> Phones {
            get { return BackingStore?.Get<List<Phone>>(nameof(Phones)); }
            set { BackingStore?.Set(nameof(Phones), value); }
        }
        /// <summary>The person&apos;s addresses.</summary>
        public List<Location> PostalAddresses {
            get { return BackingStore?.Get<List<Location>>(nameof(PostalAddresses)); }
            set { BackingStore?.Set(nameof(PostalAddresses), value); }
        }
        /// <summary>The person&apos;s profession.</summary>
        public string Profession {
            get { return BackingStore?.Get<string>(nameof(Profession)); }
            set { BackingStore?.Set(nameof(Profession), value); }
        }
        /// <summary>The person&apos;s email addresses.</summary>
        public List<ScoredEmailAddress> ScoredEmailAddresses {
            get { return BackingStore?.Get<List<ScoredEmailAddress>>(nameof(ScoredEmailAddresses)); }
            set { BackingStore?.Set(nameof(ScoredEmailAddresses), value); }
        }
        /// <summary>The person&apos;s surname.</summary>
        public string Surname {
            get { return BackingStore?.Get<string>(nameof(Surname)); }
            set { BackingStore?.Set(nameof(Surname), value); }
        }
        /// <summary>The user principal name (UPN) of the person. The UPN is an Internet-style login name for the person based on the Internet standard RFC 822. By convention, this should map to the person&apos;s email name. The general format is alias@domain.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>The person&apos;s websites.</summary>
        public List<Website> Websites {
            get { return BackingStore?.Get<List<Website>>(nameof(Websites)); }
            set { BackingStore?.Set(nameof(Websites), value); }
        }
        /// <summary>The phonetic Japanese name of the person&apos;s company.</summary>
        public string YomiCompany {
            get { return BackingStore?.Get<string>(nameof(YomiCompany)); }
            set { BackingStore?.Set(nameof(YomiCompany), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Person CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Person();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"birthday", n => { Birthday = n.GetStringValue(); } },
                {"companyName", n => { CompanyName = n.GetStringValue(); } },
                {"department", n => { Department = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"givenName", n => { GivenName = n.GetStringValue(); } },
                {"imAddress", n => { ImAddress = n.GetStringValue(); } },
                {"isFavorite", n => { IsFavorite = n.GetBoolValue(); } },
                {"jobTitle", n => { JobTitle = n.GetStringValue(); } },
                {"officeLocation", n => { OfficeLocation = n.GetStringValue(); } },
                {"personNotes", n => { PersonNotes = n.GetStringValue(); } },
                {"personType", n => { PersonType = n.GetObjectValue<Microsoft.Graph.Models.PersonType>(Microsoft.Graph.Models.PersonType.CreateFromDiscriminatorValue); } },
                {"phones", n => { Phones = n.GetCollectionOfObjectValues<Phone>(Phone.CreateFromDiscriminatorValue).ToList(); } },
                {"postalAddresses", n => { PostalAddresses = n.GetCollectionOfObjectValues<Location>(Location.CreateFromDiscriminatorValue).ToList(); } },
                {"profession", n => { Profession = n.GetStringValue(); } },
                {"scoredEmailAddresses", n => { ScoredEmailAddresses = n.GetCollectionOfObjectValues<ScoredEmailAddress>(ScoredEmailAddress.CreateFromDiscriminatorValue).ToList(); } },
                {"surname", n => { Surname = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"websites", n => { Websites = n.GetCollectionOfObjectValues<Website>(Website.CreateFromDiscriminatorValue).ToList(); } },
                {"yomiCompany", n => { YomiCompany = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("birthday", Birthday);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("department", Department);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteStringValue("imAddress", ImAddress);
            writer.WriteBoolValue("isFavorite", IsFavorite);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("officeLocation", OfficeLocation);
            writer.WriteStringValue("personNotes", PersonNotes);
            writer.WriteObjectValue<Microsoft.Graph.Models.PersonType>("personType", PersonType);
            writer.WriteCollectionOfObjectValues<Phone>("phones", Phones);
            writer.WriteCollectionOfObjectValues<Location>("postalAddresses", PostalAddresses);
            writer.WriteStringValue("profession", Profession);
            writer.WriteCollectionOfObjectValues<ScoredEmailAddress>("scoredEmailAddresses", ScoredEmailAddresses);
            writer.WriteStringValue("surname", Surname);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteCollectionOfObjectValues<Website>("websites", Websites);
            writer.WriteStringValue("yomiCompany", YomiCompany);
        }
    }
}
