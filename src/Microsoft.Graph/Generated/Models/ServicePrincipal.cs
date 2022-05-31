using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to servicePrincipal.</summary>
    public class ServicePrincipal : DirectoryObject, IParsable {
        /// <summary>true if the service principal account is enabled; otherwise, false. Supports $filter (eq, ne, not, in).</summary>
        public bool? AccountEnabled {
            get { return BackingStore?.Get<bool?>(nameof(AccountEnabled)); }
            set { BackingStore?.Set(nameof(AccountEnabled), value); }
        }
        /// <summary>Defines custom behavior that a consuming service can use to call an app in specific contexts. For example, applications that can render file streams may set the addIns property for its &apos;FileHandler&apos; functionality. This will let services like Microsoft 365 call the application in the context of a document the user is working on.</summary>
        public List<AddIn> AddIns {
            get { return BackingStore?.Get<List<AddIn>>(nameof(AddIns)); }
            set { BackingStore?.Set(nameof(AddIns), value); }
        }
        /// <summary>Used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities. Supports $filter (eq, not, ge, le, startsWith).</summary>
        public List<string> AlternativeNames {
            get { return BackingStore?.Get<List<string>>(nameof(AlternativeNames)); }
            set { BackingStore?.Set(nameof(AlternativeNames), value); }
        }
        /// <summary>The description exposed by the associated application.</summary>
        public string AppDescription {
            get { return BackingStore?.Get<string>(nameof(AppDescription)); }
            set { BackingStore?.Set(nameof(AppDescription), value); }
        }
        /// <summary>The display name exposed by the associated application.</summary>
        public string AppDisplayName {
            get { return BackingStore?.Get<string>(nameof(AppDisplayName)); }
            set { BackingStore?.Set(nameof(AppDisplayName), value); }
        }
        /// <summary>The unique identifier for the associated application (its appId property). Supports $filter (eq, ne, not, in, startsWith).</summary>
        public string AppId {
            get { return BackingStore?.Get<string>(nameof(AppId)); }
            set { BackingStore?.Set(nameof(AppId), value); }
        }
        /// <summary>Unique identifier of the applicationTemplate that the servicePrincipal was created from. Read-only. Supports $filter (eq, ne, NOT, startsWith).</summary>
        public string ApplicationTemplateId {
            get { return BackingStore?.Get<string>(nameof(ApplicationTemplateId)); }
            set { BackingStore?.Set(nameof(ApplicationTemplateId), value); }
        }
        /// <summary>The appManagementPolicy applied to this service principal.</summary>
        public List<AppManagementPolicy> AppManagementPolicies {
            get { return BackingStore?.Get<List<AppManagementPolicy>>(nameof(AppManagementPolicies)); }
            set { BackingStore?.Set(nameof(AppManagementPolicies), value); }
        }
        /// <summary>Contains the tenant id where the application is registered. This is applicable only to service principals backed by applications.Supports $filter (eq, ne, NOT, ge, le).</summary>
        public string AppOwnerOrganizationId {
            get { return BackingStore?.Get<string>(nameof(AppOwnerOrganizationId)); }
            set { BackingStore?.Set(nameof(AppOwnerOrganizationId), value); }
        }
        /// <summary>App role assignments for this app or service, granted to users, groups, and other service principals.Supports $expand.</summary>
        public List<AppRoleAssignment> AppRoleAssignedTo {
            get { return BackingStore?.Get<List<AppRoleAssignment>>(nameof(AppRoleAssignedTo)); }
            set { BackingStore?.Set(nameof(AppRoleAssignedTo), value); }
        }
        /// <summary>Specifies whether users or other service principals need to be granted an app role assignment for this service principal before users can sign in or apps can get tokens. The default value is false. Not nullable. Supports $filter (eq, ne, NOT).</summary>
        public bool? AppRoleAssignmentRequired {
            get { return BackingStore?.Get<bool?>(nameof(AppRoleAssignmentRequired)); }
            set { BackingStore?.Set(nameof(AppRoleAssignmentRequired), value); }
        }
        /// <summary>App role assignment for another app or service, granted to this service principal. Supports $expand.</summary>
        public List<AppRoleAssignment> AppRoleAssignments {
            get { return BackingStore?.Get<List<AppRoleAssignment>>(nameof(AppRoleAssignments)); }
            set { BackingStore?.Set(nameof(AppRoleAssignments), value); }
        }
        /// <summary>The roles exposed by the application which this service principal represents. For more information see the appRoles property definition on the application entity. Not nullable.</summary>
        public List<AppRole> AppRoles {
            get { return BackingStore?.Get<List<AppRole>>(nameof(AppRoles)); }
            set { BackingStore?.Set(nameof(AppRoles), value); }
        }
        /// <summary>The claimsMappingPolicies assigned to this service principal. Supports $expand.</summary>
        public List<ClaimsMappingPolicy> ClaimsMappingPolicies {
            get { return BackingStore?.Get<List<ClaimsMappingPolicy>>(nameof(ClaimsMappingPolicies)); }
            set { BackingStore?.Set(nameof(ClaimsMappingPolicies), value); }
        }
        /// <summary>Directory objects created by this service principal. Read-only. Nullable.</summary>
        public List<DirectoryObject> CreatedObjects {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(CreatedObjects)); }
            set { BackingStore?.Set(nameof(CreatedObjects), value); }
        }
        /// <summary>An open complex type that holds the value of a custom security attribute that is assigned to a directory object. Nullable. Returned only on $select. Supports $filter (eq, ne, not, startsWith).</summary>
        public CustomSecurityAttributeValue CustomSecurityAttributes {
            get { return BackingStore?.Get<CustomSecurityAttributeValue>(nameof(CustomSecurityAttributes)); }
            set { BackingStore?.Set(nameof(CustomSecurityAttributes), value); }
        }
        /// <summary>The permission classifications for delegated permissions exposed by the app that this service principal represents. Supports $expand.</summary>
        public List<DelegatedPermissionClassification> DelegatedPermissionClassifications {
            get { return BackingStore?.Get<List<DelegatedPermissionClassification>>(nameof(DelegatedPermissionClassifications)); }
            set { BackingStore?.Set(nameof(DelegatedPermissionClassifications), value); }
        }
        /// <summary>Free text field to provide an internal end-user facing description of the service principal. End-user portals such MyApps will display the application description in this field. The maximum allowed size is 1024 characters. Supports $filter (eq, ne, not, ge, le, startsWith) and $search.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Specifies whether Microsoft has disabled the registered application. Possible values are: null (default value), NotDisabled, and DisabledDueToViolationOfServicesAgreement (reasons may include suspicious, abusive, or malicious activity, or a violation of the Microsoft Services Agreement).  Supports $filter (eq, ne, not).</summary>
        public string DisabledByMicrosoftStatus {
            get { return BackingStore?.Get<string>(nameof(DisabledByMicrosoftStatus)); }
            set { BackingStore?.Set(nameof(DisabledByMicrosoftStatus), value); }
        }
        /// <summary>The display name for the service principal. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Endpoints available for discovery. Services like Sharepoint populate this property with a tenant specific SharePoint endpoints that other applications can discover and use in their experiences.</summary>
        public List<Endpoint> Endpoints {
            get { return BackingStore?.Get<List<Endpoint>>(nameof(Endpoints)); }
            set { BackingStore?.Set(nameof(Endpoints), value); }
        }
        /// <summary>Deprecated. Don&apos;t use.</summary>
        public string ErrorUrl {
            get { return BackingStore?.Get<string>(nameof(ErrorUrl)); }
            set { BackingStore?.Set(nameof(ErrorUrl), value); }
        }
        /// <summary>The federatedIdentityCredentials property</summary>
        public List<FederatedIdentityCredential> FederatedIdentityCredentials {
            get { return BackingStore?.Get<List<FederatedIdentityCredential>>(nameof(FederatedIdentityCredentials)); }
            set { BackingStore?.Set(nameof(FederatedIdentityCredentials), value); }
        }
        /// <summary>Home page or landing page of the application.</summary>
        public string Homepage {
            get { return BackingStore?.Get<string>(nameof(Homepage)); }
            set { BackingStore?.Set(nameof(Homepage), value); }
        }
        /// <summary>The homeRealmDiscoveryPolicies assigned to this service principal. Supports $expand.</summary>
        public List<HomeRealmDiscoveryPolicy> HomeRealmDiscoveryPolicies {
            get { return BackingStore?.Get<List<HomeRealmDiscoveryPolicy>>(nameof(HomeRealmDiscoveryPolicies)); }
            set { BackingStore?.Set(nameof(HomeRealmDiscoveryPolicies), value); }
        }
        /// <summary>Basic profile information of the acquired application such as app&apos;s marketing, support, terms of service and privacy statement URLs. The terms of service and privacy statement are surfaced to users through the user consent experience. For more info, see How to: Add Terms of service and privacy statement for registered Azure AD apps. Supports $filter (eq, ne, not, ge, le, and eq on null values).</summary>
        public InformationalUrl Info {
            get { return BackingStore?.Get<InformationalUrl>(nameof(Info)); }
            set { BackingStore?.Set(nameof(Info), value); }
        }
        /// <summary>The collection of key credentials associated with the service principal. Not nullable. Supports $filter (eq, not, ge, le).</summary>
        public List<KeyCredential> KeyCredentials {
            get { return BackingStore?.Get<List<KeyCredential>>(nameof(KeyCredentials)); }
            set { BackingStore?.Set(nameof(KeyCredentials), value); }
        }
        /// <summary>The licenseDetails property</summary>
        public List<Microsoft.Graph.Beta.Models.LicenseDetails> LicenseDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.LicenseDetails>>(nameof(LicenseDetails)); }
            set { BackingStore?.Set(nameof(LicenseDetails), value); }
        }
        /// <summary>Specifies the URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on. The user launches the application from Microsoft 365, the Azure AD My Apps, or the Azure AD SSO URL.</summary>
        public string LoginUrl {
            get { return BackingStore?.Get<string>(nameof(LoginUrl)); }
            set { BackingStore?.Set(nameof(LoginUrl), value); }
        }
        /// <summary>Specifies the URL that will be used by Microsoft&apos;s authorization service to logout an user using OpenId Connect front-channel, back-channel or SAML logout protocols.</summary>
        public string LogoutUrl {
            get { return BackingStore?.Get<string>(nameof(LogoutUrl)); }
            set { BackingStore?.Set(nameof(LogoutUrl), value); }
        }
        /// <summary>Roles that this service principal is a member of. HTTP Methods: GET Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> MemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(MemberOf)); }
            set { BackingStore?.Set(nameof(MemberOf), value); }
        }
        /// <summary>Free text field to capture information about the service principal, typically used for operational purposes. Maximum allowed size is 1024 characters.</summary>
        public string Notes {
            get { return BackingStore?.Get<string>(nameof(Notes)); }
            set { BackingStore?.Set(nameof(Notes), value); }
        }
        /// <summary>Specifies the list of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications.</summary>
        public List<string> NotificationEmailAddresses {
            get { return BackingStore?.Get<List<string>>(nameof(NotificationEmailAddresses)); }
            set { BackingStore?.Set(nameof(NotificationEmailAddresses), value); }
        }
        /// <summary>Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user. Read-only. Nullable.</summary>
        public List<OAuth2PermissionGrant> Oauth2PermissionGrants {
            get { return BackingStore?.Get<List<OAuth2PermissionGrant>>(nameof(Oauth2PermissionGrants)); }
            set { BackingStore?.Set(nameof(Oauth2PermissionGrants), value); }
        }
        /// <summary>Directory objects that are owned by this service principal. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> OwnedObjects {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(OwnedObjects)); }
            set { BackingStore?.Set(nameof(OwnedObjects), value); }
        }
        /// <summary>Directory objects that are owners of this servicePrincipal. The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> Owners {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(Owners)); }
            set { BackingStore?.Set(nameof(Owners), value); }
        }
        /// <summary>The collection of password credentials associated with the service principal. Not nullable.</summary>
        public List<PasswordCredential> PasswordCredentials {
            get { return BackingStore?.Get<List<PasswordCredential>>(nameof(PasswordCredentials)); }
            set { BackingStore?.Set(nameof(PasswordCredentials), value); }
        }
        /// <summary>The collection for settings related to password single sign-on. Use $select=passwordSingleSignOnSettings to read the property. Read-only for applicationTemplates except for custom applicationTemplates.</summary>
        public Microsoft.Graph.Beta.Models.PasswordSingleSignOnSettings PasswordSingleSignOnSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PasswordSingleSignOnSettings>(nameof(PasswordSingleSignOnSettings)); }
            set { BackingStore?.Set(nameof(PasswordSingleSignOnSettings), value); }
        }
        /// <summary>Specifies the single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps. The supported values are password, saml, notSupported, and oidc.</summary>
        public string PreferredSingleSignOnMode {
            get { return BackingStore?.Get<string>(nameof(PreferredSingleSignOnMode)); }
            set { BackingStore?.Set(nameof(PreferredSingleSignOnMode), value); }
        }
        /// <summary>Specifies the expiration date of the keyCredential used for token signing, marked by preferredTokenSigningKeyThumbprint.</summary>
        public DateTimeOffset? PreferredTokenSigningKeyEndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(PreferredTokenSigningKeyEndDateTime)); }
            set { BackingStore?.Set(nameof(PreferredTokenSigningKeyEndDateTime), value); }
        }
        /// <summary>Reserved for internal use only. Do not write or otherwise rely on this property. May be removed in future versions.</summary>
        public string PreferredTokenSigningKeyThumbprint {
            get { return BackingStore?.Get<string>(nameof(PreferredTokenSigningKeyThumbprint)); }
            set { BackingStore?.Set(nameof(PreferredTokenSigningKeyThumbprint), value); }
        }
        /// <summary>The delegated permissions exposed by the application. For more information see the oauth2PermissionScopes property on the application entity&apos;s api property. Not nullable. Note: This property is named oauth2PermissionScopes in v1.0.</summary>
        public List<PermissionScope> PublishedPermissionScopes {
            get { return BackingStore?.Get<List<PermissionScope>>(nameof(PublishedPermissionScopes)); }
            set { BackingStore?.Set(nameof(PublishedPermissionScopes), value); }
        }
        /// <summary>The publisherName property</summary>
        public string PublisherName {
            get { return BackingStore?.Get<string>(nameof(PublisherName)); }
            set { BackingStore?.Set(nameof(PublisherName), value); }
        }
        /// <summary>The URLs that user tokens are sent to for sign in with the associated application, or the redirect URIs that OAuth 2.0 authorization codes and access tokens are sent to for the associated application. Not nullable.</summary>
        public List<string> ReplyUrls {
            get { return BackingStore?.Get<List<string>>(nameof(ReplyUrls)); }
            set { BackingStore?.Set(nameof(ReplyUrls), value); }
        }
        /// <summary>The url where the service exposes SAML metadata for federation.</summary>
        public string SamlMetadataUrl {
            get { return BackingStore?.Get<string>(nameof(SamlMetadataUrl)); }
            set { BackingStore?.Set(nameof(SamlMetadataUrl), value); }
        }
        /// <summary>The collection for settings related to saml single sign-on.</summary>
        public Microsoft.Graph.Beta.Models.SamlSingleSignOnSettings SamlSingleSignOnSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SamlSingleSignOnSettings>(nameof(SamlSingleSignOnSettings)); }
            set { BackingStore?.Set(nameof(SamlSingleSignOnSettings), value); }
        }
        /// <summary>Contains the list of identifiersUris, copied over from the associated application. Additional values can be added to hybrid applications. These values can be used to identify the permissions exposed by this app within Azure AD. For example,Client apps can specify a resource URI which is based on the values of this property to acquire an access token, which is the URI returned in the &apos;aud&apos; claim.The any operator is required for filter expressions on multi-valued properties. Not nullable.  Supports $filter (eq, not, ge, le, startsWith).</summary>
        public List<string> ServicePrincipalNames {
            get { return BackingStore?.Get<List<string>>(nameof(ServicePrincipalNames)); }
            set { BackingStore?.Set(nameof(ServicePrincipalNames), value); }
        }
        /// <summary>Identifies if the service principal represents an application or a managed identity. This is set by Azure AD internally. For a service principal that represents an application this is set as Application. For a service principal that represent a managed identity this is set as ManagedIdentity. The SocialIdp type is for internal use.</summary>
        public string ServicePrincipalType {
            get { return BackingStore?.Get<string>(nameof(ServicePrincipalType)); }
            set { BackingStore?.Set(nameof(ServicePrincipalType), value); }
        }
        /// <summary>Specifies the Microsoft accounts that are supported for the current application. Read-only. Supported values are:AzureADMyOrg: Users with a Microsoft work or school account in my organization’s Azure AD tenant (single-tenant).AzureADMultipleOrgs: Users with a Microsoft work or school account in any organization’s Azure AD tenant (multi-tenant).AzureADandPersonalMicrosoftAccount: Users with a personal Microsoft account, or a work or school account in any organization’s Azure AD tenant.PersonalMicrosoftAccount: Users with a personal Microsoft account only.</summary>
        public string SignInAudience {
            get { return BackingStore?.Get<string>(nameof(SignInAudience)); }
            set { BackingStore?.Set(nameof(SignInAudience), value); }
        }
        /// <summary>The synchronization property</summary>
        public Microsoft.Graph.Beta.Models.Synchronization Synchronization {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Synchronization>(nameof(Synchronization)); }
            set { BackingStore?.Set(nameof(Synchronization), value); }
        }
        /// <summary>Custom strings that can be used to categorize and identify the service principal. Not nullable. Supports $filter (eq, not, ge, le, startsWith).</summary>
        public List<string> Tags {
            get { return BackingStore?.Get<List<string>>(nameof(Tags)); }
            set { BackingStore?.Set(nameof(Tags), value); }
        }
        /// <summary>Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD issues tokens for this application encrypted using the key specified by this property. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.</summary>
        public string TokenEncryptionKeyId {
            get { return BackingStore?.Get<string>(nameof(TokenEncryptionKeyId)); }
            set { BackingStore?.Set(nameof(TokenEncryptionKeyId), value); }
        }
        /// <summary>The tokenIssuancePolicies assigned to this service principal. Supports $expand.</summary>
        public List<TokenIssuancePolicy> TokenIssuancePolicies {
            get { return BackingStore?.Get<List<TokenIssuancePolicy>>(nameof(TokenIssuancePolicies)); }
            set { BackingStore?.Set(nameof(TokenIssuancePolicies), value); }
        }
        /// <summary>The tokenLifetimePolicies assigned to this service principal. Supports $expand.</summary>
        public List<TokenLifetimePolicy> TokenLifetimePolicies {
            get { return BackingStore?.Get<List<TokenLifetimePolicy>>(nameof(TokenLifetimePolicies)); }
            set { BackingStore?.Set(nameof(TokenLifetimePolicies), value); }
        }
        /// <summary>The transitiveMemberOf property</summary>
        public List<DirectoryObject> TransitiveMemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(TransitiveMemberOf)); }
            set { BackingStore?.Set(nameof(TransitiveMemberOf), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ServicePrincipal CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServicePrincipal();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountEnabled", n => { AccountEnabled = n.GetBoolValue(); } },
                {"addIns", n => { AddIns = n.GetCollectionOfObjectValues<AddIn>(AddIn.CreateFromDiscriminatorValue).ToList(); } },
                {"alternativeNames", n => { AlternativeNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"appDescription", n => { AppDescription = n.GetStringValue(); } },
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"applicationTemplateId", n => { ApplicationTemplateId = n.GetStringValue(); } },
                {"appManagementPolicies", n => { AppManagementPolicies = n.GetCollectionOfObjectValues<AppManagementPolicy>(AppManagementPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"appOwnerOrganizationId", n => { AppOwnerOrganizationId = n.GetStringValue(); } },
                {"appRoleAssignedTo", n => { AppRoleAssignedTo = n.GetCollectionOfObjectValues<AppRoleAssignment>(AppRoleAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"appRoleAssignmentRequired", n => { AppRoleAssignmentRequired = n.GetBoolValue(); } },
                {"appRoleAssignments", n => { AppRoleAssignments = n.GetCollectionOfObjectValues<AppRoleAssignment>(AppRoleAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"appRoles", n => { AppRoles = n.GetCollectionOfObjectValues<AppRole>(AppRole.CreateFromDiscriminatorValue).ToList(); } },
                {"claimsMappingPolicies", n => { ClaimsMappingPolicies = n.GetCollectionOfObjectValues<ClaimsMappingPolicy>(ClaimsMappingPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"createdObjects", n => { CreatedObjects = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"customSecurityAttributes", n => { CustomSecurityAttributes = n.GetObjectValue<CustomSecurityAttributeValue>(CustomSecurityAttributeValue.CreateFromDiscriminatorValue); } },
                {"delegatedPermissionClassifications", n => { DelegatedPermissionClassifications = n.GetCollectionOfObjectValues<DelegatedPermissionClassification>(DelegatedPermissionClassification.CreateFromDiscriminatorValue).ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"disabledByMicrosoftStatus", n => { DisabledByMicrosoftStatus = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"endpoints", n => { Endpoints = n.GetCollectionOfObjectValues<Endpoint>(Endpoint.CreateFromDiscriminatorValue).ToList(); } },
                {"errorUrl", n => { ErrorUrl = n.GetStringValue(); } },
                {"federatedIdentityCredentials", n => { FederatedIdentityCredentials = n.GetCollectionOfObjectValues<FederatedIdentityCredential>(FederatedIdentityCredential.CreateFromDiscriminatorValue).ToList(); } },
                {"homepage", n => { Homepage = n.GetStringValue(); } },
                {"homeRealmDiscoveryPolicies", n => { HomeRealmDiscoveryPolicies = n.GetCollectionOfObjectValues<HomeRealmDiscoveryPolicy>(HomeRealmDiscoveryPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"info", n => { Info = n.GetObjectValue<InformationalUrl>(InformationalUrl.CreateFromDiscriminatorValue); } },
                {"keyCredentials", n => { KeyCredentials = n.GetCollectionOfObjectValues<KeyCredential>(KeyCredential.CreateFromDiscriminatorValue).ToList(); } },
                {"licenseDetails", n => { LicenseDetails = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.LicenseDetails>(Microsoft.Graph.Beta.Models.LicenseDetails.CreateFromDiscriminatorValue).ToList(); } },
                {"loginUrl", n => { LoginUrl = n.GetStringValue(); } },
                {"logoutUrl", n => { LogoutUrl = n.GetStringValue(); } },
                {"memberOf", n => { MemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"notificationEmailAddresses", n => { NotificationEmailAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"oauth2PermissionGrants", n => { Oauth2PermissionGrants = n.GetCollectionOfObjectValues<OAuth2PermissionGrant>(OAuth2PermissionGrant.CreateFromDiscriminatorValue).ToList(); } },
                {"ownedObjects", n => { OwnedObjects = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"owners", n => { Owners = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"passwordCredentials", n => { PasswordCredentials = n.GetCollectionOfObjectValues<PasswordCredential>(PasswordCredential.CreateFromDiscriminatorValue).ToList(); } },
                {"passwordSingleSignOnSettings", n => { PasswordSingleSignOnSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.PasswordSingleSignOnSettings>(Microsoft.Graph.Beta.Models.PasswordSingleSignOnSettings.CreateFromDiscriminatorValue); } },
                {"preferredSingleSignOnMode", n => { PreferredSingleSignOnMode = n.GetStringValue(); } },
                {"preferredTokenSigningKeyEndDateTime", n => { PreferredTokenSigningKeyEndDateTime = n.GetDateTimeOffsetValue(); } },
                {"preferredTokenSigningKeyThumbprint", n => { PreferredTokenSigningKeyThumbprint = n.GetStringValue(); } },
                {"publishedPermissionScopes", n => { PublishedPermissionScopes = n.GetCollectionOfObjectValues<PermissionScope>(PermissionScope.CreateFromDiscriminatorValue).ToList(); } },
                {"publisherName", n => { PublisherName = n.GetStringValue(); } },
                {"replyUrls", n => { ReplyUrls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"samlMetadataUrl", n => { SamlMetadataUrl = n.GetStringValue(); } },
                {"samlSingleSignOnSettings", n => { SamlSingleSignOnSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.SamlSingleSignOnSettings>(Microsoft.Graph.Beta.Models.SamlSingleSignOnSettings.CreateFromDiscriminatorValue); } },
                {"servicePrincipalNames", n => { ServicePrincipalNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"servicePrincipalType", n => { ServicePrincipalType = n.GetStringValue(); } },
                {"signInAudience", n => { SignInAudience = n.GetStringValue(); } },
                {"synchronization", n => { Synchronization = n.GetObjectValue<Microsoft.Graph.Beta.Models.Synchronization>(Microsoft.Graph.Beta.Models.Synchronization.CreateFromDiscriminatorValue); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"tokenEncryptionKeyId", n => { TokenEncryptionKeyId = n.GetStringValue(); } },
                {"tokenIssuancePolicies", n => { TokenIssuancePolicies = n.GetCollectionOfObjectValues<TokenIssuancePolicy>(TokenIssuancePolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"tokenLifetimePolicies", n => { TokenLifetimePolicies = n.GetCollectionOfObjectValues<TokenLifetimePolicy>(TokenLifetimePolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"transitiveMemberOf", n => { TransitiveMemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("accountEnabled", AccountEnabled);
            writer.WriteCollectionOfObjectValues<AddIn>("addIns", AddIns);
            writer.WriteCollectionOfPrimitiveValues<string>("alternativeNames", AlternativeNames);
            writer.WriteStringValue("appDescription", AppDescription);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("applicationTemplateId", ApplicationTemplateId);
            writer.WriteCollectionOfObjectValues<AppManagementPolicy>("appManagementPolicies", AppManagementPolicies);
            writer.WriteStringValue("appOwnerOrganizationId", AppOwnerOrganizationId);
            writer.WriteCollectionOfObjectValues<AppRoleAssignment>("appRoleAssignedTo", AppRoleAssignedTo);
            writer.WriteBoolValue("appRoleAssignmentRequired", AppRoleAssignmentRequired);
            writer.WriteCollectionOfObjectValues<AppRoleAssignment>("appRoleAssignments", AppRoleAssignments);
            writer.WriteCollectionOfObjectValues<AppRole>("appRoles", AppRoles);
            writer.WriteCollectionOfObjectValues<ClaimsMappingPolicy>("claimsMappingPolicies", ClaimsMappingPolicies);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("createdObjects", CreatedObjects);
            writer.WriteObjectValue<CustomSecurityAttributeValue>("customSecurityAttributes", CustomSecurityAttributes);
            writer.WriteCollectionOfObjectValues<DelegatedPermissionClassification>("delegatedPermissionClassifications", DelegatedPermissionClassifications);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("disabledByMicrosoftStatus", DisabledByMicrosoftStatus);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Endpoint>("endpoints", Endpoints);
            writer.WriteStringValue("errorUrl", ErrorUrl);
            writer.WriteCollectionOfObjectValues<FederatedIdentityCredential>("federatedIdentityCredentials", FederatedIdentityCredentials);
            writer.WriteStringValue("homepage", Homepage);
            writer.WriteCollectionOfObjectValues<HomeRealmDiscoveryPolicy>("homeRealmDiscoveryPolicies", HomeRealmDiscoveryPolicies);
            writer.WriteObjectValue<InformationalUrl>("info", Info);
            writer.WriteCollectionOfObjectValues<KeyCredential>("keyCredentials", KeyCredentials);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.LicenseDetails>("licenseDetails", LicenseDetails);
            writer.WriteStringValue("loginUrl", LoginUrl);
            writer.WriteStringValue("logoutUrl", LogoutUrl);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("memberOf", MemberOf);
            writer.WriteStringValue("notes", Notes);
            writer.WriteCollectionOfPrimitiveValues<string>("notificationEmailAddresses", NotificationEmailAddresses);
            writer.WriteCollectionOfObjectValues<OAuth2PermissionGrant>("oauth2PermissionGrants", Oauth2PermissionGrants);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("ownedObjects", OwnedObjects);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("owners", Owners);
            writer.WriteCollectionOfObjectValues<PasswordCredential>("passwordCredentials", PasswordCredentials);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PasswordSingleSignOnSettings>("passwordSingleSignOnSettings", PasswordSingleSignOnSettings);
            writer.WriteStringValue("preferredSingleSignOnMode", PreferredSingleSignOnMode);
            writer.WriteDateTimeOffsetValue("preferredTokenSigningKeyEndDateTime", PreferredTokenSigningKeyEndDateTime);
            writer.WriteStringValue("preferredTokenSigningKeyThumbprint", PreferredTokenSigningKeyThumbprint);
            writer.WriteCollectionOfObjectValues<PermissionScope>("publishedPermissionScopes", PublishedPermissionScopes);
            writer.WriteStringValue("publisherName", PublisherName);
            writer.WriteCollectionOfPrimitiveValues<string>("replyUrls", ReplyUrls);
            writer.WriteStringValue("samlMetadataUrl", SamlMetadataUrl);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SamlSingleSignOnSettings>("samlSingleSignOnSettings", SamlSingleSignOnSettings);
            writer.WriteCollectionOfPrimitiveValues<string>("servicePrincipalNames", ServicePrincipalNames);
            writer.WriteStringValue("servicePrincipalType", ServicePrincipalType);
            writer.WriteStringValue("signInAudience", SignInAudience);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Synchronization>("synchronization", Synchronization);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("tokenEncryptionKeyId", TokenEncryptionKeyId);
            writer.WriteCollectionOfObjectValues<TokenIssuancePolicy>("tokenIssuancePolicies", TokenIssuancePolicies);
            writer.WriteCollectionOfObjectValues<TokenLifetimePolicy>("tokenLifetimePolicies", TokenLifetimePolicies);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("transitiveMemberOf", TransitiveMemberOf);
        }
    }
}
