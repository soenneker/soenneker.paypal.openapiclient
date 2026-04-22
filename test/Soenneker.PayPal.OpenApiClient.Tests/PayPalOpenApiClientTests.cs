using Soenneker.Tests.HostedUnit;

namespace Soenneker.PayPal.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PayPalOpenApiClientTests : HostedUnitTest
{
    public PayPalOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
