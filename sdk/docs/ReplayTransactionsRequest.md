# Finbourne.Horizon.Sdk.Model.ReplayTransactionsRequest
Request to replay one or more transactions through a TPF instance. The instance ID is specified in the route path.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionIds** | **List&lt;string&gt;** | List of transaction IDs to replay. | 
**Mode** | **string** | Replay mode - DryRun (preview only) or Committed (real send). | 
**Destinations** | **List&lt;string&gt;** | Target destinations for Committed mode. Required for Committed, forbidden for DryRun. Valid values: Drive, Sftp, S3, Local | [optional] 
**Options** | [**ReplayOptions**](ReplayOptions.md) |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

List<string> transactionIds = new List<string>();
string mode = "mode";
List<string> destinations = new List<string>();
ReplayOptions? options = new ReplayOptions();


ReplayTransactionsRequest replayTransactionsRequestInstance = new ReplayTransactionsRequest(
    transactionIds: transactionIds,
    mode: mode,
    destinations: destinations,
    options: options);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
