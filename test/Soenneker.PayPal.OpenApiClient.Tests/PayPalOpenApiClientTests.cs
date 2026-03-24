using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.PayPal.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class PayPalOpenApiClientTests : FixturedUnitTest
{
    public PayPalOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
