using Environment = TestSdk.Http.Environment;

namespace TestSdk.Config;

public record TestSdkConfig(
    /// <value>The environment to use for the SDK.</value>
    Environment? Environment = null,
    /// <value>The access token.</value>
    string? AccessToken = null
);
