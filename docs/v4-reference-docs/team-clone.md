---
title: "Clone a team"
description: "Create a copy of a team. This operation also creates a copy of the corresponding group."
author: "nkramer"
ms.localizationpriority: medium
ms.prod: "microsoft-teams"
doc_type: apiPageType
---

# Clone a team

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a copy of a [team](../resources/team.md). This operation also creates a copy of the corresponding [group](../resources/group.md).
You can specify which parts of the team to clone:

- **apps** - Copies Microsoft Teams apps that are installed in the team. 
- **channels** – Copies the channel structure (but not the messages in the channel).
- **members** – Copies the members and owners of the group.
- **settings** – Copies all settings within the team, along with key group settings.
- **tabs** – Copies the tabs within channels.

When tabs are cloned, they are put into an unconfigured state 
-- they are displayed on the tab bar in Microsoft Teams, and the first time you open them, you'll go through the configuration screen. 
(If the person opening the tab does not have permission to configure apps, they will see a message explaining that the tab hasn't been configured.)

Cloning is a long-running operation.
After the POST clone returns, you need to GET the [operation](../resources/teamsasyncoperation.md) 
returned by the Location: header to see if it's "running" or "succeeded" or "failed". 
You should continue to GET until the status is not "running". 
The recommended delay between GETs is 5 seconds.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | Team.Create, Group.ReadWrite.All**, Directory.ReadWrite.All** |
|Delegated (personal Microsoft account) | Not supported.    |
|Application                            | Team.Create, Group.ReadWrite.All**, Directory.ReadWrite.All** |

> **Note**: Permissions marked with ** are supported only for backward compatibility. We recommend that you update your solutions to use an alternative permission listed in the previous table and avoid using these permissions going forward.

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /teams/{id}/clone
```

## Request headers
| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |
| Content-Type  | application/json  |

## Request body

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
|classification|String (optional)|Describes a classification for the group (such as low, medium or high business impact). Valid values for this property are defined by creating a ClassificationList [setting](../resources/directorysetting.md) value, based on the [template definition](../resources/directorysettingtemplate.md). If classification is not specified, the classification will be copied from the original team/group.|
|description|String (optional)|An optional description for the group. If this property is not specified, it will be left blank.|
|displayName|String|The display name for the group. This property is required when a group is created and it cannot be cleared during updates. Supports $filter and $orderby.|
|mailNickname|String|The mail alias for the group, unique in the organization. This property must be specified when a group is created. Supports $filter. If this property is not specified, it will be computed from the displayName. Known issue: this property is currently ignored.|
|partsToClone| [clonableTeamParts](../resources/clonableteamparts.md) |A comma-separated list of the parts to clone. Legal parts are "apps, tabs, settings, channels, members".|
|visibility|[teamVisibilityType](../resources/teamvisibilitytype.md) (optional)| Specifies the visibility of the group. Possible values are: **Private**, **Public**. If visibility is not specified, the visibility will be copied from the original team/group. If the team being cloned is an **educationClass** team, the visibility parameter is ignored, and the new group's visibility will be set to HiddenMembership.|

## Response

If successful, this method will return a `202 Accepted` response code with a Location: header pointing to the [operation](../resources/teamsasyncoperation.md) resource.
When the operation is complete, the operation resource will tell you the id of the created team.

## Example
#### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "clone_team"
}-->
```http
POST /teams/{id}/clone
Content-Type: application/json

{  
     "displayName": "Library Assist",
     "description": "Self help community for library",
     "mailNickname": "libassist",
     "partsToClone": "apps,tabs,settings,channels,members",
     "visibility": "public"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var displayName = "Library Assist";

var description = "Self help community for library";

var mailNickname = "libassist";

var partsToClone = ClonableTeamParts.Apps | ClonableTeamParts.Tabs | ClonableTeamParts.Settings | ClonableTeamParts.Channels | ClonableTeamParts.Members;

var visibility = TeamVisibilityType.Public;

await graphClient.Teams["{team-id}"]
	.Clone(visibility,partsToClone,displayName,description,mailNickname,null)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The following is an example of the response. Note: The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response"
} -->
```http
HTTP/1.1 202 Accepted
Location: /teams({id})/operations({opId})
Content-Type: text/plain
Content-Length: 0
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Create Team",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": []
}
-->


