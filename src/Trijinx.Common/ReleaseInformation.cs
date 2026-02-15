using System;
using System.Reflection;

namespace Trijinx.Common
{
    // DO NOT EDIT, filled by CI
    public static class ReleaseInformation
    {
        private const string CanaryChannel = "canary";
        private const string ReleaseChannel = "release";

        private const string BuildVersion = "%%TRIJINX_BUILD_VERSION%%";
        private const string BuildGitHash = "%%TRIJINX_BUILD_GIT_HASH%%";
        private const string ReleaseChannelName = "%%TRIJINX_TARGET_RELEASE_CHANNEL_NAME%%";
        private const string ConfigFileName = "%%TRIJINX_CONFIG_FILE_NAME%%";

        public static string ConfigName => !ConfigFileName.StartsWith("%%") ? ConfigFileName : "Config.json";

        public static bool IsValid =>
            !BuildGitHash.StartsWith("%%") &&
            !ReleaseChannelName.StartsWith("%%") &&
            !ConfigFileName.StartsWith("%%");

        public static bool IsCanaryBuild => IsValid && ReleaseChannelName.Equals(CanaryChannel);

        public static bool IsReleaseBuild => IsValid && ReleaseChannelName.Equals(ReleaseChannel);

        public static string Version => IsValid ? BuildVersion : Assembly.GetEntryAssembly()!.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;

        public static string GetChangelogUrl(Version currentVersion, Version newVersion) =>
            IsCanaryBuild
                ? $"https://git.trijinx.app/trijinx/trijinx/-/compare/Canary-{currentVersion}...Canary-{newVersion}"
                : $"https://git.trijinx.app/trijinx/trijinx/-/releases/{newVersion}";
    }


}
