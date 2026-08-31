[![](https://img.shields.io/nuget/v/soenneker.paypal.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.paypal.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.paypal.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.paypal.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.paypal.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.paypal.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.paypal.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.paypal.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.PayPal.OpenApiClient

Typed request builders and models for PayPal REST APIs, including invoicing, payments, orders, subscriptions, disputes, and webhooks.

## Installation

```bash
dotnet add package Soenneker.PayPal.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.PayPal.OpenApiClient;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", accessToken);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);
adapter.BaseUrl = "https://api-m.sandbox.paypal.com";

var client = new PayPalOpenApiClient(adapter);
var eventTypes = await client.Notifications_webhooks_v1.V1.Notifications
    .WebhooksEventTypes
    .WithUrl($"{adapter.BaseUrl}/v1/notifications/webhooks-event-types")
    .GetAsync(cancellationToken: cancellationToken);
```

The generated client defaults to PayPal's sandbox API. Set the adapter base URL to `https://api-m.paypal.com` for live access.

The merged schema namespaces request paths by source document. Use `WithUrl(...)` with the real PayPal endpoint, as shown above, rather than sending the prefixed URL produced by a fluent builder directly.

For configuration-based access tokens, environment selection, and managed client reuse, use [`Soenneker.PayPal.OpenApiClientUtil`](https://github.com/soenneker/soenneker.paypal.openapiclientutil).
