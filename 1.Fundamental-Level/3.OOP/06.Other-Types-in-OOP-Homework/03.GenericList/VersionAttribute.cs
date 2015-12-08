using System;

namespace _03.GenericList
{
    [AttributeUsage(
        AttributeTargets.Struct |
        AttributeTargets.Class |
        AttributeTargets.Enum |
        AttributeTargets.Interface |
        AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        public VersionAttribute(int majorVersion, int minorVersion)
        {
            this.MajorVersion = majorVersion;
            this.MinorVersion = minorVersion;
        }

        public int MajorVersion { get; private set; }

        public int MinorVersion { get; private set; }

        public override string ToString()
        {
            return string.Format("Version {0}.{1}", this.MajorVersion, this.MinorVersion);
        }
    }
}
